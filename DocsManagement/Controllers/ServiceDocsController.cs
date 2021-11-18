using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocsManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocsManagement.Controllers
{
    public class ServiceDocsController : Controller
    {
        private IServiceDocsRepository repository;

        public ServiceDocsController(IServiceDocsRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.ServicesDocuments);
    }
}
