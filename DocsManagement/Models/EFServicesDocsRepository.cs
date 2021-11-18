using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
    public class EFServicesDocsRepository : IServiceDocsRepository
    {
        private ApplicationDbContext context;

        public EFServicesDocsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<ServicesDocs> ServicesDocuments => context.ServicesDocuments;

	public void SaveServicesDocuments(ServicesDocs servicesDocuments);

        public ServicesDocs DeleteServicesDocuments(int serviceDocsID);
    }
}
