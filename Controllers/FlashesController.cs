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
    public class FlashesController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: Flashes
        public ActionResult Index()
        {
            return View(db.Flashes.ToList());
        }

        // GET: Flashes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flash flash = db.Flashes.Find(id);
            if (flash == null)
            {
                return HttpNotFound();
            }
            return View(flash);
        }

        // GET: Flashes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flashes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Make,Model,ShutterSpeed,PowerReq,Dimensions,Weight,Finish,Brightness")] Flash flash)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(flash);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flash);
        }

        // GET: Flashes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flash flash = db.Flashes.Find(id);
            if (flash == null)
            {
                return HttpNotFound();
            }
            return View(flash);
        }

        // POST: Flashes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Make,Model,ShutterSpeed,PowerReq,Dimensions,Weight,Finish,Brightness")] Flash flash)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flash).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flash);
        }

        // GET: Flashes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flash flash = db.Flashes.Find(id);
            if (flash == null)
            {
                return HttpNotFound();
            }
            return View(flash);
        }

        // POST: Flashes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Flash flash = db.Flashes.Find(id);
            db.Items.Remove(flash);
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
