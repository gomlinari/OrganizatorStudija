﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppConnectionSettings : DbContext
    {
        public AppConnectionSettings()
            : base("name=AppConnectionSettings")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<user> users { get; set; }
        public DbSet<usefull_link> usefull_links { get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<userCourses> userCourses { get; set; }
        public DbSet<staff> staff { get; set; }
        public DbSet<courseStaff> courseStaff { get; set; }
        public DbSet<task> tasks { get; set; }
    }
}
