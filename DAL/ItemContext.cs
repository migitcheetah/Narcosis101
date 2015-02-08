using Narcosis101.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Narcosis101.DAL
{
    public class ItemContext : DbContext
    {
   public ItemContext() : base("ItemContext")
        {
        }
        
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Lense> Lenses { get; set; }
        public DbSet<Flash> Flashes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Item> Items { get; set; }
    }
}