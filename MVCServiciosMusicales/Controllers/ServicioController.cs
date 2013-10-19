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
    public class ServicioController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Servicio/

        public ActionResult Index()
        {
            var servicio = db.Servicio.Include(s => s.Estado).Include(s => s.Instrucciones).Include(s => s.InstrumentoMusical).Include(s => s.Piezas).Include(s => s.Tecnico).Include(s => s.TipoServicio);
            return View(servicio.ToList());
        }

        //
        // GET: /Servicio/Details/5

        public ActionResult Details(int id = 0)
        {
            Servicio servicio = db.Servicio.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        //
        // GET: /Servicio/Create

        public ActionResult Create()
        {
            ViewBag.Estado_Id = new SelectList(db.Estado, "Id", "Descripcion");
            ViewBag.Instrucciones_Id = new SelectList(db.Instrucciones, "Id", "Descripcion");
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre");
            ViewBag.Piezas_Id = new SelectList(db.Piezas, "Id", "Descripcion");
            ViewBag.Tecnico_Id = new SelectList(db.Tecnico, "Id", "Nombre");
            ViewBag.TipoServicio_Id = new SelectList(db.TipoServicio, "Id", "Descripcion");
            return View();
        }

        //
        // POST: /Servicio/Create

        [HttpPost]
        public ActionResult Create(Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                db.Servicio.Add(servicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Estado_Id = new SelectList(db.Estado, "Id", "Descripcion", servicio.Estado_Id);
            ViewBag.Instrucciones_Id = new SelectList(db.Instrucciones, "Id", "Descripcion", servicio.Instrucciones_Id);
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre", servicio.InstrumentoMusical_Id);
            ViewBag.Piezas_Id = new SelectList(db.Piezas, "Id", "Descripcion", servicio.Piezas_Id);
            ViewBag.Tecnico_Id = new SelectList(db.Tecnico, "Id", "Nombre", servicio.Tecnico_Id);
            ViewBag.TipoServicio_Id = new SelectList(db.TipoServicio, "Id", "Descripcion", servicio.TipoServicio_Id);
            return View(servicio);
        }

        //
        // GET: /Servicio/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Servicio servicio = db.Servicio.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            ViewBag.Estado_Id = new SelectList(db.Estado, "Id", "Descripcion", servicio.Estado_Id);
            ViewBag.Instrucciones_Id = new SelectList(db.Instrucciones, "Id", "Descripcion", servicio.Instrucciones_Id);
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre", servicio.InstrumentoMusical_Id);
            ViewBag.Piezas_Id = new SelectList(db.Piezas, "Id", "Descripcion", servicio.Piezas_Id);
            ViewBag.Tecnico_Id = new SelectList(db.Tecnico, "Id", "Nombre", servicio.Tecnico_Id);
            ViewBag.TipoServicio_Id = new SelectList(db.TipoServicio, "Id", "Descripcion", servicio.TipoServicio_Id);
            return View(servicio);
        }

        //
        // POST: /Servicio/Edit/5

        [HttpPost]
        public ActionResult Edit(Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Estado_Id = new SelectList(db.Estado, "Id", "Descripcion", servicio.Estado_Id);
            ViewBag.Instrucciones_Id = new SelectList(db.Instrucciones, "Id", "Descripcion", servicio.Instrucciones_Id);
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre", servicio.InstrumentoMusical_Id);
            ViewBag.Piezas_Id = new SelectList(db.Piezas, "Id", "Descripcion", servicio.Piezas_Id);
            ViewBag.Tecnico_Id = new SelectList(db.Tecnico, "Id", "Nombre", servicio.Tecnico_Id);
            ViewBag.TipoServicio_Id = new SelectList(db.TipoServicio, "Id", "Descripcion", servicio.TipoServicio_Id);
            return View(servicio);
        }

        //
        // GET: /Servicio/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Servicio servicio = db.Servicio.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        //
        // POST: /Servicio/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Servicio servicio = db.Servicio.Find(id);
            db.Servicio.Remove(servicio);
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