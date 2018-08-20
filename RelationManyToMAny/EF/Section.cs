//-----------------------------------------------------------------------
// <copyright file="Section.cs" company="Artisans">
// Copyright (c) Artisans. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------

namespace RelationManyToMAny.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    /// <summary>
    /// The Class of Section
    /// </summary>
    public class Section
    {
        /// <summary>
        ///  Gets or sets the Id of Section
        /// </summary>
        [Key]
        [ScaffoldColumn(false)]
        public int SectionId { get; set; }

        /// <summary>
        /// Gets or sets the Name of Section
        /// </summary>
        [Display(Name = "SectionName")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Not more than 50 Symbols")]
        public string SectionName { get; set; }

        /// <summary>
        /// Gets or sets the Collection of ItemSection
        /// </summary>
        public virtual ICollection<ItemSection> ItemSections { get; set; }
    }
}