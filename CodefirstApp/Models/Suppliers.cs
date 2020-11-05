using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodefirstApp.Models
{
    public class Suppliers
    {
        public Suppliers()
        {
            Products = new HashSet<Products>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "supplier name required")]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
