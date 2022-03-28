using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace TestDb2.Database
{
    public class Designer
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Fistname")]
        public string Name { get; set; } 
        
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        #region Navigation

        public Guid? CountryId { get; set; }
        
        public Country Country { get; set; }

        public List<Product> Products { get; set; }
        
        public List<Brand> Brands { get; set; }
        
        #endregion
        
        
    }
}