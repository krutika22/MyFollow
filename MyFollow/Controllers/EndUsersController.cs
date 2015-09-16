using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFollow.DAL;
using MyFollow.Models;

namespace MyFollow.Controllers
{
    public class EndUsersController : Controller
    {
        private UserContext db = new UserContext();

        // GET: EndUsers
        public ActionResult Index()
        {
            return View(db.EndUsers.ToList());
        }

        // GET: EndUsers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndUsers endUsers = db.EndUsers.Find(id);
            if (endUsers == null)
            {
                return HttpNotFound();
            }
            return View(endUsers);
        }

        // GET: EndUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EndUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email,DateOfJoining,Gender,DateOfBirth,Address,ContactNumber")] EndUsers endUsers)
        {
            if (ModelState.IsValid)
            {
                db.EndUsers.Add(endUsers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(endUsers);
        }

        // GET: EndUsers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndUsers endUsers = db.EndUsers.Find(id);
            if (endUsers == null)
            {
                return HttpNotFound();
            }
            return View(endUsers);
        }

        // POST: EndUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Email,DateOfJoining,Gender,DateOfBirth,Address,ContactNumber")] EndUsers endUsers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endUsers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(endUsers);
        }

        // GET: EndUsers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndUsers endUsers = db.EndUsers.Find(id);
            if (endUsers == null)
            {
                return HttpNotFound();
            }
            return View(endUsers);
        }

        // POST: EndUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EndUsers endUsers = db.EndUsers.Find(id);
            db.EndUsers.Remove(endUsers);
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
