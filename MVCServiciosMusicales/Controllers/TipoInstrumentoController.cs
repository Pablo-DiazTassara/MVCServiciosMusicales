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
    public class TipoInstrumentoController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /TipoInstrumento/

        public ActionResult Index()
        {
            return View(db.TipoInstrumento.ToList());
        }

        //
        // GET: /TipoInstrumento/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoInstrumento tipoinstrumento = db.TipoInstrumento.Find(id);
            if (tipoinstrumento == null)
            {
                return HttpNotFound();
            }
            return View(tipoinstrumento);
        }

        //
        // GET: /TipoInstrumento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoInstrumento/Create

        [HttpPost]
        public ActionResult Create(TipoInstrumento tipoinstrumento)
        {
            if (ModelState.IsValid)
            {
                db.TipoInstrumento.Add(tipoinstrumento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoinstrumento);
        }

        //
        // GET: /TipoInstrumento/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoInstrumento tipoinstrumento = db.TipoInstrumento.Find(id);
            if (tipoinstrumento == null)
            {
                return HttpNotFound();
            }
            return View(tipoinstrumento);
        }

        //
        // POST: /TipoInstrumento/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoInstrumento tipoinstrumento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoinstrumento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoinstrumento);
        }

        //
        // GET: /TipoInstrumento/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoInstrumento tipoinstrumento = db.TipoInstrumento.Find(id);
            if (tipoinstrumento == null)
            {
                return HttpNotFound();
            }
            return View(tipoinstrumento);
        }

        //
        // POST: /TipoInstrumento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoInstrumento tipoinstrumento = db.TipoInstrumento.Find(id);
            db.TipoInstrumento.Remove(tipoinstrumento);
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