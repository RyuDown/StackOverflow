using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class databaseContext : DbContext
    {
        public databaseContext() : base("DatabaseConnection") { }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<eventResult> EventResults { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Swimmer> Swimmers { get; set; }
    }
}