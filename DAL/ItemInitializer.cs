﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Narcosis101.Models;

namespace Narcosis101.DAL
{
    public class ItemInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ItemContext>
    {
        protected override void Seed(ItemContext context)
        {
            var cameras = new List<Camera>
            {
            new Camera{ID=00001,Make="Nikonos",Model="test 1"},
            new Camera{ID=00002,Make="Nikonos",Model="test 2"},
            new Camera{ID=00003,Make="Nikonos",Model="test 3"}
           };

            cameras.ForEach(s => context.Cameras.Add(s));
            context.SaveChanges();

            var lenses = new List<Lense>
            {
            new Lense{ID=00001,Make="Nikonos",Model="test 1"},
            new Lense{ID=00002,Make="Nikonos",Model="test 2"},
            new Lense{ID=00003,Make="Nikonos",Model="test 3"},
            };
            lenses.ForEach(s => context.Lenses.Add(s));
            context.SaveChanges();

            var flashes = new List<Flash>
            {
            new Flash{ID=00001,Make="Nikonos",Model="test 1"},
            new Flash{ID=00002,Make="Nikonos",Model="test 2"},
            new Flash{ID=00003,Make="Nikonos",Model="test 3"}
           };
            flashes.ForEach(s => context.Flashes.Add(s));
            context.SaveChanges();
        }
    }
}