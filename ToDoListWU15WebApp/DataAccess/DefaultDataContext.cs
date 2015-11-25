using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ToDoListWU15WebApp.Models;

namespace ToDoListWU15WebApp.DataAccess
{
    public class DefaultDataContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
