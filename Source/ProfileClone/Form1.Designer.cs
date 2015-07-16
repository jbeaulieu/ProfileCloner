namespace ProfileClone
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.profilesLabel = new System.Windows.Forms.Label();
            this.userList1 = new System.Windows.Forms.ListBox();
            this.cloneLabel = new System.Windows.Forms.Label();
            this.userList2 = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.librariesLabel = new System.Windows.Forms.Label();
            this.driveBox1 = new System.Windows.Forms.ComboBox();
            this.driveBox2 = new System.Windows.Forms.ComboBox();
            this.librariesListBox = new System.Windows.Forms.CheckedListBox();
            this.outlookCheckBox = new System.Windows.Forms.CheckBox();
            this.additionalDirectoriesLabel = new System.Windows.Forms.Label();
            this.addDirectoryTextBox1 = new System.Windows.Forms.TextBox();
            this.addDirectoryButton1 = new System.Windows.Forms.Button();
            this.addDirectoryButton2 = new System.Windows.Forms.Button();
            this.addDirectoryTextBox2 = new System.Windows.Forms.TextBox();
            this.addDirectoryButton3 = new System.Windows.Forms.Button();
            this.addDirectoryTextBox3 = new System.Windows.Forms.TextBox();
            this.showHiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(50, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Import / Export User Data";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(12, 43);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(46, 20);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(169, 43);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 20);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "to";
            // 
            // profilesLabel
            // 
            this.profilesLabel.AutoSize = true;
            this.profilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilesLabel.Location = new System.Drawing.Point(12, 79);
            this.profilesLabel.Name = "profilesLabel";
            this.profilesLabel.Size = new System.Drawing.Size(132, 20);
            this.profilesLabel.TabIndex = 5;
            this.profilesLabel.Text = "Available Profiles:";
            // 
            // userList1
            // 
            this.userList1.FormattingEnabled = true;
            this.userList1.Location = new System.Drawing.Point(16, 102);
            this.userList1.Name = "userList1";
            this.userList1.Size = new System.Drawing.Size(103, 95);
            this.userList1.TabIndex = 6;
            // 
            // cloneLabel
            // 
            this.cloneLabel.AutoSize = true;
            this.cloneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloneLabel.Location = new System.Drawing.Point(122, 126);
            this.cloneLabel.Name = "cloneLabel";
            this.cloneLabel.Size = new System.Drawing.Size(68, 20);
            this.cloneLabel.TabIndex = 7;
            this.cloneLabel.Text = "Clone to";
            // 
            // userList2
            // 
            this.userList2.FormattingEnabled = true;
            this.userList2.Location = new System.Drawing.Point(194, 102);
            this.userList2.Name = "userList2";
            this.userList2.Size = new System.Drawing.Size(103, 95);
            this.userList2.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(16, 232);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(97, 232);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // librariesLabel
            // 
            this.librariesLabel.AutoSize = true;
            this.librariesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librariesLabel.Location = new System.Drawing.Point(327, 9);
            this.librariesLabel.Name = "librariesLabel";
            this.librariesLabel.Size = new System.Drawing.Size(122, 20);
            this.librariesLabel.TabIndex = 11;
            this.librariesLabel.Text = "Select Libraries:";
            // 
            // driveBox1
            // 
            this.driveBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveBox1.FormattingEnabled = true;
            this.driveBox1.Location = new System.Drawing.Point(64, 45);
            this.driveBox1.Name = "driveBox1";
            this.driveBox1.Size = new System.Drawing.Size(99, 21);
            this.driveBox1.TabIndex = 12;
            this.driveBox1.SelectedIndexChanged += new System.EventHandler(this.driveBox1_SelectedIndexChanged);
            // 
            // driveBox2
            // 
            this.driveBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveBox2.FormattingEnabled = true;
            this.driveBox2.Location = new System.Drawing.Point(198, 45);
            this.driveBox2.Name = "driveBox2";
            this.driveBox2.Size = new System.Drawing.Size(99, 21);
            this.driveBox2.TabIndex = 13;
            this.driveBox2.SelectedIndexChanged += new System.EventHandler(this.driveBox2_SelectedIndexChanged);
            // 
            // librariesListBox
            // 
            this.librariesListBox.CheckOnClick = true;
            this.librariesListBox.FormattingEnabled = true;
            this.librariesListBox.Items.AddRange(new object[] {
            "Documents",
            "Music",
            "Pictures",
            "Videos",
            "Desktop",
            "Downloads",
            "Favorites",
            "Links"});
            this.librariesListBox.Location = new System.Drawing.Point(331, 35);
            this.librariesListBox.MultiColumn = true;
            this.librariesListBox.Name = "librariesListBox";
            this.librariesListBox.Size = new System.Drawing.Size(292, 64);
            this.librariesListBox.TabIndex = 14;
            this.librariesListBox.ThreeDCheckBoxes = true;
            // 
            // outlookCheckBox
            // 
            this.outlookCheckBox.AutoSize = true;
            this.outlookCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outlookCheckBox.Location = new System.Drawing.Point(331, 105);
            this.outlookCheckBox.Name = "outlookCheckBox";
            this.outlookCheckBox.Size = new System.Drawing.Size(298, 20);
            this.outlookCheckBox.TabIndex = 15;
            this.outlookCheckBox.Text = "Dynamically scan for Outlook pst and nk2 files";
            this.outlookCheckBox.UseVisualStyleBackColor = true;
            // 
            // additionalDirectoriesLabel
            // 
            this.additionalDirectoriesLabel.AutoSize = true;
            this.additionalDirectoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalDirectoriesLabel.Location = new System.Drawing.Point(327, 128);
            this.additionalDirectoriesLabel.Name = "additionalDirectoriesLabel";
            this.additionalDirectoriesLabel.Size = new System.Drawing.Size(163, 20);
            this.additionalDirectoriesLabel.TabIndex = 16;
            this.additionalDirectoriesLabel.Text = "Additional Directories:";
            // 
            // addDirectoryTextBox1
            // 
            this.addDirectoryTextBox1.Enabled = false;
            this.addDirectoryTextBox1.Location = new System.Drawing.Point(331, 151);
            this.addDirectoryTextBox1.Name = "addDirectoryTextBox1";
            this.addDirectoryTextBox1.Size = new System.Drawing.Size(261, 20);
            this.addDirectoryTextBox1.TabIndex = 17;
            // 
            // addDirectoryButton1
            // 
            this.addDirectoryButton1.Location = new System.Drawing.Point(598, 148);
            this.addDirectoryButton1.Name = "addDirectoryButton1";
            this.addDirectoryButton1.Size = new System.Drawing.Size(25, 25);
            this.addDirectoryButton1.TabIndex = 18;
            this.addDirectoryButton1.Text = "...";
            this.addDirectoryButton1.UseVisualStyleBackColor = true;
            this.addDirectoryButton1.Click += new System.EventHandler(this.addDirectoryButton1_Click);
            // 
            // addDirectoryButton2
            // 
            this.addDirectoryButton2.Location = new System.Drawing.Point(598, 174);
            this.addDirectoryButton2.Name = "addDirectoryButton2";
            this.addDirectoryButton2.Size = new System.Drawing.Size(25, 25);
            this.addDirectoryButton2.TabIndex = 20;
            this.addDirectoryButton2.Text = "...";
            this.addDirectoryButton2.UseVisualStyleBackColor = true;
            this.addDirectoryButton2.Click += new System.EventHandler(this.addDirectoryButton2_Click);
            // 
            // addDirectoryTextBox2
            // 
            this.addDirectoryTextBox2.Enabled = false;
            this.addDirectoryTextBox2.Location = new System.Drawing.Point(331, 177);
            this.addDirectoryTextBox2.Name = "addDirectoryTextBox2";
            this.addDirectoryTextBox2.Size = new System.Drawing.Size(261, 20);
            this.addDirectoryTextBox2.TabIndex = 19;
            // 
            // addDirectoryButton3
            // 
            this.addDirectoryButton3.Location = new System.Drawing.Point(598, 200);
            this.addDirectoryButton3.Name = "addDirectoryButton3";
            this.addDirectoryButton3.Size = new System.Drawing.Size(25, 25);
            this.addDirectoryButton3.TabIndex = 22;
            this.addDirectoryButton3.Text = "...";
            this.addDirectoryButton3.UseVisualStyleBackColor = true;
            this.addDirectoryButton3.Click += new System.EventHandler(this.addDirectoryButton3_Click);
            // 
            // addDirectoryTextBox3
            // 
            this.addDirectoryTextBox3.Enabled = false;
            this.addDirectoryTextBox3.Location = new System.Drawing.Point(331, 203);
            this.addDirectoryTextBox3.Name = "addDirectoryTextBox3";
            this.addDirectoryTextBox3.Size = new System.Drawing.Size(261, 20);
            this.addDirectoryTextBox3.TabIndex = 21;
            // 
            // showHiddenCheckBox
            // 
            this.showHiddenCheckBox.AutoSize = true;
            this.showHiddenCheckBox.Location = new System.Drawing.Point(98, 203);
            this.showHiddenCheckBox.Name = "showHiddenCheckBox";
            this.showHiddenCheckBox.Size = new System.Drawing.Size(120, 17);
            this.showHiddenCheckBox.TabIndex = 23;
            this.showHiddenCheckBox.Text = "Show Hidden Users";
            this.showHiddenCheckBox.UseVisualStyleBackColor = true;
            this.showHiddenCheckBox.CheckedChanged += new System.EventHandler(this.showHiddenCheckBox_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(178, 232);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(445, 23);
            this.progressBar.TabIndex = 24;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 267);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.showHiddenCheckBox);
            this.Controls.Add(this.addDirectoryButton3);
            this.Controls.Add(this.addDirectoryTextBox3);
            this.Controls.Add(this.addDirectoryButton2);
            this.Controls.Add(this.addDirectoryTextBox2);
            this.Controls.Add(this.addDirectoryButton1);
            this.Controls.Add(this.addDirectoryTextBox1);
            this.Controls.Add(this.additionalDirectoriesLabel);
            this.Controls.Add(this.outlookCheckBox);
            this.Controls.Add(this.librariesListBox);
            this.Controls.Add(this.driveBox2);
            this.Controls.Add(this.driveBox1);
            this.Controls.Add(this.librariesLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.userList2);
            this.Controls.Add(this.cloneLabel);
            this.Controls.Add(this.userList1);
            this.Controls.Add(this.profilesLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Profile Cloner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label profilesLabel;
        private System.Windows.Forms.ListBox userList1;
        private System.Windows.Forms.Label cloneLabel;
        private System.Windows.Forms.ListBox userList2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label librariesLabel;
        private System.Windows.Forms.ComboBox driveBox1;
        private System.Windows.Forms.ComboBox driveBox2;
        private System.Windows.Forms.CheckedListBox librariesListBox;
        private System.Windows.Forms.CheckBox outlookCheckBox;
        private System.Windows.Forms.Label additionalDirectoriesLabel;
        private System.Windows.Forms.TextBox addDirectoryTextBox1;
        private System.Windows.Forms.Button addDirectoryButton1;
        private System.Windows.Forms.Button addDirectoryButton2;
        private System.Windows.Forms.TextBox addDirectoryTextBox2;
        private System.Windows.Forms.Button addDirectoryButton3;
        private System.Windows.Forms.TextBox addDirectoryTextBox3;
        private System.Windows.Forms.CheckBox showHiddenCheckBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

