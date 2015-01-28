using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Narcosis101.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Item { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}