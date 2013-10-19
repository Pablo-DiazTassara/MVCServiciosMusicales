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
    public class TecnicoController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Tecnico/

        public ActionResult Index()
        {
            return View(db.Tecnico.ToList());
        }

        //
        // GET: /Tecnico/Details/5

        public ActionResult Details(int id = 0)
        {
            Tecnico tecnico = db.Tecnico.Find(id);
            if (tecnico == null)
            {
                return HttpNotFound();
            }
            return View(tecnico);
        }

        //
        // GET: /Tecnico/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tecnico/Create

        [HttpPost]
        public ActionResult Create(Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                db.Tecnico.Add(tecnico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tecnico);
        }

        //
        // GET: /Tecnico/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Tecnico tecnico = db.Tecnico.Find(id);
            if (tecnico == null)
            {
                return HttpNotFound();
            }
            return View(tecnico);
        }

        //
        // POST: /Tecnico/Edit/5

        [HttpPost]
        public ActionResult Edit(Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tecnico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tecnico);
        }

        //
        // GET: /Tecnico/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Tecnico tecnico = db.Tecnico.Find(id);
            if (tecnico == null)
            {
                return HttpNotFound();
            }
            return View(tecnico);
        }

        //
        // POST: /Tecnico/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Tecnico tecnico = db.Tecnico.Find(id);
            db.Tecnico.Remove(tecnico);
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