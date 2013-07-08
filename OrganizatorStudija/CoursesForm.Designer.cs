namespace OrganizatorStudija
{
    partial class CoursesForm
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
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.courseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.coursesGroupBox = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.coursesGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coursesListBox
            // 
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 18;
            this.coursesListBox.Location = new System.Drawing.Point(9, 25);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(423, 400);
            this.coursesListBox.TabIndex = 0;
            // 
            // courseTypeComboBox
            // 
            this.courseTypeComboBox.FormattingEnabled = true;
            this.courseTypeComboBox.Items.AddRange(new object[] {
            "All",
            "1st year",
            "2nd year",
            "3rd year",
            "4th year",
            "5th year"});
            this.courseTypeComboBox.Location = new System.Drawing.Point(100, 19);
            this.courseTypeComboBox.Name = "courseTypeComboBox";
            this.courseTypeComboBox.Size = new System.Drawing.Size(121, 26);
            this.courseTypeComboBox.TabIndex = 4;
            this.courseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.courseTypeComboBox_SelectedIndexChanged);
            // 
            // coursesGroupBox
            // 
            this.coursesGroupBox.Controls.Add(this.coursesListBox);
            this.coursesGroupBox.Location = new System.Drawing.Point(12, 66);
            this.coursesGroupBox.Name = "coursesGroupBox";
            this.coursesGroupBox.Size = new System.Drawing.Size(438, 435);
            this.coursesGroupBox.TabIndex = 3;
            this.coursesGroupBox.TabStop = false;
            this.coursesGroupBox.Text = "Courses:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(232, 507);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(218, 50);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(12, 507);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(218, 50);
            this.addCourseButton.TabIndex = 6;
            this.addCourseButton.Text = "Add course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 9;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.displayLabel);
            this.filterGroupBox.Controls.Add(this.textBox1);
            this.filterGroupBox.Controls.Add(this.courseTypeComboBox);
            this.filterGroupBox.Controls.Add(this.label1);
            this.filterGroupBox.Location = new System.Drawing.Point(12, 7);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(438, 58);
            this.filterGroupBox.TabIndex = 10;
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
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 563);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.coursesGroupBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add course";
            this.coursesGroupBox.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.ComboBox courseTypeComboBox;
        private System.Windows.Forms.GroupBox coursesGroupBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label displayLabel;
    }
}