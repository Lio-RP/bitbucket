<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
using DocsManagement.Models;

namespace DocsManagement.Controllers
{
    public class AgreementDocsController : Controller
    {
<<<<<<< HEAD
        private IAgreementDocsRepository repository;

        public AgreementDocsController(IAgreementDocsRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.AgreementDocuments);
=======
        private DocumentsdbContext db = new DocumentsdbContext();
        private IAgreementDocsRepository docAgreement = new EFAgreementDocsRepository();

        // GET: AgreementDocs
        public ActionResult List()
        {
            return View(docAgreement.AgreementDocuments);
            //return View(db.AgreementDocuments.ToList());
        }

        // GET: AgreementDocs/Details/5
        public ActionResult Details(int id)
        {
            AgreementDocument doc = db.AgreementDocuments.Find(id);
            if (doc == null)
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
        public ActionResult Create(AgreementDocument doc)
        {
            if (ModelState.IsValid)
            {
                db.AgreementDocuments.Add(doc);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(doc);
        }

        [Authorize(Roles = "Manager")]
        // GET: AgreementDocs/Edit/5
        public ActionResult Edit(int id = 0)
        {
            AgreementDocument doc = db.AgreementDocuments.Find(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: AgreementDocs/Edit/5
        [HttpPost]
        public ActionResult Edit(AgreementDocument doc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(doc);
        }

        [Authorize(Roles = "Manager")]
        // GET: AgreementDocs/Delete/5
        public ActionResult Delete(int id)
        {
            AgreementDocument doc = db.AgreementDocuments.Find(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: AgreementDocs/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            docAgreement.DeleteAgreementDocuments(id);
            return RedirectToAction("List");
        }

        /*
        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return View();
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }*/
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
    }
}
