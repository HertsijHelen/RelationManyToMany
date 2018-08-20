//-----------------------------------------------------------------------
// <copyright file="ItemSection.cs" company="Artisans">
// Copyright (c) Artisans. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace RelationManyToMAny.EF
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The Class of ItemSection
    /// </summary>
    public class ItemSection
    {
        /// <summary>
        ///  Gets or sets the Id of ItemSection
        /// </summary>
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// gets or sets SectionId
        /// </summary>
        public int SectionId { get; set; }

        /// <summary>
        /// gets or sets ItemId
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// gets or set Item
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// gets or set Section
        /// </summary>
        public Section Section { get; set; }
    }
}