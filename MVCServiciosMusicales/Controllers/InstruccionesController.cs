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
    public class InstruccionesController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Instrucciones/

        public ActionResult Index()
        {
            return View(db.Instrucciones.ToList());
        }

        //
        // GET: /Instrucciones/Details/5

        public ActionResult Details(int id = 0)
        {
            Instrucciones instrucciones = db.Instrucciones.Find(id);
            if (instrucciones == null)
            {
                return HttpNotFound();
            }
            return View(instrucciones);
        }

        //
        // GET: /Instrucciones/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Instrucciones/Create

        [HttpPost]
        public ActionResult Create(Instrucciones instrucciones)
        {
            if (ModelState.IsValid)
            {
                db.Instrucciones.Add(instrucciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(instrucciones);
        }

        //
        // GET: /Instrucciones/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Instrucciones instrucciones = db.Instrucciones.Find(id);
            if (instrucciones == null)
            {
                return HttpNotFound();
            }
            return View(instrucciones);
        }

        //
        // POST: /Instrucciones/Edit/5

        [HttpPost]
        public ActionResult Edit(Instrucciones instrucciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instrucciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(instrucciones);
        }

        //
        // GET: /Instrucciones/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Instrucciones instrucciones = db.Instrucciones.Find(id);
            if (instrucciones == null)
            {
                return HttpNotFound();
            }
            return View(instrucciones);
        }

        //
        // POST: /Instrucciones/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Instrucciones instrucciones = db.Instrucciones.Find(id);
            db.Instrucciones.Remove(instrucciones);
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