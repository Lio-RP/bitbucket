using DocsManagement.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DocsManagement.Models
{
    public class EFAgreementDocsRepository : IAgreementDocsRepository
    {
        
        private DocumentsDBEntities context = new DocumentsDBEntities();

        public IQueryable<Agreement> AgreementDocuments => context.Agreements;

        public void SaveAgreementDocuments(AgreementDocument agreementDocs, String File)
        {
            FileInfo fil = new FileInfo(File);

            using (DocumentsDBEntities doc = new DocumentsDBEntities())
            {
                var agDoc = new Agreement()
                {
                    RegistrationNomer = agreementDocs.RegistrationNomer,
                    RegistrationData = agreementDocs.RegistrationData,
                    TypeDocument = agreementDocs.TypeDocument,
                    StateDocument = agreementDocs.StateDocument,
                    TypeAgreement = agreementDocs.TypeAgreement,
                    DeadlineAgreement = agreementDocs.DeadlineAgreement,
                    Conractor = agreementDocs.Contractor,
                    Amount = agreementDocs.Amount,
                    CreatedUser = agreementDocs.CreatedUser,
                    SignedUser = agreementDocs.SignedUser,
                    NumberSheets = agreementDocs.NumberSheets,
                    Summary = agreementDocs.Summary,
                    FileName = Path.GetFileName(File),
                    FileType = fil.Extension,
                    FileContent = System.IO.File.ReadAllBytes(File)

                };
                doc.Agreements.Add(agDoc);
                doc.SaveChanges();

            }
        }

        public void DeleteAgreementDocuments(int agreementDocsID)
        {
            Agreement doc = context.Agreements.Find(agreementDocsID);
            if(doc != null)
            {
                context.Agreements.Remove(doc);
                context.SaveChanges();
            }
        }
    }
}
