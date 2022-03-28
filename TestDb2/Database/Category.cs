using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDb2.Database
{
    public class Category
    {
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        #region Navigation

        public List<Product> Products { get; set; }

        #endregion
    }
}