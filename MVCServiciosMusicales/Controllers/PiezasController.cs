using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCServiciosMusicales.Models;

namespace MVCServiciosMusicales.Controllers
{
    public class PiezasController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Piezas/

        public ActionResult Index()
        {
            return View(db.Piezas.ToList());
        }

        //
        // GET: /Piezas/Details/5

        public ActionResult Details(int id = 0)
        {
            Piezas piezas = db.Piezas.Find(id);
            if (piezas == null)
            {
                return HttpNotFound();
            }
            return View(piezas);
        }

        //
        // GET: /Piezas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Piezas/Create

        [HttpPost]
        public ActionResult Create(Piezas piezas)
        {
            if (ModelState.IsValid)
            {
                db.Piezas.Add(piezas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(piezas);
        }

        //
        // GET: /Piezas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Piezas piezas = db.Piezas.Find(id);
            if (piezas == null)
            {
                return HttpNotFound();
            }
            return View(piezas);
        }

        //
        // POST: /Piezas/Edit/5

        [HttpPost]
        public ActionResult Edit(Piezas piezas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(piezas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(piezas);
        }

        //
        // GET: /Piezas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Piezas piezas = db.Piezas.Find(id);
            if (piezas == null)
            {
                return HttpNotFound();
            }
            return View(piezas);
        }

        //
        // POST: /Piezas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Piezas piezas = db.Piezas.Find(id);
            db.Piezas.Remove(piezas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}