using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Model
{
    public class DomainAccessRecord
    {
        public long Id { get; set; }
        public string SuppliedUrl { get; set; }
        public bool IsFound { get; set; }

        public DomainUrl DomainUrl { get; set; }
    }
}
