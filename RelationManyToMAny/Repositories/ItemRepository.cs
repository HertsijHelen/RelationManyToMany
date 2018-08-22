//-----------------------------------------------------------------------
// <copyright file="ItemRepository.cs" company="Artisans">
// Copyright (c) Artisans. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------

namespace RelationManyToMAny.Repositories
{
    using System;
    using System.Collections.Generic;
    using RelationManyToMAny.EF;

    /// <summary>
    /// Initialize a new instance of EmployeesRepository
    /// </summary>
    public class ItemRepository : IRepository<Item>
    {
        /// <summary>
        /// Initialize a new Instance of DataContext
        /// </summary>
        private DataContext db = new DataContext();

        /// <summary>
        /// The property of disposed DataContext
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Get all records from Items table
        /// </summary>
        /// <returns>record from Items table</returns>
        public IEnumerable<Item> GetAll()
        {
            return this.db.Items;
        }

        /// <summary>
        /// Add a new record to Item table
        /// </summary>
        /// <param name="item">the record wich need to added</param>
        /// <returns>return item</returns>
        public Item Create(Item item)
        {
            try
            {
                this.db.Items.Add(item);
                this.db.SaveChanges();
                return item;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Update a recod Items table by id
        /// </summary>
        /// <param name="id">a record wich need to update</param>
        /// <param name="item">record wich update</param>
        /// <returns>return true or false</returns>
        public bool Update(int id, Item item)
        {
            Item it = this.db.Items.Find(id);
            try
            {
                it.ItemName = item.ItemName;
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Remove a record from Items table by id
        /// </summary>
        /// <param name="id">a record wich delete</param>
        /// <returns>return true of false</returns>
        public bool Delete(int id)
        {
            Item item = db.Items.Find(id);
            try
            {
                this.db.Items.Remove(item);
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// The Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.db.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// The Dispose(true) method 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}