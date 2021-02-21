using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuditingApp.DAL;
using AuditingApp.Models;

namespace AuditingApp.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        private AuditAppContext db = new AuditAppContext();
        
        
        public ViewResult AccountsView()
        {
            return View(db.AccountsEnumerable.ToList());
        }
    }

}