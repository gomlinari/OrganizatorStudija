using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizatorStudija
{
    public partial class DisplayMessageForm : Form
    {
        private String message = "";

        public DisplayMessageForm(String argMessage)
        {
            this.message = argMessage.ToString();
            InitializeComponent();
            this.messageLabel.Text = message;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
