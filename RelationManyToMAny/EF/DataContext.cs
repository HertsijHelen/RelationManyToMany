using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationManyToMAny.EF
{
    public class DataContext:DbContext
    {
        public DataContext()
           : base("DefaultConnection")
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<ItemSection> ItemSections { get; set; }
       
    }
}