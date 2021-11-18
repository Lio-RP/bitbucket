using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocsManagement.Models;

namespace DocsManagement.Controllers
{
    public class AgreementDocsController : Controller
    {
        private IAgreementDocsRepository repository;

        public AgreementDocsController(IAgreementDocsRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.AgreementDocuments);
    }
}
