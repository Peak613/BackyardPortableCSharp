using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BackyardPortableCSharp.Models;

namespace BackyardPortableCSharp.Controllers
{
    public class tblUsrLgnsController : Controller
    {
        private Backyard_PortableEntities db = new Backyard_PortableEntities();

        // GET: tblUsrLgns
        public ActionResult Index()
        {
            return View(db.tblUsrLgns.ToList());
        }

        // GET: tblUsrLgns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUsrLgn tblUsrLgn = db.tblUsrLgns.Find(id);
            if (tblUsrLgn == null)
            {
                return HttpNotFound();
            }
            return View(tblUsrLgn);
        }

        // GET: tblUsrLgns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblUsrLgns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsrLgnID,UsrLgn,UsrPwrd,UsrAccssLvl")] tblUsrLgn tblUsrLgn)
        {
            if (ModelState.IsValid)
            {
                db.tblUsrLgns.Add(tblUsrLgn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblUsrLgn);
        }  

        // GET: tblUsrLgns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUsrLgn tblUsrLgn = db.tblUsrLgns.Find(id);
            if (tblUsrLgn == null)
            {
                return HttpNotFound();
            }
            return View(tblUsrLgn);
        }

        // POST: tblUsrLgns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsrLgnID,UsrLgn,UsrPwrd,UsrAccssLvl")] tblUsrLgn tblUsrLgn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblUsrLgn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblUsrLgn);
        }

        // GET: tblUsrLgns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUsrLgn tblUsrLgn = db.tblUsrLgns.Find(id);
            if (tblUsrLgn == null)
            {
                return HttpNotFound();
            }
            return View(tblUsrLgn);
        }

        // POST: tblUsrLgns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblUsrLgn tblUsrLgn = db.tblUsrLgns.Find(id);
            db.tblUsrLgns.Remove(tblUsrLgn);
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
