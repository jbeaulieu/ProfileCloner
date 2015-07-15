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
        List<string> sourceList = new List<string>();

        System.IO.DriveInfo[] driveArray = System.IO.DriveInfo.GetDrives();

        public mainForm()
        {
            InitializeComponent();

            for (int i = 0; i < driveArray.Length; i++)
            {
                driveBox1.Items.Add(driveArray[i]);
                driveBox2.Items.Add(driveArray[i]);
            }
            
            driveBox1.SelectedIndex = 0;
            driveBox2.SelectedIndex = 1;

            drive1Refresh();
            drive2Refresh();
        }

        private void driveBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            drive1Refresh();
        }

        private void driveBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            drive2Refresh();
        }

        private void showHiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drive1Refresh();
            drive2Refresh();
        }

        public void drive1Refresh()
        {
            userList1.Items.Clear();

            if (driveArray[driveBox1.SelectedIndex].IsReady)
            {
                try
                {
                    string path = driveBox1.SelectedItem.ToString() + "Users\\";

                    if (showHiddenCheckBox.Checked)
                    {
                        foreach (string userDirectory in System.IO.Directory.GetDirectories(path))
                        {
                            string user = userDirectory.Substring(9);
                            userList1.Items.Add(user);
                        }
                    }
                    else
                    {
                        foreach (string userFolder in System.IO.Directory.GetDirectories(path))
                        {
                            string folder = Path.Combine(path, userFolder);
                            DirectoryInfo folderInfo = new DirectoryInfo(folder);

                            if ((folderInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                            {
                                string user = userFolder.Substring(9);
                                userList1.Items.Add(user);
                            }
                        }
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Warning: ProfileCloner was unable to detect a Windows directory on the selected volume.",
                        "Caught DirectoryNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("Would you like to specify a custom directory to read files from?",
                        //"DirectoryNotFoundException", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
            }
        }

        public void drive2Refresh()
        {
            userList2.Items.Clear();

            if (driveArray[driveBox2.SelectedIndex].IsReady)
            {
                try
                {
                    string path = driveBox2.SelectedItem.ToString() + "Users\\";

                    if (showHiddenCheckBox.Checked)
                    {
                        foreach (string userDirectory in System.IO.Directory.GetDirectories(path))
                        {
                            string user = userDirectory.Substring(9);
                            userList2.Items.Add(user);
                        }
                    }
                    else
                    {
                        foreach (string userFolder in System.IO.Directory.GetDirectories(path))
                        {
                            string folder = Path.Combine(path, userFolder);
                            DirectoryInfo folderInfo = new DirectoryInfo(folder);

                            if ((folderInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                            {
                                string user = userFolder.Substring(9);
                                userList2.Items.Add(user);
                            }
                        }
                    }
                }
                catch(DirectoryNotFoundException e)
                {
                    MessageBox.Show("Warning: ProfileCloner was unable to detect a Windows directory on the selected volume.",
                        "Caught DirectoryNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("Would you like to specify a custom directory to export the files to?",
                        //"DirectoryNotFoundException", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            driveBox1.SelectedIndex = 0;
            driveBox2.SelectedIndex = 1;

            drive1Refresh();
            drive2Refresh();

            showHiddenCheckBox.Checked = false;

            librariesListBox.ClearSelected();

            foreach(int index in librariesListBox.CheckedIndices)
            {
                librariesListBox.SetItemCheckState(index, CheckState.Unchecked);
            }

            outlookCheckBox.Checked = false;

            addDirectoryTextBox1.Clear();
            addDirectoryTextBox2.Clear();
            addDirectoryTextBox3.Clear();
        }

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

            foreach(string item in sourceList)
            {
                string folderName = Path.GetFileName(item);
                Directory.CreateDirectory(importDirectory + @"\" + folderName);
                directoryCopy(item, importDirectory + @"\" + folderName, true);

            }

            //addDirectoryTextBox1.Text = exportDirectory;
            //addDirectoryTextBox2.Text = sourceList[0];
            //addDirectoryTextBox3.Text = Path.GetFileName(sourceList[0]);

            //directoryCopy(sourceList[0], importDirectory, true);

            //System.IO.File.Copy()

            MessageBox.Show("Done!");

            //directoryCopy(sourceList[0], )

            /*Select C:\ as the default location if no backup drive has been chosen
            if (driveList.SelectedItem == null)
            {
                MessageBox.Show("No destination drive selected -- C:\\ will be selected until changed");
                driveList.SelectedText = "C:\\";
            }*/

            //string destPath = driveList.SelectedItem.ToString() + @"backupTest";

            /*foreach (string sourcePath in sourceList)
            {
                directoryCopy(sourcePath, destPath, true);
                progressBar.Increment(100 / sourceList.ToArray().Length);
                locationBox1.Text = sourcePath;
            }*/
        }

        public void directoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    directoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        public void copy(string sourceDirectory, string destinationDirectory)
        {
            if (System.IO.Directory.Exists(sourceDirectory))
            {
                string[] files = System.IO.Directory.GetFiles(sourceDirectory);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(destinationDirectory, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                //Console.WriteLine("Source path does not exist!");
                //locationBox3.Text = "Could not find source path!";
            }
        }
    }
}