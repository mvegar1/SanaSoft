using SanaProducts.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Shipped Date")]
        public DateTime ShippedDate { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        [DisplayName("Full Address")]
        public string FullAddress { get; set; }
        [DisplayName("Address Type")]
        public AddressType AddressType { get; set; }
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
        [DisplayName("Additional Information")]
        public string AdditionalInformation { get; set; }
    }
}
