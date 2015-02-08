using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Narcosis101.Models
{
    public class Flash : Item
    {
        public string Brightness { get; set; }
        

        public virtual ICollection<Item> Items { get; set; }
    }

    public partial class ItemContext : DbContext
    {
        public DbSet<Flash> Flashes { get; set; }
    }
}