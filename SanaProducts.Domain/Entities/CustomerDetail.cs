using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class CustomerDetail
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        [DisplayName("Phone 1")]
        public string Phone1 { get; set; }
        [DisplayName("Phone 2")]
        public string Phone2 { get; set; }
        [DisplayName("Email 1")]
        public string Email1 { get; set; }
        [DisplayName("Email 2")]
        public string Email2 { get; set; }
        [DisplayName("Full Address 1")]
        public string FullAddress1 { get; set; }
        [DisplayName("Full Address 2")]
        public string FullAddress2 { get; set; }
    }
}
