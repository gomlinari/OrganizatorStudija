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
    
    public partial class user
    {
        public user()
        {
            this.usefull_link = new HashSet<usefull_link>();
            this.userCourses = new HashSet<userCourses>();
        }
    
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    
        public virtual ICollection<usefull_link> usefull_link { get; set; }
        public virtual ICollection<userCourses> userCourses { get; set; }
    }
}
