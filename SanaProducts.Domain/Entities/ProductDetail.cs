using SanaProducts.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class ProductDetail
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProducedBy { get; set; }
        public string TechnicalDataSheet { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Score { get; set; }
        public Gender Gender { get; set; }
    }
}
