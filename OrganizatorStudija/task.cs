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
    
    public partial class task
    {
        public int task_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public short points { get; set; }
        public short points_max { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string status { get; set; }
        public int owner { get; set; }
        public int course { get; set; }
    
        public virtual userCourses userCours { get; set; }
    }
}
