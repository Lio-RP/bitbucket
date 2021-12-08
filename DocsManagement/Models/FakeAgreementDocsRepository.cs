using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public class FakeAgreementDocsRepository
    {
        public IQueryable<AgreementDocs> AgreementDocuments => new List<AgreementDocs>
        {
            new AgreementDocs{RegistrationNomer = 101, RegistrationDate="11/14/2021", TypeDocument="typedocs",
            StateDocument="Registring", CreatedUser="liban", SignedUser="roble", TypeAgreement="typeagreement", DeadlineAgreement="11/12/2021", Contractor="company",
            Amount=120.45m, NumerSheets=2, Summary="this is a service document for saling products"},
            new AgreementDocs{RegistrationNomer = 102, RegistrationDate="11/14/2021", TypeDocument="typedocs",
            StateDocument="Registring", CreatedUser="liban", SignedUser="roble", TypeAgreement="typeagreement", DeadlineAgreement="11/12/2021", Contractor="company",
            Amount=120.45m, NumerSheets=2, Summary="this is a service document for saling products"},
             new AgreementDocs{RegistrationNomer = 103, RegistrationDate="11/14/2021", TypeDocument="typedocs",
            StateDocument="Registring", CreatedUser="liban", SignedUser="roble", TypeAgreement="typeagreement", DeadlineAgreement="11/12/2021", Contractor="company",
            Amount=120.45m, NumerSheets=2, Summary="this is a service document for saling products"}
    }.AsQueryable<AgreementDocs>();
    }
}
