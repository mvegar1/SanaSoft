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
    public class Customer
    {
        public long Id { get; set; }
        [DisplayName("Document Type")]
        [Required]
        public DocumentType DocumentType { get; set; }
        [Required]
        public string Document { get; set; }
        [DisplayName("Customer Name")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Customer Last Name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Birth Date")]
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
    }
}
