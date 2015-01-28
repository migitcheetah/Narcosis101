using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Narcosis101.DAL;
using Narcosis101.Models;

namespace Narcosis101.Controllers
{
    public class LensesController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: Lenses
        public ActionResult Index()
        {
            return View(db.Lenses.ToList());
        }

        // GET: Lenses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lense lense = db.Lenses.Find(id);
            if (lense == null)
            {
                return HttpNotFound();
            }
            return View(lense);
        }

        // GET: Lenses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lenses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Make,Model,ShutterSpeed,PowerReq,Dimensions,Weight,Finish,Lens,ExposureMeter,ExposureControl,Millimeters,Fnum,FilterSize")] Lense lense)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(lense);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lense);
        }

        // GET: Lenses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lense lense = db.Lenses.Find(id);
            if (lense == null)
            {
                return HttpNotFound();
            }
            return View(lense);
        }

        // POST: Lenses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Make,Model,ShutterSpeed,PowerReq,Dimensions,Weight,Finish,Lens,ExposureMeter,ExposureControl,Millimeters,Fnum,FilterSize")] Lense lense)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lense).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lense);
        }

        // GET: Lenses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lense lense = db.Lenses.Find(id);
            if (lense == null)
            {
                return HttpNotFound();
            }
            return View(lense);
        }

        // POST: Lenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lense lense = db.Lenses.Find(id);
            db.Items.Remove(lense);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
