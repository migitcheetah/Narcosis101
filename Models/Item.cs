using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Narcosis101.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Camera { get; set; }
        public string Flash { get; set; }
        public string Lense { get; set; }

        public virtual Camera Camera { get; set; }
        public virtual Lense Lense { get; set; }
        public virtual Flash Flash { get; set; }
    }
}