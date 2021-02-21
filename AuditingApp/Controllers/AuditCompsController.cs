using System;
using System.Web.Mvc;
using AuditingApp.Models;

namespace AuditingApp.Controllers
{
    public class AuditCompsController : Controller
    {
        public ActionResult Index()
        {
            throw new System.NotImplementedException();
        }

        public ActionResult AuditCompInfoView()
        {
           
            return View();
        }

        public ActionResult PersonView()
        {
            var person = new Person();

            return View(person);
        }
    }
}