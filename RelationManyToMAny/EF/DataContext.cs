using System;
//-----------------------------------------------------------------------
// <copyright file="RelationManyTMany.EF.cs" company="Artisans">
//     Copyright (c) Artisans. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-----------------------------------------------------------------------

namespace RelationManyToMAny.EF
{
    using System.Data.Entity;

    public class DataContext : DbContext
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