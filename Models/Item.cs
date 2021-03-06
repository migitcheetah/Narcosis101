﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Narcosis101.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Class { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ShutterSpeed { get; set; }
        public string PowerReq { get; set; }
        public string Dimensions { get; set; }
        public string Weight { get; set; }
        public string Finish { get; set; }


      
        public virtual Camera Camera { get; set; }
        public virtual Lense Lense { get; set; }
        public virtual Flash Flash { get; set; }
    }

    public partial class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }



}