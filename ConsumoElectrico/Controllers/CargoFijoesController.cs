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
    public class CargoFijoesController : Controller
    {
        private ConsumoElectricoContext db = new ConsumoElectricoContext();

        // GET: CargoFijoes
        public ActionResult Index()
        {
            return View(db.CargosFijo.ToList());
        }

        // GET: CargoFijoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CargoFijo cargoFijo = db.CargosFijo.Find(id);
            if (cargoFijo == null)
            {
                return HttpNotFound();
            }
            return View(cargoFijo);
        }

        // GET: CargoFijoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CargoFijoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CFId,CFDesc,CFDesde,CFHasta,CFSinSubs,CFConSubs,FechaActivo,FechaLimite")] CargoFijo cargoFijo)
        {
            if (ModelState.IsValid)
            {
                db.CargosFijo.Add(cargoFijo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cargoFijo);
        }

        // GET: CargoFijoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CargoFijo cargoFijo = db.CargosFijo.Find(id);
            if (cargoFijo == null)
            {
                return HttpNotFound();
            }
            return View(cargoFijo);
        }

        // POST: CargoFijoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CFId,CFDesc,CFDesde,CFHasta,CFSinSubs,CFConSubs,FechaActivo,FechaLimite")] CargoFijo cargoFijo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cargoFijo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cargoFijo);
        }

        // GET: CargoFijoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CargoFijo cargoFijo = db.CargosFijo.Find(id);
            if (cargoFijo == null)
            {
                return HttpNotFound();
            }
            return View(cargoFijo);
        }

        // POST: CargoFijoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CargoFijo cargoFijo = db.CargosFijo.Find(id);
            db.CargosFijo.Remove(cargoFijo);
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
