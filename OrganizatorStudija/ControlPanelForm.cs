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
    public partial class ControlPanelForm : Form
    {
        DatabaseManipulationClass dbClass = new DatabaseManipulationClass();
        LoginForm appLoginForm = null;
        private int LoggedUserId;
        public ControlPanelForm(LoginForm argLoginForm, String argFirstName, String argLastName, int argUserId)
        {
            appLoginForm = argLoginForm;
            LoggedUserId = argUserId;
            InitializeComponent();
            this.refreshUserCoursesList();
            this.userNameLabel.Text = argFirstName + " " + argLastName;
            this.courseTypeComboBox.SelectedIndex = 0;
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.appLoginForm.clearTextBoxes();
            appLoginForm.Show();
            this.Close();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            CoursesForm appAddCourseForm = CoursesForm.Instance;
            appAddCourseForm.LoggedUserId = this.LoggedUserId;
            appAddCourseForm.ControlPanel = this;
            appAddCourseForm.Show();
        }

        public void refreshUserCoursesList()
        {
            // Get all userCourses
            List<userCourses> userCoursesList = dbClass.getAllUserCourses();
            course appCourseToAppend = null;
            // Clear courseListBox items
            this.coursesListBox.Items.Clear();
            // Iterate through table row's
            foreach (userCourses element in userCoursesList)
            {
                if (element.table_user_id == this.LoggedUserId) // For currently logged user
                {
                    // Get course by id
                    appCourseToAppend = dbClass.getCourseById(element.table_course_id);
                    // Appdend course to table
                    this.coursesListBox.Items.Add(appCourseToAppend.name);
                }
            }
            this.courseTypeComboBox.SelectedIndex = 0;
        }

        private void courseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear list
            this.coursesListBox.Items.Clear();
            course appCourseToAppend = null;
            switch(this.courseTypeComboBox.SelectedIndex)
            {
                case 0:
                {
                    this.refreshUserCoursesList();
                    break;
                }
                case 1:
                {
                    // Get active courses
                    List<userCourses> activeUserCourses = dbClass.getActiveUserCourses();
                    foreach (userCourses element in activeUserCourses)
                    {
                        appCourseToAppend = dbClass.getCourseById(element.table_course_id);
                        this.coursesListBox.Items.Add(appCourseToAppend.name);
                    }
                    break;
                }
                case 2:
                {
                    // Get inactive courses
                    List<userCourses> inactiveUserCourses = dbClass.getInactiveUserCourses();
                    foreach (userCourses element in inactiveUserCourses)
                    {
                        appCourseToAppend = dbClass.getCourseById(element.table_course_id);
                        this.coursesListBox.Items.Add(appCourseToAppend.name);
                    }
                    break;
                }
            }
        }

        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            // Remove selected course
            String selectedCourse = this.coursesListBox.SelectedItem.ToString();
            // Get selected index
            course appSelectedCourse = dbClass.getCourseByName(selectedCourse);
            user appLoggedUser = dbClass.getUserById(this.LoggedUserId);
            dbClass.removeUserCourse(appLoggedUser.user_id, appSelectedCourse.course_id);
            this.refreshUserCoursesList();
        }

        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appLoginForm.Focus();
        }

        private void coursesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.coursesListBox.SelectedItem != null)
            {
                CourseForm appCourseForm = new CourseForm();
                appCourseForm.Text = this.coursesListBox.SelectedItem.ToString();
                appCourseForm.argCourseName = this.coursesListBox.SelectedItem.ToString();
                appCourseForm.argUserId = this.LoggedUserId;
                appCourseForm.ControlPanel = this;
                appCourseForm.Show();
            }
        }
    }
}