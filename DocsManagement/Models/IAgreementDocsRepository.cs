using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public interface IAgreementDocsRepository
    {
<<<<<<< HEAD
        IQueryable<AgreementDocs> AgreementDocuments { get; }

	void SaveAgreementDocuments(ServicesDocs agreementDocuments);

        AgreementDocs DeleteAgreementDocuments(int agreementDocsID);
=======
        IQueryable<AgreementDocument> AgreementDocuments { get; }

	    void SaveAgreementDocuments(AgreementDocument agreementDocuments);

        void DeleteAgreementDocuments(int agreementDocsID);
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
    }
}
