namespace OrganizatorStudija
{
    partial class AddTaskForm
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
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.cancleButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.registrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.statusLabel);
            this.registrationGroupBox.Controls.Add(this.endDateLabel);
            this.registrationGroupBox.Controls.Add(this.startDateLabel);
            this.registrationGroupBox.Controls.Add(this.endDateTimePicker);
            this.registrationGroupBox.Controls.Add(this.startDateTimePicker);
            this.registrationGroupBox.Controls.Add(this.descriptionTextBox);
            this.registrationGroupBox.Controls.Add(this.descriptionLabel);
            this.registrationGroupBox.Controls.Add(this.statusComboBox);
            this.registrationGroupBox.Controls.Add(this.pointsTextBox);
            this.registrationGroupBox.Controls.Add(this.pointsLabel);
            this.registrationGroupBox.Controls.Add(this.nameTextBox);
            this.registrationGroupBox.Controls.Add(this.taskNameLabel);
            this.registrationGroupBox.Location = new System.Drawing.Point(13, 13);
            this.registrationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.registrationGroupBox.Size = new System.Drawing.Size(410, 303);
            this.registrationGroupBox.TabIndex = 15;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Task information";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(8, 133);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 18);
            this.statusLabel.TabIndex = 30;
            this.statusLabel.Text = "Status:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(8, 104);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(48, 18);
            this.endDateLabel.TabIndex = 29;
            this.endDateLabel.Text = "End:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(8, 72);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(68, 18);
            this.startDateLabel.TabIndex = 28;
            this.startDateLabel.Text = "Start:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Location = new System.Drawing.Point(138, 102);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(265, 20);
            this.endDateTimePicker.TabIndex = 27;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Location = new System.Drawing.Point(138, 70);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(265, 20);
            this.startDateTimePicker.TabIndex = 23;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(8, 221);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(391, 70);
            this.descriptionTextBox.TabIndex = 22;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 199);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(128, 18);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "Description:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusComboBox.Location = new System.Drawing.Point(137, 130);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(265, 26);
            this.statusComboBox.TabIndex = 20;
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsTextBox.Location = new System.Drawing.Point(301, 166);
            this.pointsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(96, 20);
            this.pointsTextBox.TabIndex = 14;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(5, 166);
            this.pointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(288, 18);
            this.pointsLabel.TabIndex = 13;
            this.pointsLabel.Text = "Points achieved / possible :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(137, 33);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(265, 26);
            this.nameTextBox.TabIndex = 10;
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(8, 36);
            this.taskNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(108, 18);
            this.taskNameLabel.TabIndex = 9;
            this.taskNameLabel.Text = "Task name:";
            // 
            // cancleButton
            // 
            this.cancleButton.Location = new System.Drawing.Point(220, 324);
            this.cancleButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(203, 50);
            this.cancleButton.TabIndex = 17;
            this.cancleButton.Text = "Cancle";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 324);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(203, 50);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add task";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 385);
            this.Controls.Add(this.registrationGroupBox);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task to CourseName";
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
    }
}