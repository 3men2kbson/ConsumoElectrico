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
    public class PrecioEnergiasController : Controller
    {
        private ConsumoElectricoContext db = new ConsumoElectricoContext();

        // GET: PrecioEnergias
        public ActionResult Index()
        {
            return View(db.PreciosEnergia.ToList());
        }

        // GET: PrecioEnergias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecioEnergia precioEnergia = db.PreciosEnergia.Find(id);
            if (precioEnergia == null)
            {
                return HttpNotFound();
            }
            return View(precioEnergia);
        }

        // GET: PrecioEnergias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrecioEnergias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PEId,PEDesc,PEDesde,PEhasta,PESinSubs,PEConsubs,FechaActivo,FechaLimite")] PrecioEnergia precioEnergia)
        {
            if (ModelState.IsValid)
            {
                db.PreciosEnergia.Add(precioEnergia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(precioEnergia);
        }

        // GET: PrecioEnergias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecioEnergia precioEnergia = db.PreciosEnergia.Find(id);
            if (precioEnergia == null)
            {
                return HttpNotFound();
            }
            return View(precioEnergia);
        }

        // POST: PrecioEnergias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PEId,PEDesc,PEDesde,PEhasta,PESinSubs,PEConsubs,FechaActivo,FechaLimite")] PrecioEnergia precioEnergia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(precioEnergia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(precioEnergia);
        }

        // GET: PrecioEnergias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecioEnergia precioEnergia = db.PreciosEnergia.Find(id);
            if (precioEnergia == null)
            {
                return HttpNotFound();
            }
            return View(precioEnergia);
        }

        // POST: PrecioEnergias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrecioEnergia precioEnergia = db.PreciosEnergia.Find(id);
            db.PreciosEnergia.Remove(precioEnergia);
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
