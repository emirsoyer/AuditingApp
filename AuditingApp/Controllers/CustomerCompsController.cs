using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AuditingApp.DAL;
using AuditingApp.Models;

namespace AuditingApp.Controllers
{
    public class CustomerCompsController : Controller
    {
        private AuditAppContext db = new AuditAppContext();

        // GET: CustomerComps
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: CustomerComps/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerComp customerComp = db.Customers.Find(id);
            if (customerComp == null)
            {
                return HttpNotFound();
            }
            return View(customerComp);
        }

        // GET: CustomerComps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerComps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerId,CustomerName,CustomerType,CustomerTypeId,Consolidation,CustomerDescription,OrganizationMembership,ObligatedCapital,PaidCapital,TaxNumber,TaxOffice,EstablishmentDate,ActivityCode,RegistryCode,LegalNature,TradeRegistryNumber,OrganizationMembershipNumber,MersisId")] CustomerComp customerComp)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customerComp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerComp);
        }

        // GET: CustomerComps/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerComp customerComp = db.Customers.Find(id);
            if (customerComp == null)
            {
                return HttpNotFound();
            }
            return View(customerComp);
        }

        // POST: CustomerComps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,CustomerName,CustomerType,CustomerTypeId,Consolidation,CustomerDescription,OrganizationMembership,ObligatedCapital,PaidCapital,TaxNumber,TaxOffice,EstablishmentDate,ActivityCode,RegistryCode,LegalNature,TradeRegistryNumber,OrganizationMembershipNumber,MersisId")] CustomerComp customerComp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerComp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerComp);
        }

        // GET: CustomerComps/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerComp customerComp = db.Customers.Find(id);
            if (customerComp == null)
            {
                return HttpNotFound();
            }
            return View(customerComp);
        }

        // POST: CustomerComps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CustomerComp customerComp = db.Customers.Find(id);
            db.Customers.Remove(customerComp);
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
