using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Intex2.DAL;
using Intex2.Models;

namespace Intex2.Controllers
{
    public class NewRegistersController : Controller
    {
        private IntexContext db = new IntexContext();

        // GET: NewRegisters
        public ActionResult Index()
        {
            return View(db.NewRegisters.ToList());
        }

        // GET: NewRegisters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRegister newRegister = db.NewRegisters.Find(id);
            if (newRegister == null)
            {
                return HttpNotFound();
            }
            return View(newRegister);
        }

        // GET: NewRegisters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewRegisters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "registerId,FirstName,LastName,Company,Phone,Address1,Address2,City,State,Zipcode")] NewRegister newRegister)
        {
            if (ModelState.IsValid)
            {
                db.NewRegisters.Add(newRegister);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newRegister);
        }

        // GET: NewRegisters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRegister newRegister = db.NewRegisters.Find(id);
            if (newRegister == null)
            {
                return HttpNotFound();
            }
            return View(newRegister);
        }

        // POST: NewRegisters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "registerId,FirstName,LastName,Company,Phone,Address1,Address2,City,State,Zipcode")] NewRegister newRegister)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newRegister).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newRegister);
        }

        // GET: NewRegisters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewRegister newRegister = db.NewRegisters.Find(id);
            if (newRegister == null)
            {
                return HttpNotFound();
            }
            return View(newRegister);
        }

        // POST: NewRegisters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewRegister newRegister = db.NewRegisters.Find(id);
            db.NewRegisters.Remove(newRegister);
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
