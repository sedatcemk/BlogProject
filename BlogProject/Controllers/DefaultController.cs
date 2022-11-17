using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogProject.Models.Class;
using BlogProject.Models.Entity;

namespace BlogProject.Controllers
{
    public class DefaultController : Controller
    {
        BlogDbEntities db = new BlogDbEntities();
        // GET: Default
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Value1 = db.TBL_About.ToList();
            cs.Value2 = db.TBL_Contact.ToList();
            var values = db.TBL_About.ToList();
            return View(cs);
        }
    }
}