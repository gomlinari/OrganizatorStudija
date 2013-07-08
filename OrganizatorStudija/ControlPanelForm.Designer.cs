namespace OrganizatorStudija
{
    partial class ControlPanelForm
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
            this.loggedUser = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.coursesTabPage = new System.Windows.Forms.TabPage();
            this.displayLabel = new System.Windows.Forms.Label();
            this.courseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.coursesGroupBox = new System.Windows.Forms.GroupBox();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.coursesTabPage.SuspendLayout();
            this.coursesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loggedUser
            // 
            this.loggedUser.AutoSize = true;
            this.loggedUser.Location = new System.Drawing.Point(20, 620);
            this.loggedUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.loggedUser.Name = "loggedUser";
            this.loggedUser.Size = new System.Drawing.Size(138, 18);
            this.loggedUser.TabIndex = 3;
            this.loggedUser.Text = "Logged in as:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.Color.Blue;
            this.userNameLabel.Location = new System.Drawing.Point(162, 620);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(98, 18);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "user_name";
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(435, 620);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(68, 18);
            this.logoutLinkLabel.TabIndex = 5;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.coursesTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 591);
            this.tabControl1.TabIndex = 6;
            // 
            // coursesTabPage
            // 
            this.coursesTabPage.Controls.Add(this.displayLabel);
            this.coursesTabPage.Controls.Add(this.courseTypeComboBox);
            this.coursesTabPage.Controls.Add(this.coursesGroupBox);
            this.coursesTabPage.Location = new System.Drawing.Point(4, 27);
            this.coursesTabPage.Name = "coursesTabPage";
            this.coursesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.coursesTabPage.Size = new System.Drawing.Size(513, 560);
            this.coursesTabPage.TabIndex = 0;
            this.coursesTabPage.Text = "Courses";
            this.coursesTabPage.UseVisualStyleBackColor = true;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(286, 19);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(88, 18);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.Text = "Display:";
            // 
            // courseTypeComboBox
            // 
            this.courseTypeComboBox.FormattingEnabled = true;
            this.courseTypeComboBox.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.courseTypeComboBox.Location = new System.Drawing.Point(380, 16);
            this.courseTypeComboBox.Name = "courseTypeComboBox";
            this.courseTypeComboBox.Size = new System.Drawing.Size(121, 26);
            this.courseTypeComboBox.TabIndex = 1;
            this.courseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.courseTypeComboBox_SelectedIndexChanged);
            // 
            // coursesGroupBox
            // 
            this.coursesGroupBox.Controls.Add(this.removeCourseButton);
            this.coursesGroupBox.Controls.Add(this.addCourseButton);
            this.coursesGroupBox.Controls.Add(this.coursesListBox);
            this.coursesGroupBox.Location = new System.Drawing.Point(7, 48);
            this.coursesGroupBox.Name = "coursesGroupBox";
            this.coursesGroupBox.Size = new System.Drawing.Size(500, 506);
            this.coursesGroupBox.TabIndex = 0;
            this.coursesGroupBox.TabStop = false;
            this.coursesGroupBox.Text = "Courses:";
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.Location = new System.Drawing.Point(254, 448);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(240, 50);
            this.removeCourseButton.TabIndex = 3;
            this.removeCourseButton.Text = "Remove course";
            this.removeCourseButton.UseVisualStyleBackColor = true;
            this.removeCourseButton.Click += new System.EventHandler(this.removeCourseButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(6, 448);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(240, 50);
            this.addCourseButton.TabIndex = 2;
            this.addCourseButton.Text = "Add course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // coursesListBox
            // 
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 18;
            this.coursesListBox.Location = new System.Drawing.Point(6, 25);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(488, 418);
            this.coursesListBox.TabIndex = 0;
            this.coursesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.coursesListBox_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 665);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loggedUser);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ControlPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanelForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.coursesTabPage.ResumeLayout(false);
            this.coursesTabPage.PerformLayout();
            this.coursesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedUser;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage coursesTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox coursesGroupBox;
        private System.Windows.Forms.Button removeCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.ComboBox courseTypeComboBox;
        private System.Windows.Forms.Label displayLabel;
    }
}