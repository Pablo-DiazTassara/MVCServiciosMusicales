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
    public class FacturaController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Factura/

        public ActionResult Index()
        {
            var factura = db.Factura.Include(f => f.Servicio).Include(f => f.Sucursal);
            return View(factura.ToList());
        }

        //
        // GET: /Factura/Details/5

        public ActionResult Details(int id = 0)
        {
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        //
        // GET: /Factura/Create

        public ActionResult Create()
        {
            ViewBag.Servicio_Id = new SelectList(db.Servicio, "Id", "Descripcion");
            ViewBag.Sucursal_Id = new SelectList(db.Sucursal, "Id", "Zona");
            return View();
        }

        //
        // POST: /Factura/Create

        [HttpPost]
        public ActionResult Create(Factura factura)
        {
            if (ModelState.IsValid)
            {
                db.Factura.Add(factura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Servicio_Id = new SelectList(db.Servicio, "Id", "Descripcion", factura.Servicio_Id);
            ViewBag.Sucursal_Id = new SelectList(db.Sucursal, "Id", "Zona", factura.Sucursal_Id);
            return View(factura);
        }

        //
        // GET: /Factura/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            ViewBag.Servicio_Id = new SelectList(db.Servicio, "Id", "Descripcion", factura.Servicio_Id);
            ViewBag.Sucursal_Id = new SelectList(db.Sucursal, "Id", "Zona", factura.Sucursal_Id);
            return View(factura);
        }

        //
        // POST: /Factura/Edit/5

        [HttpPost]
        public ActionResult Edit(Factura factura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Servicio_Id = new SelectList(db.Servicio, "Id", "Descripcion", factura.Servicio_Id);
            ViewBag.Sucursal_Id = new SelectList(db.Sucursal, "Id", "Zona", factura.Sucursal_Id);
            return View(factura);
        }

        //
        // GET: /Factura/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        //
        // POST: /Factura/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Factura factura = db.Factura.Find(id);
            db.Factura.Remove(factura);
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