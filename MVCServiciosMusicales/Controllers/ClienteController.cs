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
    public class ClienteController : Controller
    {
        private ServiciosMusicalesEntities db = new ServiciosMusicalesEntities();

        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            var cliente = db.Cliente.Include(c => c.Direccion).Include(c => c.InstrumentoMusical).Include(c => c.TipoCliente);
            return View(cliente.ToList());
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id = 0)
        {
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            ViewBag.Direccion_Id = new SelectList(db.Direccion, "Id", "Calle");
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre");
            ViewBag.TipoCliente_Id = new SelectList(db.TipoCliente, "Id", "Descripcion");
            return View();
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Direccion_Id = new SelectList(db.Direccion, "Id", "Calle", cliente.Direccion_Id);
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre", cliente.InstrumentoMusical_Id);
            ViewBag.TipoCliente_Id = new SelectList(db.TipoCliente, "Id", "Descripcion", cliente.TipoCliente_Id);
            return View(cliente);
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.Direccion_Id = new SelectList(db.Direccion, "Id", "Calle", cliente.Direccion_Id);
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre", cliente.InstrumentoMusical_Id);
            ViewBag.TipoCliente_Id = new SelectList(db.TipoCliente, "Id", "Descripcion", cliente.TipoCliente_Id);
            return View(cliente);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Direccion_Id = new SelectList(db.Direccion, "Id", "Calle", cliente.Direccion_Id);
            ViewBag.InstrumentoMusical_Id = new SelectList(db.InstrumentoMusical, "Id", "Nombre", cliente.InstrumentoMusical_Id);
            ViewBag.TipoCliente_Id = new SelectList(db.TipoCliente, "Id", "Descripcion", cliente.TipoCliente_Id);
            return View(cliente);
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Cliente.Find(id);
            db.Cliente.Remove(cliente);
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