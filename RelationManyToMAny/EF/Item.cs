//-----------------------------------------------------------------------
// <copyright file="Item.cs" company="Artisans">
// Copyright (c) Artisans. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace RelationManyToMAny.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    /// <summary>
    /// The class of Item
    /// </summary>
    public class Item
    {
        /// <summary>
        ///  Gets or sets the Id of Item
        /// </summary>
        [Key]
        [ScaffoldColumn(false)]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the Name of Item
        /// </summary>
        [Display(Name = "ItemName")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Not more than 50 Symbols")]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or sets the Collection of ItemSection
        /// </summary>
        public virtual ICollection<ItemSection> ItemSections { get; set; }
    }
}