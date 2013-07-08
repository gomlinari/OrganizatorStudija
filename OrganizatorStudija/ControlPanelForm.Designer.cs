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
            this.coursesDisplayLabel = new System.Windows.Forms.Label();
            this.courseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.coursesGroupBox = new System.Windows.Forms.GroupBox();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.taskTabPage = new System.Windows.Forms.TabPage();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.taskDisplayLabel = new System.Windows.Forms.Label();
            this.taskTypeComboBox = new System.Windows.Forms.ComboBox();
            this.taskGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.coursesTabPage.SuspendLayout();
            this.coursesGroupBox.SuspendLayout();
            this.taskTabPage.SuspendLayout();
            this.taskGroupBox.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.taskTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 591);
            this.tabControl1.TabIndex = 6;
            // 
            // coursesTabPage
            // 
            this.coursesTabPage.Controls.Add(this.coursesDisplayLabel);
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
            // coursesDisplayLabel
            // 
            this.coursesDisplayLabel.AutoSize = true;
            this.coursesDisplayLabel.Location = new System.Drawing.Point(286, 19);
            this.coursesDisplayLabel.Name = "coursesDisplayLabel";
            this.coursesDisplayLabel.Size = new System.Drawing.Size(88, 18);
            this.coursesDisplayLabel.TabIndex = 2;
            this.coursesDisplayLabel.Text = "Display:";
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
            // taskTabPage
            // 
            this.taskTabPage.Controls.Add(this.taskDisplayLabel);
            this.taskTabPage.Controls.Add(this.taskTypeComboBox);
            this.taskTabPage.Controls.Add(this.taskGroupBox);
            this.taskTabPage.Location = new System.Drawing.Point(4, 27);
            this.taskTabPage.Name = "taskTabPage";
            this.taskTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.taskTabPage.Size = new System.Drawing.Size(513, 560);
            this.taskTabPage.TabIndex = 1;
            this.taskTabPage.Text = "User tasks";
            this.taskTabPage.UseVisualStyleBackColor = true;
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 18;
            this.taskListBox.Location = new System.Drawing.Point(6, 25);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(488, 472);
            this.taskListBox.TabIndex = 0;
            // 
            // taskDisplayLabel
            // 
            this.taskDisplayLabel.AutoSize = true;
            this.taskDisplayLabel.Location = new System.Drawing.Point(286, 19);
            this.taskDisplayLabel.Name = "taskDisplayLabel";
            this.taskDisplayLabel.Size = new System.Drawing.Size(88, 18);
            this.taskDisplayLabel.TabIndex = 5;
            this.taskDisplayLabel.Text = "Display:";
            // 
            // taskTypeComboBox
            // 
            this.taskTypeComboBox.FormattingEnabled = true;
            this.taskTypeComboBox.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.taskTypeComboBox.Location = new System.Drawing.Point(380, 16);
            this.taskTypeComboBox.Name = "taskTypeComboBox";
            this.taskTypeComboBox.Size = new System.Drawing.Size(121, 26);
            this.taskTypeComboBox.TabIndex = 4;
            // 
            // taskGroupBox
            // 
            this.taskGroupBox.Controls.Add(this.taskListBox);
            this.taskGroupBox.Location = new System.Drawing.Point(7, 48);
            this.taskGroupBox.Name = "taskGroupBox";
            this.taskGroupBox.Size = new System.Drawing.Size(500, 506);
            this.taskGroupBox.TabIndex = 3;
            this.taskGroupBox.TabStop = false;
            this.taskGroupBox.Text = "Tasks:";
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
            this.Activated += new System.EventHandler(this.ControlPanelForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanelForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.coursesTabPage.ResumeLayout(false);
            this.coursesTabPage.PerformLayout();
            this.coursesGroupBox.ResumeLayout(false);
            this.taskTabPage.ResumeLayout(false);
            this.taskTabPage.PerformLayout();
            this.taskGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedUser;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage coursesTabPage;
        private System.Windows.Forms.TabPage taskTabPage;
        private System.Windows.Forms.GroupBox coursesGroupBox;
        private System.Windows.Forms.Button removeCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.ComboBox courseTypeComboBox;
        private System.Windows.Forms.Label coursesDisplayLabel;
        private System.Windows.Forms.Label taskDisplayLabel;
        private System.Windows.Forms.ComboBox taskTypeComboBox;
        private System.Windows.Forms.GroupBox taskGroupBox;
        private System.Windows.Forms.ListBox taskListBox;
    }
}