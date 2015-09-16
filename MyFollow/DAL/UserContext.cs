using MyFollow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyFollow.DAL
{
    public class UserContext : DbContext
    {

        public UserContext() : base()
        {
        }
        public DbSet<ProductOwners> ProductOwners { get; set; }

        public DbSet<EndUsers> EndUsers { get; set; }
        public DbSet<Address> Address { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}