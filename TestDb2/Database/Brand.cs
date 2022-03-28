using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDb2.Database
{
    public class Brand
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        #region Navigation

        public List<Designer> Designers { get; set; }
        
        public List<Product> Products { get; set; }
        
        #endregion
    }
}