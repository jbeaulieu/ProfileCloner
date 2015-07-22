/*****************************
 * ProfileClone Tool
 * Authored by Jon Beaulieu
 * Version 0.1.3
 * Most Recent Edit: 7/21/2015
 ****************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileClone
{
    public partial class mainForm : Form
    {
        // sourceList will contain the list of directories that we wish to back up
        List<string> sourceList = new List<string>();

        // Build the list of available system drives
        System.IO.DriveInfo[] driveArray = System.IO.DriveInfo.GetDrives();

        public mainForm()
        {
            InitializeComponent();

            /* On starting the application, populate the two comboBoxes (where the user
             * selects an import & export drive) with all available drives from the drive list.
             * The first comboBox will default to the first available drive (usually C:\),
             * while the second comboBox will default to the next available drive. */

            /* DEVELOPMENT NOTE: The naming of the two drive selections (import vs export drive)
             * may be confusing for anyone outside who is examining the source. Possible rename
             * might be something along the lines of "readDrive" and "writeDrive".
             * SEVERITY: LOW */

            for (int i = 0; i < driveArray.Length; i++)
            {
                driveBox1.Items.Add(driveArray[i]);
                driveBox2.Items.Add(driveArray[i]);
            }
            
            driveBox1.SelectedIndex = 0;
            driveBox2.SelectedIndex = 0;

            driveRefresh(1);
            driveRefresh(2);
        }

        /// <summary> driveBox_SelectedIndexChanged()
        /// NOTE: THIS DESCRIPTION APPLIES TO BOTH driveBox1_SelectedIndexChanged() and driveBox2_SelectedIndexChanged()
        /// Handles the event of changing the selected drive
        /// </summary>
        private void driveBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            driveRefresh(1);
        }
        private void driveBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            driveRefresh(2);
        }

        /// <summary> showHiddenCheckBox_CheckedChanged()
        /// This code runs if the "show hidden users" option is changed.
        /// In this case, we simply refresh both drives. The driveRefresh()
        /// function handles hiding/displaying any hidden profiles.
        /// </summary>
        private void showHiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            driveRefresh(1);
            driveRefresh(2);
        }

        /// <summary> drive1Refresh()
        /// Refreshes the list of user profiles available for selection on drive 1.
        /// This function should be called anytime drive 1 is changed, or the option
        /// to view hidden profiles is enabled/disabled.
        /// </summary>
        public void driveRefresh(int index)
        {
            ComboBox selectedDriveBox = new ComboBox();
            ListBox selectedListBox = new ListBox();

            // Get the selected items based on index
            switch(index)
            {
                case 1:
                    selectedDriveBox = driveBox1;
                    selectedListBox = userList1;
                    break;
                case 2:
                    selectedDriveBox = driveBox2;
                    selectedListBox = userList2;
                    break;
            }
            
            // Empty the current list of items
            selectedListBox.Items.Clear();

            // Check if the disk is ready before attempting to read from it
            if (driveArray[selectedDriveBox.SelectedIndex].IsReady)
            {
                try
                {
                    // The parent path is X:\Users\ (where X is the selected drive letter)
                    string path = selectedDriveBox.SelectedItem.ToString() + @"Users\";

                    /* DEVELOPMENT NOTE: the foreach statement in this method occurs regardless of the result of the
                     * if statement. Consider restructuring this by moving the showHiddenCheckBox evaluation inside of
                     * the foreach loop. This should reduce code length, but may hinder efficiency.
                     * SEVERITY: MEDIUM */

                    if (showHiddenCheckBox.Checked)     // If the user has elected to view hidden profiles
                    {
                        foreach (string userDirectory in System.IO.Directory.GetDirectories(path))
                        {
                            // Iterate through all subdirectories of the parent path, add them to the profile list
                            string user = userDirectory.Substring(9);
                            selectedListBox.Items.Add(user);
                        }
                    }
                    else    // If hidden profiles should not be shown (default)
                    {
                        foreach (string userFolder in System.IO.Directory.GetDirectories(path))
                        {
                            string folder = Path.Combine(path, userFolder);
                            DirectoryInfo folderInfo = new DirectoryInfo(folder);

                            // Only copy a file if isn't marked with a "hidden" attribute
                            if ((folderInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                            {
                                string user = userFolder.Substring(9);
                                selectedListBox.Items.Add(user);
                            }
                        }
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    DialogResult answer = new DialogResult();

                    switch(index)
                    {
                        case 1: answer = MessageBox.Show("Warning: ProfileCloner was unable to detect a Windows directory on the selected volume. "
                            +"Would you like to specify a custom location to read files from?","Caught DirectoryNotFoundException",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            break;
                        case 2: answer = MessageBox.Show("Warning: ProfileCloner was unable to detect a Windows directory on the selected volume. "
                            + "Would you like to specify a custom location to write files to?", "Caught DirectoryNotFoundException",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            break;
                    }

                    if(answer==DialogResult.Yes)
                    {
                        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

                        if (folderBrowser.ShowDialog() == DialogResult.OK)
                        {
                            switch(index)
                            {
                                default: MessageBox.Show("DOING THE THING!");
                                    break;
                            }
                        }
                    }
                    else if(answer==DialogResult.No)
                    {
                        switch(index)
                        {
                            case 1: driveBox1.SelectedIndex = 0;
                                driveRefresh(1);
                                break;
                            case 2: driveBox2.SelectedIndex = 0;
                                driveRefresh(2);
                                break;
                            default:
                                break;
                        }
                    } 
                }
            }
            else
            {
                MessageBox.Show("Whoops! Looks like the drive you selected isn't ready. If you selected an optical drive, please make sure that "
                    + "a disc is inserted. Otherwise, check that you can view the drive's contents in Windows Explorer.");
            }
        }

        /// <summary> resetButtonClick()
        /// Handles the action to take when the reset button is clicked. This method should essentially return
        /// all settings to their defaults, and clear any selected values. The end result is that the form looks
        /// exactly the same as when the program first starts up.
        /// </summary>
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Set both drive selection boxes back to their default selections
            driveBox1.SelectedIndex = 0;
            driveBox2.SelectedIndex = 0;

            // Refresh the drives to show the default drive contents in the userList boxes
            driveRefresh(1);
            driveRefresh(2);

            // Return the "show hidden profiles" option to its default (hide)
            showHiddenCheckBox.Checked = false;

            // Clear any selected entries in the libraries listBox
            librariesListBox.ClearSelected();

            // Clear any checked entries in the libraries listBox
            foreach(int index in librariesListBox.CheckedIndices)
            {
                librariesListBox.SetItemCheckState(index, CheckState.Unchecked);
            }

            outlookCheckBox.Checked = false;

            // Clear any additional selected directories
            addDirectoryTextBox1.Clear();
            addDirectoryTextBox2.Clear();
            addDirectoryTextBox3.Clear();
        }

        /// <summary> addDirectoryButtons()
        /// THIS SUMMARY COVERS ALL THREE "addDirectoryButton" EVENT HANDLERS BELOW.
        /// Handles the addition and selection of an additional directory to back up that is
        /// not already present on the form. The user should be presented with a folderDialog
        /// box that allows him/her to choose an additional working directory that they wish
        /// to duplicate. After selection, that directory should appear in the textBox to the
        /// left of the button, as confirmation it was selected properly.
        /// </summary>
        private void addDirectoryButton1_Click(object sender, EventArgs e)
        {
            string folderPath = "";

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowser.SelectedPath;
            }

            addDirectoryTextBox1.Text = folderPath;
        }
        private void addDirectoryButton2_Click(object sender, EventArgs e)
        {
            string folderPath = "";

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowser.SelectedPath;
            }

            addDirectoryTextBox2.Text = folderPath;
        }
        private void addDirectoryButton3_Click(object sender, EventArgs e)
        {
            string folderPath = "";

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowser.SelectedPath;
            }

            addDirectoryTextBox3.Text = folderPath;
        }

        /// <summary> startButtonClick()
        /// Starts and processes the entire cloning operation. See in-method comments for further details
        /// on individual operations
        /// </summary>
        private void startButton_Click(object sender, EventArgs e)
        {
            // Get name of profile to be exported
            string exportProfile = userList1.SelectedItem.ToString();
            string importProfile = userList2.SelectedItem.ToString();

            string exportDirectory = driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile; 
            string importDirectory = driveBox2.SelectedItem.ToString() + @"Users\" + importProfile;

            // Get selected libraries
            if (librariesListBox.CheckedIndices.Contains(0))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Documents");
            }
            if (librariesListBox.CheckedIndices.Contains(1))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Music");
            }
            if (librariesListBox.CheckedIndices.Contains(2))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Pictures");
            }
            if (librariesListBox.CheckedIndices.Contains(3))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Videos");
            }
            if (librariesListBox.CheckedIndices.Contains(4))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Desktop");
            }
            if (librariesListBox.CheckedIndices.Contains(5))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Downloads");
            }
            if (librariesListBox.CheckedIndices.Contains(6))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Favorites");
            }
            if (librariesListBox.CheckedIndices.Contains(7))
            {
                sourceList.Add(driveBox1.SelectedItem.ToString() + @"Users\" + exportProfile + @"\Links");
            }

            // Get custom locations, if selected
            if (addDirectoryTextBox1.Text != "")
            {
                sourceList.Add(@addDirectoryTextBox1.Text);
            }
            if (addDirectoryTextBox2.Text != "")
            {
                sourceList.Add(@addDirectoryTextBox2.Text);
            }
            if (addDirectoryTextBox3.Text != "")
            {
                sourceList.Add(@addDirectoryTextBox3.Text);
            }

            progressBar.Maximum = sourceList.Count;

            foreach(string item in sourceList)
            {
                string folderName = Path.GetFileName(item);
                Directory.CreateDirectory(importDirectory + @"\" + folderName);
                DirectoryInfo readDirectory = new DirectoryInfo(exportDirectory + @"\" + folderName);
                DirectoryInfo writeDirectory = new DirectoryInfo(importDirectory + @"\" + folderName);
                CopyFilesRecursively(readDirectory, writeDirectory);
                progressBar.Increment(1);
            }

            MessageBox.Show("Complete.");
        }

        /// <summary> CopyFilesRecursively()
        /// Performs the actual copying of files inside a folder.
        /// Calls itself recursively to copy subdirectories.
        /// </summary>
        public static void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (FileInfo file in source.GetFiles())    // Copy each file in the source directory over to the target directory
                file.CopyTo(Path.Combine(target.FullName, file.Name));
            foreach (DirectoryInfo dir in source.GetDirectories())      // Perform the same copy operation on each subdirectory of the source
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
        }

        private void outlookCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Coming in a future release! Please stay tuned");
        }
    }
}