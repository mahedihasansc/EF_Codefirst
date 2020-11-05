using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodefirstApp.Models
{
    public class Products
    {
        public Products()
        {
            Order = new HashSet<Orders>();
        }
        [Key]
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual ICollection<Orders> Order { get; set; }
    }
}
