//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrganizatorStudija
{
    using System;
    using System.Collections.Generic;
    
    public partial class userCourses
    {
        public userCourses()
        {
            this.tasks = new HashSet<task>();
        }
    
        public int table_user_id { get; set; }
        public int table_course_id { get; set; }
        public string status { get; set; }
    
        public virtual user user { get; set; }
        public virtual course course { get; set; }
        public virtual ICollection<task> tasks { get; set; }
    }
}