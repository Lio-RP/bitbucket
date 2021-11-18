using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public class EFAgreementDocsRepository : IAgreementDocsRepository
    {
        private ApplicationDbContext context;

        public EFAgreementDocsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<AgreementDocs> AgreementDocuments => context.AgreementDocuments;

	public void SaveAgreementDocuments(ServicesDocs agreementDocuments);

        public AgreementDocs DeleteAgreementDocuments(int agreementDocsID);
    }
}
