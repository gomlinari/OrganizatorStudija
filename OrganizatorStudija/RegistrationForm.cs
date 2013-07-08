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
    public partial class RegistrationForm : Form
    {
        LoginForm appLoginForm = null;

        public RegistrationForm(LoginForm argLoginForm)
        {
            appLoginForm = argLoginForm;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Close registration, return to login
            this.Close();
            appLoginForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DatabaseManipulationClass dbClass = new DatabaseManipulationClass();
            dbClass.insertUser(userNameTextBox.Text, passwordTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
            this.Close();
            appLoginForm.Show();
        }
    }
}
