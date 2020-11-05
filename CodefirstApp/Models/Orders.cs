using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodefirstApp.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public string OrderDate { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public virtual Products Product { get; set; }
    }
}
