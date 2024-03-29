﻿using System;
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
    public class AuditCompsController : Controller
    {
        private AuditAppContext db = new AuditAppContext();

        // GET: AuditComps
        public ActionResult Index()
        {
            return View(db.AuditComps.ToList());
        }

        // GET: AuditComps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuditComp auditComp = db.AuditComps.Find(id);
            if (auditComp == null)
            {
                return HttpNotFound();
            }
            return View(auditComp);
        }

        // GET: AuditComps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuditComps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AuditCompId,AuditCompName,AdminStatus,OrganizationMembership,OrganizationMembershipNumber,TaxNumber,TaxOffice,EstablishmentDate,TradeRegistryNumber,MersisId")] AuditComp auditComp)
        {
            if (ModelState.IsValid)
            {
                db.AuditComps.Add(auditComp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auditComp);
        }

        // GET: AuditComps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuditComp auditComp = db.AuditComps.Find(id);
            if (auditComp == null)
            {
                return HttpNotFound();
            }
            return View(auditComp);
        }

        // POST: AuditComps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AuditCompId,AuditCompName,AdminStatus,OrganizationMembership,OrganizationMembershipNumber,TaxNumber,TaxOffice,EstablishmentDate,TradeRegistryNumber,MersisId")] AuditComp auditComp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auditComp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auditComp);
        }

        // GET: AuditComps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuditComp auditComp = db.AuditComps.Find(id);
            if (auditComp == null)
            {
                return HttpNotFound();
            }
            return View(auditComp);
        }

        // POST: AuditComps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AuditComp auditComp = db.AuditComps.Find(id);
            db.AuditComps.Remove(auditComp);
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
