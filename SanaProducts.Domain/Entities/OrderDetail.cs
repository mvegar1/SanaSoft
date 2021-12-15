using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class OrderDetail
    {
        public long Id { get; set; }
        [DisplayName("Order Id")]
        [Required]
        public long OrderId { get; set; }
        public Order Order { get; set; }
        [DisplayName("Product Id")]
        [Required]
        public long ProductId { get; set; }
        public Product Product { get; set; }
        [DisplayName("Unit Price")]
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        public long Quantity { get; set; }
        public string FormattedUnitPrice
        {
            get { return string.Format("{0:C}", UnitPrice); }
        }

        [DisplayName("Total Price")]
        public string FormattedTotalPrice
        {
            get { return string.Format("{0:C}", UnitPrice * Quantity); }
        }
    }
}
