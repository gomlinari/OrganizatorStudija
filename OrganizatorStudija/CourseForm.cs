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
    public partial class CourseForm : Form
    {
        DatabaseManipulationClass dbClass = new DatabaseManipulationClass();
        public String courseName;
        public int loggedUserId;
        public ControlPanelForm appControlPanel = null;

        private course displayedCourse = new course();

        // GET, SET ATTRIBUTES
        public String argCourseName
        { 
            get
            {
                return this.courseName;
            } 
            set
            {
                this.courseName = value;
            }
        }

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

        public ControlPanelForm ControlPanel
        {
            get
            {
                return this.appControlPanel;
            }
            set
            {
                this.appControlPanel = value;
            }
        }

        // CONSTRUCTOR
        public CourseForm()
        {
            InitializeComponent();
        }


        // FUNCTIONS
        private course getCourse()
        {
            course appCourse = new course();
            appCourse = dbClass.getCourseByName(this.Text);
            return appCourse;
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
            this.displayedCourse = this.getCourse();
            this.fillFormData();
        }

        private void fillFormData()
        {
            // Basic data
            this.nameTextBox.Text = this.displayedCourse.name;
            this.ectsTextBox.Text = this.displayedCourse.ects.ToString();
            this.yearTextBox.Text = this.displayedCourse.year.ToString();

            // Status
            // Get current course id from table course
            course appCourse = dbClass.getCourseByName(argCourseName);
            // Find current course in userCourses table to read course status attribute
            userCourses displayedCourseStatus = dbClass.getCourseStatus(this.loggedUserId, appCourse.course_id);
            if (displayedCourseStatus.status.Equals("Active"))
            {
                // Display course status (active)
                this.statusComboBox.SelectedIndex = 0;
            }
            else
            {
                // Display course status (inactive)
                this.statusComboBox.SelectedIndex = 1;
            }
            
            // Staff
            // Get all courseStaff rows
            List<courseStaff> appCourseStaffRows = dbClass.getAllCourseStaffRows(); // NEVALJA tj ne vraca vrijednost izgleda!?!
            foreach (courseStaff element in appCourseStaffRows) // Foreach aquired courseStaff row
            {
                if(element.table_course_id == appCourse.course_id) // Get staff for displayed course
                {
                    staff appStaff = dbClass.getStaffById(element.table_staff_id);
                    // Append title, firstName, lastName to listBox
                    this.staffListBox.Items.Add(appStaff.title + "  " + appStaff.first_name + " " + appStaff.last_name);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update course status
            String argStatus = null;
            argStatus = statusComboBox.SelectedItem.Equals("Active") ?  "Active" : "Inactive";
            dbClass.updateCourseStatus(displayedCourse.course_id, this.loggedUserId, argStatus);
            ControlPanel.refreshUserCoursesList();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            appControlPanel.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddTaskForm appAddTaskForm = new AddTaskForm();
            appAddTaskForm.Text = "Add task for " + this.courseName;
            appAddTaskForm.courseName = this.courseName;
            appAddTaskForm.loggedUserId = this.loggedUserId;
            appAddTaskForm.Show();
        }
    }
}