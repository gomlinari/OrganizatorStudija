namespace OrganizatorStudija
{
    partial class DisplayMessageForm
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
            this.messageGroupBox = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.messageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageGroupBox
            // 
            this.messageGroupBox.Controls.Add(this.messageLabel);
            this.messageGroupBox.Location = new System.Drawing.Point(20, 17);
            this.messageGroupBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.messageGroupBox.Name = "messageGroupBox";
            this.messageGroupBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.messageGroupBox.Size = new System.Drawing.Size(444, 148);
            this.messageGroupBox.TabIndex = 0;
            this.messageGroupBox.TabStop = false;
            this.messageGroupBox.Text = "Message";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(158, 70);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(128, 18);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message Text";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(20, 173);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(444, 42);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DisplayMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 231);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.messageGroupBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DisplayMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info!";
            this.messageGroupBox.ResumeLayout(false);
            this.messageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox messageGroupBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label messageLabel;
    }
}