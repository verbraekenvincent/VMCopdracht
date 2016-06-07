using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCopdracht.Models
{
    public class ComponentContext : DbContext
    {
        public ComponentContext() : base("SchoolContext")
        {
        }

        public DbSet<Component> Components { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}