using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPractice1.Models
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int UnitsOnHand { get; set; }
        public decimal Cost { get; set; }
        public decimal SellingPrice { get; set; }

        [ForeignKey("SupplierCode")]
        public string SupplierCode { get; set; }

        public Supplier Supplier { get; set; }
    }
}
