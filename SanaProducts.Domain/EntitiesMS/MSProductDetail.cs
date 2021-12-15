using SanaProducts.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.EntitiesMS
{
    public class MSProductDetail
    {
        public long Id { get; set; }
        [Required]
        public long ProductId { get; set; }
        public MSProduct Product { get; set; }
        [DisplayName("Produced By")]
        [Required]
        public string ProducedBy { get; set; }
        [DisplayName("Technical DataSheet")]
        [Required]
        public string TechnicalDataSheet { get; set; }
        [DisplayName("Model or Reference")]
        public string Model { get; set; }
        public string Description { get; set; }
        public double Score { get; set; }
        public Gender Gender { get; set; }
    }
}
