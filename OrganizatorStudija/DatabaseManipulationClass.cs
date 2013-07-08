using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizatorStudija
{
    class DatabaseManipulationClass
    {
        // Create database instance object
        AppConnectionSettings appDb = new AppConnectionSettings();

        // Constructor
        public DatabaseManipulationClass()
        {
            this.appDb.Database.Connection.Open();
        }
        // Destructor
        ~ DatabaseManipulationClass() 
        {
            this.appDb.Database.Connection.Close();
        }

        public void checkLoginData(String argUserName, String argPassword, LoginForm argLoginForm)
        {
            user appUser = null;
            try
            {
                // Get user with specific user name
                appUser = appDb.users.SingleOrDefault(element => element.user_name == argUserName);
                if (appUser == null) // If table empty
                {
                    DisplayMessageForm appDisplayMessage = new DisplayMessageForm("User not found!");
                    appDisplayMessage.Show();
                }
                else // Table has entries
                {
                    if (appUser.user_name == argUserName && appUser.password == argPassword) // Authentication success
                    {
                        argLoginForm.Hide();
                        ControlPanelForm appControlPanel = new ControlPanelForm(argLoginForm, appUser.first_name, appUser.last_name, appUser.user_id);
                        appControlPanel.Show();
                    }
                    else // Authentication fail
                    {
                        DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Wrong password!");
                        appDisplayMessage.Show();
                    }
                }
            }
            catch
            {
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error finding user data!");
                appDisplayMessage.Show();
            }
        }

        // USER TABLE FUNCTIONS
        public void insertUser(String argUserName, String argPassword, String argFirstName, String argLastName)
        {
            try
            {
                // Success
                // Create user class, prepare user insert data
                user newAppUser = new user();
                newAppUser.user_name = argUserName;
                newAppUser.password = argPassword;
                newAppUser.first_name = argFirstName;
                newAppUser.last_name = argLastName;
                appDb.users.Add(newAppUser);
                appDb.SaveChanges();
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("User succesfully added!");
                appDisplayMessage.Show();
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error creating new user!");
                appDisplayMessage.Show();
            }
        }

        public void removeUser(short argUserId)
        {    
            try
            {
                // Success
                // Create user class, prepare user to delete
                user appUser = this.appDb.users.SingleOrDefault(element => element.user_id == argUserId);
                appDb.users.Remove(appUser);
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("User succesfully removed!");
                appDisplayMessage.Show();
                appDb.SaveChanges();
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error removing user!");
                appDisplayMessage.Show();
            }
        }

        public user getUserById(int argUserId)
        {
            try
            {
                user appUser = appDb.users.SingleOrDefault(element => element.user_id == argUserId);
                return appUser;
            }
            catch
            {
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing database query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        // COURSE TABLE FUNCTIONS
        public List<course> getAllCourses()
        {
            try
            {
                List<course> coursesList = null;
                coursesList = appDb.courses.ToList();
                return coursesList;
            }
            catch
            {
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing database query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        public void insertCourse(String argName, short argEcts, short argYear, String argColour)
        {
            try
            {
                // Success
                // Create staff class, prepare user insert data
                course appCourse = new course();
                appCourse.name = argName;
                appCourse.ects = argEcts;
                appCourse.year = argYear;
                appCourse.colour = argColour;
                appDb.courses.Add(appCourse);
                appDb.SaveChanges();
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Course successfuly added!");
                appDisplayMessage.Show();   
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error creating new course!");
                appDisplayMessage.Show();
            }
        }

        public course getCourseByName(String argCourseName)
        {
            try
            {
                // Success
                course appCourse = appDb.courses.SingleOrDefault(element => element.name == argCourseName);
                return appCourse;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        public course getCourseById(int argCourseId)
        {
            try
            {
                // Success
                course appCourse = appDb.courses.SingleOrDefault(element => element.course_id == argCourseId);
                return appCourse;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        public List<course> getCoursesByYear(int argYear)
        {
            try
            {
                List<course> coursesList = new List<course>();
                coursesList = this.getAllCourses();

                List<course> returnCoursesList = new List<course>();
                foreach (course element in coursesList)
                {
                    // N-th year courses (N = argYear)
                    if (element.year == argYear)
                    {
                        returnCoursesList.Add(element);
                    }
                }
                return returnCoursesList;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        // STAFF TABLE FUNCTIONS
        public void insertStaffMember(String argTitle, String argFirstName, String argLastName)
        {
            try
            {
                // Success
                // Create staff class, prepare user insert data
                staff appStaff = new staff();
                appStaff.title = argTitle;
                appStaff.first_name = argFirstName;
                appStaff.last_name = argLastName;
                appDb.staff.Add(appStaff);
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Staff member succesfully added!");
                appDisplayMessage.Show();
                appDb.SaveChanges();
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error creating new staff member!");
                appDisplayMessage.Show();
            }
        }

        public staff getStaffById(int argStaffId)
        {
            try
            {
                // Success
                staff returnData = new staff();
                returnData = appDb.staff.SingleOrDefault(element => element.staff_id == argStaffId);
                return returnData;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        // USERCOURSE TABLE FUNCTIONS
        public List<userCourses> getAllUserCourses()
        {
            try
            {
                List<userCourses> coursesList = new List<userCourses>();
                coursesList = appDb.userCourses.ToList();
                return coursesList;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
            
        }

        public userCourses getCourseStatus(int argUserId, int argCourseId)
        {
            try
            {
                userCourses returnData = appDb.userCourses.Find(argUserId, argCourseId);
                return returnData;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        public List<userCourses> getActiveUserCourses()
        {
            try
            {
                List<userCourses> appUserCoursesList = new List<userCourses>();
                appUserCoursesList = this.getAllUserCourses();
                List<userCourses> activeCoursesList = new List<userCourses>();
                foreach (userCourses element in appUserCoursesList)
                {
                    // Active courses
                    if (element.status.Equals("Active"))
                    {
                        activeCoursesList.Add(element);
                    }
                }
                return activeCoursesList;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        public List<userCourses> getInactiveUserCourses()
        {
            try
            {
                List<userCourses> appUserCoursesList = new List<userCourses>();
                appUserCoursesList = this.getAllUserCourses();
                List<userCourses> inactiveCoursesList = new List<userCourses>();
                foreach (userCourses element in appUserCoursesList)
                {
                    // Inactive courses
                    if (element.status.Equals("Inactive"))
                    {
                        inactiveCoursesList.Add(element);
                    }
                }
                return inactiveCoursesList;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error executing query!");
                appDisplayMessage.Show();
                return null;
            }
        }

        public void insertUserCourse(int argUserId, int argCourseId, String argStatus)
        {
            try
            {
                // Success
                userCourses appUserCourses = new userCourses();
                appUserCourses.table_user_id = argUserId;
                appUserCourses.table_course_id = argCourseId;
                appUserCourses.status = argStatus;
                appDb.userCourses.Add(appUserCourses);
                appDb.SaveChanges();
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Course successfully added!");
                appDisplayMessage.Show();
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error adding course!");
                appDisplayMessage.Show();
            }
        }

        public void updateCourseStatus(int argCourseId, int argUserId, String argCourseStatus)
        {
            try
            {
                userCourses appUserCourse = new userCourses();
                appUserCourse = appDb.userCourses.Find(argUserId, argCourseId);
                userCourses updatedUserCourse = appUserCourse;
                updatedUserCourse.status = argCourseStatus;
                appDb.Entry(appUserCourse).CurrentValues.SetValues(updatedUserCourse);
                appDb.SaveChanges();
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Course updated!");
                appDisplayMessage.Show();
                appDisplayMessage.Focus();

            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error updating course status!");
                appDisplayMessage.Show();
            }
        }

        public void removeUserCourse(int argUserId, int argCourseId)
        {
            try
            {
                // Success
                // Create userCourse class, prepare row to delete
                userCourses appUserCourse = appDb.userCourses.Find(argUserId, argCourseId);
                appDb.userCourses.Remove(appUserCourse);
                appDb.SaveChanges();
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Course succesfully removed!");
                appDisplayMessage.Show();

            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error removing course!");
                appDisplayMessage.Show();
            }
        }

        // COURSE STAFF TABLE FUNCTIONS
        public List<courseStaff> getAllCourseStaffRows()
        {
            try
            {
                List<courseStaff> returnData = new List<courseStaff>();
                returnData = appDb.courseStaff.ToList();
                return returnData;
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error creating new staff member!");
                appDisplayMessage.Show();
                return null;
            }
        }

        public void insertCourseStaff(int argCourseId, int argStaffId)
        {
            try
            {
                // Success
                courseStaff appCourseStaff = new courseStaff();
                appCourseStaff.table_course_id = argCourseId;
                appCourseStaff.table_staff_id = argStaffId;
                appDb.courseStaff.Add(appCourseStaff);
                appDb.SaveChanges();
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error adding staff!");
                appDisplayMessage.Show();
            }
        }

        // TASK TABLE FUNCTIONS
        public void insertTask(String argName, String argDescription, short argPoints, short argMaxPoints, String argStart, String argEnd, String argStatus, int argOwner, int argCourse)
        {
            try
            {
                // Success
                task appTask = new task();
                appTask.name = argName;
                appTask.description = argDescription;
                appTask.points = argPoints;
                appTask.points_max = argMaxPoints;
                appTask.start_date = argStart;
                appTask.end_date = argEnd;
                appTask.status = argStatus;
                appTask.owner = argOwner;
                appTask.course = argCourse;
                appDb.tasks.Add(appTask);
                appDb.SaveChanges();
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Task succesfully added!");
                appDisplayMessage.Show();
            }
            catch
            {
                // Fail
                DisplayMessageForm appDisplayMessage = new DisplayMessageForm("Error adding task!");
                appDisplayMessage.Show();
            }
        }

        public void insertTestData()
        {
            // Insert test user
            this.insertUser("tovrbosic","111111","Tomislav","Vrbošić");
            this.insertUser("malackovi", "111111", "Marija", "Lacković");
            this.insertUser("bojuranek", "111111", "Bojan", "Juranek");
            this.insertUser("horejas", "111111", "Hrvoje", "Orejaš");
            this.insertUser("gomlinari", "111111", "Goran", "Mlinarić");
            // Insert test staff
            this.insertStaffMember("Prof.dr.sc", "Alen", "Lovrenčić");
            this.insertStaffMember("Prof.dr.sc", "Vjeran", "Strahonja");
            this.insertStaffMember("Prof.dr.sc", "Dragutin", "Kermek");
            this.insertStaffMember("mag. inf.", "Marko", "Mijač");
            this.insertStaffMember("mag. inf", "Zlatko", "Stapić");
            this.insertStaffMember("mag. inf.", "Ivan", "Švogor");
            this.insertStaffMember("mag. inf.", "Boris", "Tomaš");
            // Insert test course
            this.insertCourse("Algorithms", 6, 2,"red");
            this.insertCourse("Software engineering", 7, 3, "blue");
            this.insertCourse("Web design and programming", 7, 3, "green");
            // Insert courseStaff (courseId,staffId)
            this.insertCourseStaff(1, 1);
            this.insertCourseStaff(2, 2);
            this.insertCourseStaff(3, 3);
            this.insertCourseStaff(2, 4);
            this.insertCourseStaff(2, 5);
            this.insertCourseStaff(2, 6);
            this.insertCourseStaff(2, 7);
            
        }
    }
}