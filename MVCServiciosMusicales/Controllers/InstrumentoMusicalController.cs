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
    public class InstrumentoMusicalController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /InstrumentoMusical/

        public ActionResult Index()
        {
            var instrumentomusical = db.InstrumentoMusical.Include(i => i.TipoInstrumento);
            return View(instrumentomusical.ToList());
        }

        //
        // GET: /InstrumentoMusical/Details/5

        public ActionResult Details(int id = 0)
        {
            InstrumentoMusical instrumentomusical = db.InstrumentoMusical.Find(id);
            if (instrumentomusical == null)
            {
                return HttpNotFound();
            }
            return View(instrumentomusical);
        }

        //
        // GET: /InstrumentoMusical/Create

        public ActionResult Create()
        {
            ViewBag.TipoInstrumento_Id = new SelectList(db.TipoInstrumento, "Id", "Descripcion");
            return View();
        }

        //
        // POST: /InstrumentoMusical/Create

        [HttpPost]
        public ActionResult Create(InstrumentoMusical instrumentomusical)
        {
            if (ModelState.IsValid)
            {
                db.InstrumentoMusical.Add(instrumentomusical);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoInstrumento_Id = new SelectList(db.TipoInstrumento, "Id", "Descripcion", instrumentomusical.TipoInstrumento_Id);
            return View(instrumentomusical);
        }

        //
        // GET: /InstrumentoMusical/Edit/5

        public ActionResult Edit(int id = 0)
        {
            InstrumentoMusical instrumentomusical = db.InstrumentoMusical.Find(id);
            if (instrumentomusical == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoInstrumento_Id = new SelectList(db.TipoInstrumento, "Id", "Descripcion", instrumentomusical.TipoInstrumento_Id);
            return View(instrumentomusical);
        }

        //
        // POST: /InstrumentoMusical/Edit/5

        [HttpPost]
        public ActionResult Edit(InstrumentoMusical instrumentomusical)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instrumentomusical).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoInstrumento_Id = new SelectList(db.TipoInstrumento, "Id", "Descripcion", instrumentomusical.TipoInstrumento_Id);
            return View(instrumentomusical);
        }

        //
        // GET: /InstrumentoMusical/Delete/5

        public ActionResult Delete(int id = 0)
        {
            InstrumentoMusical instrumentomusical = db.InstrumentoMusical.Find(id);
            if (instrumentomusical == null)
            {
                return HttpNotFound();
            }
            return View(instrumentomusical);
        }

        //
        // POST: /InstrumentoMusical/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            InstrumentoMusical instrumentomusical = db.InstrumentoMusical.Find(id);
            db.InstrumentoMusical.Remove(instrumentomusical);
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