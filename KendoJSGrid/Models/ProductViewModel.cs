using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KendoJSGrid.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public Nullable<int> SupplierID { get; set; }
        [Required]
        public Nullable<int> CategoryID { get; set; }
        [Required]
        public string QuantityPerUnit { get; set; }
        [Required]
        public Nullable<decimal> UnitPrice { get; set; }
        [Required]
        public Nullable<short> UnitsInStock { get; set; }
        [Required]
        public Nullable<short> UnitsOnOrder { get; set; }
        [Required]
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}