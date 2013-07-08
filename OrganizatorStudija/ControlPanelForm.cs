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
        public int loggedUserId;

        public int argUserId
        {
            get
            {
                return this.loggedUserId;
            }
            set
            {
                this.loggedUserId = value;
            }
        }

        // Constructor
        public ControlPanelForm(LoginForm argLoginForm, String argFirstName, String argLastName)
        {
            appLoginForm = argLoginForm;
            InitializeComponent();
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
            appAddCourseForm.LoggedUserId = this.loggedUserId;
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
                if (element.table_user_id == this.loggedUserId) // For currently logged user
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
            if (this.coursesListBox.SelectedItem != null)
            {
                String selectedCourse = null;
                course appSelectedCourse = null;
                // Remove selected course
                selectedCourse = this.coursesListBox.SelectedItem.ToString();
                // Get selected index
                appSelectedCourse = dbClass.getCourseByName(selectedCourse);
                user appLoggedUser = dbClass.getUserById(this.loggedUserId);
                dbClass.removeUserCourse(appLoggedUser.user_id, appSelectedCourse.course_id);
                this.refreshUserCoursesList();
            }
            else
            {
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Please select which course to remove!");
                appDisplayMessage.Show();
            }
        }

        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appLoginForm.Focus();
        }

        private void coursesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.coursesListBox.SelectedItem != null)
            {
                String tempCourseName = this.coursesListBox.SelectedItem.ToString();
                int tempUserId = this.loggedUserId;
                CourseForm appCourseForm = new CourseForm();
                appCourseForm.argUserId = tempUserId;
                appCourseForm.argCourseName = tempCourseName;
                appCourseForm.ControlPanel = this;
                appCourseForm.Show();
            }
        }

        private void ControlPanelForm_Activated(object sender, EventArgs e)
        {
            this.refreshUserCoursesList();
            this.refreshUserTasksList();
        }

        public void refreshUserTasksList()
        {
            // Get all tasks
            List<task> userTaskList = dbClass.getAllTasks();
            // Clear taskListBox items
            this.taskListBox.Items.Clear();
            // Iterate through table row's
            foreach (task element in userTaskList)
            {
                if (element.owner == this.loggedUserId) // For currently logged user
                {
                    // Appdend task to listBox
                    this.taskListBox.Items.Add(element.name);
                }
            }
            this.taskTypeComboBox.SelectedIndex = 0;
        }
    }
}