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
    public partial class LoginForm : Form
    {

        DatabaseManipulationClass dbClass = new DatabaseManipulationClass();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            dbClass.checkLoginData(userNameTextBox.Text, passwordTextBox.Text, this);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Open registration form
            RegistrationForm appRegistrationForm = new RegistrationForm(this);
            this.Hide();
            appRegistrationForm.Show();
        }

        public void clearTextBoxes()
        {
            this.userNameTextBox.Text = "";
            this.passwordTextBox.Text = "";
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            // Fill database with hardcoded data - for testing purpose
            dbClass.insertTestData();
        }
    }
}
