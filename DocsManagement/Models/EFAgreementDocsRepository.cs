using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public class EFAgreementDocsRepository : IAgreementDocsRepository
    {
<<<<<<< HEAD
        private ApplicationDbContext context;

        public EFAgreementDocsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<AgreementDocs> AgreementDocuments => context.AgreementDocuments;

	public void SaveAgreementDocuments(ServicesDocs agreementDocuments);

        public AgreementDocs DeleteAgreementDocuments(int agreementDocsID);
=======
        private DocumentsdbContext context = new DocumentsdbContext();

        public IQueryable<AgreementDocument> AgreementDocuments => context.AgreementDocuments;

        public void SaveAgreementDocuments(AgreementDocument agreementDocuments)
        {

        }

        public void DeleteAgreementDocuments(int agreementDocsID)
        {
            AgreementDocument doc = context.AgreementDocuments.Find(agreementDocsID);
            if(doc != null)
            {
                context.AgreementDocuments.Remove(doc);
                context.SaveChanges();
            }
        }
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
    }
}
