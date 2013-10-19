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
    public class SucursalController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Sucursal/

        public ActionResult Index()
        {
            return View(db.Sucursal.ToList());
        }

        //
        // GET: /Sucursal/Details/5

        public ActionResult Details(int id = 0)
        {
            Sucursal sucursal = db.Sucursal.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        //
        // GET: /Sucursal/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Sucursal/Create

        [HttpPost]
        public ActionResult Create(Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Sucursal.Add(sucursal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sucursal);
        }

        //
        // GET: /Sucursal/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Sucursal sucursal = db.Sucursal.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        //
        // POST: /Sucursal/Edit/5

        [HttpPost]
        public ActionResult Edit(Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sucursal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sucursal);
        }

        //
        // GET: /Sucursal/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Sucursal sucursal = db.Sucursal.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        //
        // POST: /Sucursal/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Sucursal sucursal = db.Sucursal.Find(id);
            db.Sucursal.Remove(sucursal);
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