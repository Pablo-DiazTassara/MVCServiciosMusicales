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
    public class DireccionController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Direccion/

        public ActionResult Index()
        {
            return View(db.Direccion.ToList());
        }

        //
        // GET: /Direccion/Details/5

        public ActionResult Details(int id = 0)
        {
            Direccion direccion = db.Direccion.Find(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        //
        // GET: /Direccion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Direccion/Create

        [HttpPost]
        public ActionResult Create(Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                
                db.Direccion.Add(direccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(direccion);
        }

        //
        // GET: /Direccion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Direccion direccion = db.Direccion.Find(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        //
        // POST: /Direccion/Edit/5

        [HttpPost]
        public ActionResult Edit(Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(direccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(direccion);
        }

        //
        // GET: /Direccion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Direccion direccion = db.Direccion.Find(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        //
        // POST: /Direccion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Direccion direccion = db.Direccion.Find(id);
            db.Direccion.Remove(direccion);
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