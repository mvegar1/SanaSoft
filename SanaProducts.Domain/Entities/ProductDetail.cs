using SanaProducts.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class ProductDetail
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        [DisplayName("Produced By")]
        public string ProducedBy { get; set; }
        [DisplayName("Technical DataSheet")]
        public string TechnicalDataSheet { get; set; }
        [DisplayName("Model or Reference")]
        public string Model { get; set; }
        public string Description { get; set; }
        public double Score { get; set; }
        public Gender Gender { get; set; }
    }
}
