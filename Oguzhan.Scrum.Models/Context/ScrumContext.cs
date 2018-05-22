using Oguzhan.Scrum.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oguzhan.Scrum.Models.Context
{    public class ScrumContext : DbContext
{
    public ScrumContext() : base("ScrumContext")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Stories> Stories { get; set; }
       
    }
}
