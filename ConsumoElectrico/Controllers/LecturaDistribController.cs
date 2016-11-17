using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConsumoElectrico.Models;

namespace ConsumoElectrico.Controllers
{
    public class LecturaDistribController : Controller
    {
        private ConsumoElectricoContext db = new ConsumoElectricoContext();

        // GET: LecturaDistrib
        public ActionResult Index()
        {
            return View(db.LecturasDistribs.ToList());
        }

        // GET: LecturaDistrib/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LecturaDistrib lecturaDistrib = db.LecturasDistribs.Find(id);
            if (lecturaDistrib == null)
            {
                return HttpNotFound();
            }
            return View(lecturaDistrib);
        }

        // GET: LecturaDistrib/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LecturaDistrib/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LDId,LDFecha,LDLectura")] LecturaDistrib lecturaDistrib)
        {
            if (ModelState.IsValid)
            {
                db.LecturasDistribs.Add(lecturaDistrib);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lecturaDistrib);
        }

        // GET: LecturaDistrib/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LecturaDistrib lecturaDistrib = db.LecturasDistribs.Find(id);
            if (lecturaDistrib == null)
            {
                return HttpNotFound();
            }
            return View(lecturaDistrib);
        }

        // POST: LecturaDistrib/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LDId,LDFecha,LDLectura")] LecturaDistrib lecturaDistrib)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lecturaDistrib).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lecturaDistrib);
        }

        // GET: LecturaDistrib/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LecturaDistrib lecturaDistrib = db.LecturasDistribs.Find(id);
            if (lecturaDistrib == null)
            {
                return HttpNotFound();
            }
            return View(lecturaDistrib);
        }

        // POST: LecturaDistrib/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LecturaDistrib lecturaDistrib = db.LecturasDistribs.Find(id);
            db.LecturasDistribs.Remove(lecturaDistrib);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
