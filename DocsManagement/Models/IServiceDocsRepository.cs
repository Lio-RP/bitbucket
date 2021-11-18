using System.Linq;


namespace DocsManagement.Models
{
    public interface IServiceDocsRepository
    {
        IQueryable<ServicesDocs> ServicesDocuments { get; }

	void SaveServicesDocuments(ServicesDocs servicesDocuments);

        ServicesDocs DeleteServicesDocuments(int serviceDocsID);
    }
}
