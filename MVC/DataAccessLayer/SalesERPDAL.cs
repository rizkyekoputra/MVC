using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Models;
using System.Data.Entity;

namespace MVC.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}