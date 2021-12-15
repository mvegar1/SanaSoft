using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class ProductCategory
    {
        public long Id { get; set; }
        [Required]
        public long ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
