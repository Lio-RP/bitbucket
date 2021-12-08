using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsManagement.Models
{
<<<<<<< HEAD
    public class EFServicesDocsRepository : IServiceDocsRepository
    {
=======
    public class EFServicesDocsRepository //IServiceDocsRepository
    {
        /*
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
        private ApplicationDbContext context;

        public EFServicesDocsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<ServicesDocs> ServicesDocuments => context.ServicesDocuments;

<<<<<<< HEAD
	public void SaveServicesDocuments(ServicesDocs servicesDocuments);

        public ServicesDocs DeleteServicesDocuments(int serviceDocsID);
=======
	public void SaveServicesDocuments(ServicesDocs servicesDocuments)
        {

        }

        public ServicesDocs DeleteServicesDocuments(int serviceDocsID)
        {
            return new ServicesDocs();
        }*/
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
    }
}
