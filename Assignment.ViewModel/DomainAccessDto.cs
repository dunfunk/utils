using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.ViewModel
{
    public class DomainAccessRecordDto
    {
        public long Id { get; set; }
        public string SuppliedUrl { get; set; }
        public bool IsFound { get; set; }
    }
}
