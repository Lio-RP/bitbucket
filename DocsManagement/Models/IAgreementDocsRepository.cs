using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public interface IAgreementDocsRepository
    {
        IQueryable<AgreementDocs> AgreementDocuments { get; }

	void SaveAgreementDocuments(ServicesDocs agreementDocuments);

        AgreementDocs DeleteAgreementDocuments(int agreementDocsID);
    }
}
