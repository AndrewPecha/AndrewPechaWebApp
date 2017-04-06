using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AndrewPechaWebApp.Models;

namespace AndrewPechaWebApp.Controllers
{
    public class TestSQLitesController : Controller
    {
        private TESTSQLiteContext db = new TESTSQLiteContext();

        // GET: TestSQLites
        public ActionResult Index()
        {
            return View(db.TestStuff.ToList());
        }

        // GET: TestSQLites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestSQLite testSQLite = db.TestStuff.Find(id);
            if (testSQLite == null)
            {
                return HttpNotFound();
            }
            return View(testSQLite);
        }

        // GET: TestSQLites/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestSQLites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,number,word")] TestSQLite testSQLite)
        {
            if (ModelState.IsValid)
            {
                db.TestStuff.Add(testSQLite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testSQLite);
        }

        // GET: TestSQLites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestSQLite testSQLite = db.TestStuff.Find(id);
            if (testSQLite == null)
            {
                return HttpNotFound();
            }
            return View(testSQLite);
        }

        // POST: TestSQLites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,number,word")] TestSQLite testSQLite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testSQLite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testSQLite);
        }

        // GET: TestSQLites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestSQLite testSQLite = db.TestStuff.Find(id);
            if (testSQLite == null)
            {
                return HttpNotFound();
            }
            return View(testSQLite);
        }

        // POST: TestSQLites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestSQLite testSQLite = db.TestStuff.Find(id);
            db.TestStuff.Remove(testSQLite);
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
