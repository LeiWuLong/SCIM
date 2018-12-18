using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;  
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using SCIM_Processor.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SCIM_Processor
{
    public partial class SCIMContext : DbContext
    {
        public SCIMContext()
            : base("name=SCIMContext")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<SCIMContext>());
        }

        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserAccess> TblUserAccess { get; set; }
        public virtual DbSet<TblTest> TblTest { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblLocation> TblLocation { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)


        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}