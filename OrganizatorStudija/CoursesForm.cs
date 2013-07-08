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
    // Singletone class
    public partial class CoursesForm : Form
    {
        DatabaseManipulationClass dbClass = new DatabaseManipulationClass();
        private int loggedUserId;
        private ControlPanelForm appControlPanelForm = null;
        private List<course> coursesList = null;
        private static CoursesForm formInstance = null;

        // Avoid deadlock's in multhithreading environment
        static readonly object threadLock = new object();

        // Private constructor
        private CoursesForm()
        {
            InitializeComponent();
            this.fillCourseList();
            this.courseTypeComboBox.SelectedIndex = 0;
        }

        public int LoggedUserId
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

        public ControlPanelForm ControlPanel
        {
            get
            {
                return this.appControlPanelForm;
            }
            set
            {
                this.appControlPanelForm = value;
            }
        }

        public static CoursesForm Instance
        {
            get
            {
                lock (threadLock)
                {
                    if (formInstance == null)
                    {
                        // Call constructor
                        formInstance = new CoursesForm();
                        return formInstance;
                    }
                    else
                    {
                        formInstance.Focus();
                        return formInstance;
                    }
                }
            }
        }        

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ControlPanel.Focus();
        }

        private void fillCourseList()
        {
            coursesList = dbClass.getAllCourses();
            foreach( course element in coursesList)
            {
                this.coursesListBox.Items.Add(element.name);
            }
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            String courseName = null;
            course userCourse = null;
            // Add course for logged user
            courseName = this.coursesListBox.SelectedItem.ToString();
            userCourse = dbClass.getCourseByName(courseName);
            dbClass.insertUserCourse(this.LoggedUserId, userCourse.course_id, "Active");
            // Refresh user courses list
            this.ControlPanel.refreshUserCoursesList();
        }

        private void courseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear list
            this.coursesListBox.Items.Clear();
            switch (this.courseTypeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        this.refreshCoursesList();
                        break;
                    }
                case 1:
                    {
                        // Get 1st year courses
                        List<course> coursesList = dbClass.getCoursesByYear(1);
                        foreach (course element in coursesList)
                        {
                            this.coursesListBox.Items.Add(element.name);
                        }
                        break;
                    }
                case 2:
                    {
                        // Get 2nd year courses
                        List<course> coursesList = dbClass.getCoursesByYear(2);
                        foreach (course element in coursesList)
                        {
                            this.coursesListBox.Items.Add(element.name);
                        }
                        break;
                    }
                case 3:
                    {
                        // Get 3rd year courses
                        List<course> coursesList = dbClass.getCoursesByYear(3);
                        foreach (course element in coursesList)
                        {
                            this.coursesListBox.Items.Add(element.name);
                        }
                        break;
                    }
                case 4:
                    {
                        // Get 4th year courses
                        List<course> coursesList = dbClass.getCoursesByYear(4);
                        foreach (course element in coursesList)
                        {
                            this.coursesListBox.Items.Add(element.name);
                        }
                        break;
                    }
                case 5:
                    {
                        // Get 5th year courses
                        List<course> coursesList = dbClass.getCoursesByYear(5);
                        foreach (course element in coursesList)
                        {
                            this.coursesListBox.Items.Add(element.name);
                        }
                        break;
                    };
            }
        }

        public void refreshCoursesList()
        {
            // Get all courses
            List<course> coursesList = dbClass.getAllCourses();
            // Clear courseListBox items
            this.coursesListBox.Items.Clear();
            // Append all courses to list
            foreach (course element in coursesList)
            {
                this.coursesListBox.Items.Add(element.name);
            }
        }
    }
}