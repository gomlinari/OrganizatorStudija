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
    public partial class AddTaskForm : Form
    {
        DatabaseManipulationClass dbClass = new DatabaseManipulationClass();
        public String courseName;
        public int loggedUserId;
        public CourseForm appCourseForm = null;

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

        // Constructor
        public AddTaskForm()
        {
            InitializeComponent();
            this.statusComboBox.SelectedIndex = 0;
            this.nameTextBox.Text = "Task name";
            this.pointsTextBox.Text = "A/M";
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.appCourseForm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get required data
            course argCourse = dbClass.getCourseByName(courseName);
            String[] points = this.pointsTextBox.Text.Split('/');
            // Get start and end date
            String argStartDate = startDateTimePicker.Value.ToString("MM/dd/yyyy");
            String argEndDate = endDateTimePicker.Value.ToString("MM/dd/yyyy");
            String argStatus = statusComboBox.SelectedItem.ToString();
            short argPoints = Convert.ToInt16(points[0]);
            short argMaxPoints = Convert.ToInt16(points[1]);
            // Call insert function from DatabaseManipulationClass
            dbClass.insertTask(nameTextBox.Text, descriptionTextBox.Text, argPoints, argMaxPoints, argStartDate, argEndDate, argStatus, loggedUserId, argCourse.course_id);
            this.appCourseForm.refreshTaskList();
        }
    }
}
