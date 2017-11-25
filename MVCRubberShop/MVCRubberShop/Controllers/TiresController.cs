using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCRubberShop.Models;

namespace MVCRubberShop.Controllers
{
    public class TiresController : Controller
    {
        private TiresDBContext db = new TiresDBContext();

        // GET: Tires
        public ActionResult Index()
        {
            return View(db.Round.ToList());
        }

        // GET: Tires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tires tires = db.Round.Find(id);
            if (tires == null)
            {
                return HttpNotFound();
            }
            return View(tires);
        }

        // GET: Tires/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Front()
        {
            return View();

        }



        // POST: Tires/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TiresID,TireWidth,Sidewall,RimDiameter,MSRP,Manufacturer")] Tires tires)
        {
            if (ModelState.IsValid)
            {
                db.Round.Add(tires);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tires);
        }

        // GET: Tires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tires tires = db.Round.Find(id);
            if (tires == null)
            {
                return HttpNotFound();
            }
            return View(tires);
        }

        // POST: Tires/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TiresID,TireWidth,Sidewall,RimDiameter,MSRP,Manufacturer")] Tires tires)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tires).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tires);
        }

        // GET: Tires/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tires tires = db.Round.Find(id);
            if (tires == null)
            {
                return HttpNotFound();
            }
            return View(tires);
        }

        // POST: Tires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tires tires = db.Round.Find(id);
            db.Round.Remove(tires);
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

        public ActionResult Show()
        {

            return View(db.Round.ToList());
        }





    }
}
