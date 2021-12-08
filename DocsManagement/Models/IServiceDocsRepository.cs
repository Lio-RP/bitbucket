using System.Linq;


namespace DocsManagement.Models
{
    public interface IServiceDocsRepository
    {
<<<<<<< HEAD
        IQueryable<ServicesDocs> ServicesDocuments { get; }

	void SaveServicesDocuments(ServicesDocs servicesDocuments);

        ServicesDocs DeleteServicesDocuments(int serviceDocsID);
=======
        IQueryable<ServiceDocument> ServicesDocuments { get; }

	    void SaveServicesDocuments(ServiceDocument servicesDocuments);

        ServiceDocument DeleteServicesDocuments(int serviceDocsID);
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
    }
}
