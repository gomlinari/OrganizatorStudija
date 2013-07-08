namespace OrganizatorStudija
{
    partial class CourseForm
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
            this.courseTabControl = new System.Windows.Forms.TabControl();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.courseInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.staffLabel = new System.Windows.Forms.Label();
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.ectsTextBox = new System.Windows.Forms.TextBox();
            this.ectsLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tasksTabPage = new System.Windows.Forms.TabPage();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.taskTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.courseTabControl.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            this.courseInfoGroupBox.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseTabControl
            // 
            this.courseTabControl.Controls.Add(this.infoTabPage);
            this.courseTabControl.Controls.Add(this.tasksTabPage);
            this.courseTabControl.Location = new System.Drawing.Point(12, 12);
            this.courseTabControl.Name = "courseTabControl";
            this.courseTabControl.SelectedIndex = 0;
            this.courseTabControl.Size = new System.Drawing.Size(446, 488);
            this.courseTabControl.TabIndex = 0;
            // 
            // infoTabPage
            // 
            this.infoTabPage.Controls.Add(this.courseInfoGroupBox);
            this.infoTabPage.Location = new System.Drawing.Point(4, 27);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoTabPage.Size = new System.Drawing.Size(438, 457);
            this.infoTabPage.TabIndex = 0;
            this.infoTabPage.Text = "Details";
            this.infoTabPage.UseVisualStyleBackColor = true;
            // 
            // courseInfoGroupBox
            // 
            this.courseInfoGroupBox.Controls.Add(this.statusComboBox);
            this.courseInfoGroupBox.Controls.Add(this.statusLabel);
            this.courseInfoGroupBox.Controls.Add(this.staffLabel);
            this.courseInfoGroupBox.Controls.Add(this.staffListBox);
            this.courseInfoGroupBox.Controls.Add(this.yearLabel);
            this.courseInfoGroupBox.Controls.Add(this.yearTextBox);
            this.courseInfoGroupBox.Controls.Add(this.ectsTextBox);
            this.courseInfoGroupBox.Controls.Add(this.ectsLabel);
            this.courseInfoGroupBox.Controls.Add(this.nameTextBox);
            this.courseInfoGroupBox.Controls.Add(this.nameLabel);
            this.courseInfoGroupBox.Location = new System.Drawing.Point(6, 6);
            this.courseInfoGroupBox.Name = "courseInfoGroupBox";
            this.courseInfoGroupBox.Size = new System.Drawing.Size(426, 237);
            this.courseInfoGroupBox.TabIndex = 1;
            this.courseInfoGroupBox.TabStop = false;
            this.courseInfoGroupBox.Text = "Course information";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusComboBox.Location = new System.Drawing.Point(188, 118);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(232, 26);
            this.statusComboBox.TabIndex = 11;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 118);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 18);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Status:";
            // 
            // staffLabel
            // 
            this.staffLabel.AutoSize = true;
            this.staffLabel.Location = new System.Drawing.Point(6, 147);
            this.staffLabel.Name = "staffLabel";
            this.staffLabel.Size = new System.Drawing.Size(68, 18);
            this.staffLabel.TabIndex = 8;
            this.staffLabel.Text = "Staff:";
            // 
            // staffListBox
            // 
            this.staffListBox.Font = new System.Drawing.Font("Courier New", 10F);
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.ItemHeight = 16;
            this.staffListBox.Location = new System.Drawing.Point(188, 147);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(232, 84);
            this.staffListBox.TabIndex = 7;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(6, 86);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(128, 18);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Course year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(188, 83);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(232, 26);
            this.yearTextBox.TabIndex = 5;
            // 
            // ectsTextBox
            // 
            this.ectsTextBox.Location = new System.Drawing.Point(188, 51);
            this.ectsTextBox.Name = "ectsTextBox";
            this.ectsTextBox.ReadOnly = true;
            this.ectsTextBox.Size = new System.Drawing.Size(232, 26);
            this.ectsTextBox.TabIndex = 4;
            // 
            // ectsLabel
            // 
            this.ectsLabel.AutoSize = true;
            this.ectsLabel.Location = new System.Drawing.Point(6, 54);
            this.ectsLabel.Name = "ectsLabel";
            this.ectsLabel.Size = new System.Drawing.Size(178, 18);
            this.ectsLabel.TabIndex = 1;
            this.ectsLabel.Text = "ECTS point value:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(188, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(232, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 18);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.filterGroupBox);
            this.tasksTabPage.Controls.Add(this.removeButton);
            this.tasksTabPage.Controls.Add(this.addButton);
            this.tasksTabPage.Controls.Add(this.taskListBox);
            this.tasksTabPage.Location = new System.Drawing.Point(4, 27);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tasksTabPage.Size = new System.Drawing.Size(438, 457);
            this.tasksTabPage.TabIndex = 1;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.UseVisualStyleBackColor = true;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.displayLabel);
            this.filterGroupBox.Controls.Add(this.searchTextBox);
            this.filterGroupBox.Controls.Add(this.taskTypeComboBox);
            this.filterGroupBox.Controls.Add(this.searchLabel);
            this.filterGroupBox.Location = new System.Drawing.Point(6, 6);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(426, 58);
            this.filterGroupBox.TabIndex = 11;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filters";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(6, 22);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(88, 18);
            this.displayLabel.TabIndex = 6;
            this.displayLabel.Text = "Display:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(287, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(132, 26);
            this.searchTextBox.TabIndex = 9;
            // 
            // taskTypeComboBox
            // 
            this.taskTypeComboBox.FormattingEnabled = true;
            this.taskTypeComboBox.Items.AddRange(new object[] {
            "All",
            "1st year",
            "2nd year",
            "3rd year",
            "4th year",
            "5th year"});
            this.taskTypeComboBox.Location = new System.Drawing.Point(100, 19);
            this.taskTypeComboBox.Name = "taskTypeComboBox";
            this.taskTypeComboBox.Size = new System.Drawing.Size(103, 26);
            this.taskTypeComboBox.TabIndex = 4;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(209, 22);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(78, 18);
            this.searchLabel.TabIndex = 8;
            this.searchLabel.Text = "Search:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(222, 70);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(210, 40);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove task";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 70);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(210, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add task";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 18;
            this.taskListBox.Location = new System.Drawing.Point(6, 124);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(426, 328);
            this.taskListBox.TabIndex = 0;
            this.taskListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskListBox_MouseDoubleClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(238, 506);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(220, 50);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 506);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(220, 50);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 568);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.courseTabControl);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.Activated += new System.EventHandler(this.CourseForm_Activated);
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.courseTabControl.ResumeLayout(false);
            this.infoTabPage.ResumeLayout(false);
            this.courseInfoGroupBox.ResumeLayout(false);
            this.courseInfoGroupBox.PerformLayout();
            this.tasksTabPage.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl courseTabControl;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.GroupBox courseInfoGroupBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label staffLabel;
        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox ectsTextBox;
        private System.Windows.Forms.Label ectsLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabPage tasksTabPage;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox taskTypeComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button saveButton;

    }
}