using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class Product
    {
        public long Id { get; set; }

        [DisplayName("Product Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Trade Mark")]
        [Required]
        public string TradeMark { get; set; }

        public string Image { get; set; }
    }
}
