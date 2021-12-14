using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class CustomerDetail
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string FullAddress1 { get; set; }
        public string FullAddress2 { get; set; }
    }
}
