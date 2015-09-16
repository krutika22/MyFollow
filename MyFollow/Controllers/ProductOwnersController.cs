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
    public class ProductOwnersController : Controller
    {
        private UserContext db = new UserContext();

        // GET: ProductOwners
        public ActionResult Index()
        {
            return View(db.ProductOwners.ToList());
        }

        // GET: ProductOwners/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOwners productOwners = db.ProductOwners.Find(id);
            if (productOwners == null)
            {
                return HttpNotFound();
            }
            return View(productOwners);
        }

        // GET: ProductOwners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductOwners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email,CompanyName,Description,DateOfJoining,FoundedIn,Address,ContactNumber,WebsiteURL,TwitterHandler,FacebookPageURL")] ProductOwners productOwners)
        {
            if (ModelState.IsValid)
            {
                db.ProductOwners.Add(productOwners);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productOwners);
        }

        // GET: ProductOwners/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOwners productOwners = db.ProductOwners.Find(id);
            if (productOwners == null)
            {
                return HttpNotFound();
            }
            return View(productOwners);
        }

        // POST: ProductOwners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Email,CompanyName,Description,DateOfJoining,FoundedIn,Address,ContactNumber,WebsiteURL,TwitterHandler,FacebookPageURL")] ProductOwners productOwners)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productOwners).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productOwners);
        }

        // GET: ProductOwners/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOwners productOwners = db.ProductOwners.Find(id);
            if (productOwners == null)
            {
                return HttpNotFound();
            }
            return View(productOwners);
        }

        // POST: ProductOwners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ProductOwners productOwners = db.ProductOwners.Find(id);
            db.ProductOwners.Remove(productOwners);
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
