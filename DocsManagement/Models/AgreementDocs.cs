using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public class AgreementDocs : Documents
    {
        public String TypeAgreement { get; set; }
        public DateTime DeadlineAgreement { get; set; }
        public String Contractor { get; set; }
        public decimal Amount { get; set; }
    }
}
