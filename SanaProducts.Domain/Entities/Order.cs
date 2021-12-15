using SanaProducts.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class Order
    {
        public long Id { get; set; }
        [Required]
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        [DisplayName("Order Date")]
        [Required]
        public DateTime OrderDate { get; set; }
        [DisplayName("Shipped Date")]
        [Required]
        public DateTime ShippedDate { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string City { get; set; }
        [DisplayName("Full Address")]
        [Required]
        public string FullAddress { get; set; }
        [DisplayName("Address Type")]
        [Required]
        public AddressType AddressType { get; set; }
        [DisplayName("Postal Code")]
        [Required]
        public string PostalCode { get; set; }
        [DisplayName("Additional Information")]        
        public string AdditionalInformation { get; set; }
    }
}
