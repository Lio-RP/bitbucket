using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public class FakeServiceDocsRepository : IServiceDocsRepository
    {
        public IQueryable<ServicesDocs> ServicesDocuments => new List<ServicesDocs>
        {
            new ServicesDocs{RegistrationNomer = 101, RegistrationDate="11/14/2021", TypeDocument="typedocs",
            StateDocument="Registring", CreatedUser="liban", SignedUser="roble", NumerSheets=2, Summary="this is a service document for saling products"},
            new ServicesDocs{RegistrationNomer = 102, RegistrationDate="11/14/2021", TypeDocument="typedocs",
            StateDocument="Registring", CreatedUser="liban", SignedUser="roble", NumerSheets=2, Summary="this is a service document for saling products"},
             new ServicesDocs{RegistrationNomer = 103, RegistrationDate="11/14/2021", TypeDocument="typedocs",
            StateDocument="Registring", CreatedUser="liban", SignedUser="roble", NumerSheets=2, Summary="this is a service document for saling products"}
    }.AsQueryable<ServicesDocs>();

        public void SaveServicesDocuments(ServicesDocs servicesDocuments)
        {

        }

        public ServicesDocs DeleteServicesDocuments(int serviceDocsID)
        {
            return new ServicesDocs();
        }
    }
}
