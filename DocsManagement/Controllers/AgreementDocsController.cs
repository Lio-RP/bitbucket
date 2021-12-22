using DocsManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocsManagement.Controllers
{
    public class AgreementDocsController : Controller
    {

        DocumentsDBEntities context = new DocumentsDBEntities();
        EFAgreementDocsRepository ef = new EFAgreementDocsRepository();

        // GET: AgreementDocs
        [Authorize(Roles = "Employee, Admin, Manager")]
        public ActionResult List()
        {
            return View(ef.AgreementDocuments);
        }

        // GET: AgreementDocs/Details/5
        [Authorize(Roles = "Employee, Admin, Manager")]
        public ActionResult Details(int id)
        {
            Agreement doc = context.Agreements.Find(id);
            if(doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        [Authorize(Roles = "Employee")]
        // GET: AgreementDocs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgreementDocs/Create
        [HttpPost]
        public ActionResult Create(AgreementDocument agreementDocs)
        {
            
            if (ModelState.IsValid)
            {
                String File = SaveToPhysicalLocation(agreementDocs.File);
                ef.SaveAgreementDocuments(agreementDocs, File);
                return RedirectToAction("List");
            }


            return View(agreementDocs);
        }

        private string SaveToPhysicalLocation(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/UploadedFiles"), fileName);
                file.SaveAs(path);
                return path;
            }
            return string.Empty;
        }

        [HttpGet]
        public FileResult Download(int id)
        {
            Agreement doc = context.Agreements.Find(id);
            //string fullpath = Path.Combine(Server.MapPath("~/App_Data/UploadedFiles"), doc.FileName);
            //FileInfo file = new FileInfo(fullpath);
            //String fileName = Path.GetFileName(fullpath);
            //byte[] fileContent = System.IO.File.ReadAllBytes(fullpath);
            //String ext = file.Extension;
            //String contentType = MimeMapping.GetMimeMapping(fullpath);
            //return File(fileContent, ext, fileName);
            return File(doc.FileContent, doc.FileType, doc.FileName);
        }



        // GET: AgreementDocs/Edit/5
        [Authorize(Roles = "Manager")]
        public ActionResult Edit(int id)
        {
            Agreement doc = context.Agreements.Find(id);
            if(doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: AgreementDocs/Edit/5
        [HttpPost]
        public ActionResult Edit(Agreement doc)
        {
            if (ModelState.IsValid)
            {
                context.Entry(doc).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("List");
            }
            return View(doc);
        }

        [Authorize(Roles = "Manager")]
        // GET: AgreementDocs/Delete/5
        public ActionResult Delete(int id)
        {
            Agreement doc = context.Agreements.Find(id);
            if(doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: AgreementDocs/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ef.DeleteAgreementDocuments(id);
            return RedirectToAction("List");
        }
    }
}
