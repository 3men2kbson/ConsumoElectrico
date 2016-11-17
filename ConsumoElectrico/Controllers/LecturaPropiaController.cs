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
    public class LecturaPropiaController : Controller
    {
        private ConsumoElectricoContext db = new ConsumoElectricoContext();

        // GET: LecturaPropia
        public ActionResult Index()
        {
            return View(db.LecturasPropias.ToList());
        }

        // GET: LecturaPropia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LecturaPropia lecturaPropia = db.LecturasPropias.Find(id);
            if (lecturaPropia == null)
            {
                return HttpNotFound();
            }
            return View(lecturaPropia);
        }

        // GET: LecturaPropia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LecturaPropia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LPId,LPFecha,LPLectura,LPSubsidio")] LecturaPropia lecturaPropia)
        {
            if (ModelState.IsValid)
            {
                db.LecturasPropias.Add(lecturaPropia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lecturaPropia);
        }

        // GET: LecturaPropia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LecturaPropia lecturaPropia = db.LecturasPropias.Find(id);
            if (lecturaPropia == null)
            {
                return HttpNotFound();
            }
            return View(lecturaPropia);
        }

        // POST: LecturaPropia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LPId,LPFecha,LPLectura,LPSubsidio")] LecturaPropia lecturaPropia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lecturaPropia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lecturaPropia);
        }

        // GET: LecturaPropia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LecturaPropia lecturaPropia = db.LecturasPropias.Find(id);
            if (lecturaPropia == null)
            {
                return HttpNotFound();
            }
            return View(lecturaPropia);
        }

        // POST: LecturaPropia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LecturaPropia lecturaPropia = db.LecturasPropias.Find(id);
            db.LecturasPropias.Remove(lecturaPropia);
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
