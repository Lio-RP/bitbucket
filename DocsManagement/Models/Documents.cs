using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public class Documents
    {
        public int RegistrationNomer { get; set; }
        public String RegistrationDate { get; set; }
        public String TypeDocument { get; set; }
        public String StateDocument { get; set; }
        public String CreatedUser { get; set; }
        public String SignedUser { get; set; }
        public int NumerSheets { get; set; }
        public String Summary { get; set; }
    }
}
