using SanaProducts.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaProducts.Domain.Entities
{
    public class Customer
    {
        public long Id { get; set; }
        [DisplayName("Document Type")]
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}
