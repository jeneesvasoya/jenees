using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajaxcrudopration.EDM;
namespace Ajaxcrudopration.Controllers
{
    public class jdController : Controller
    {
        // GET: jd
        employeedetailsEntities e1 = new employeedetailsEntities();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEmployee()
        {
            e1.Configuration.ProxyCreationEnabled = false;
            return Json(e1.employees.ToList(),JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Create()
        {   
            return View();
        }
        [HttpPost]
        public string Create(employee obj)
        {
            e1.employees.Add(obj);
            e1.SaveChanges();
            return "Record Inserted.";
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(e1.employees.Find(id));
        }
        [HttpPost]
        public string Edit(employee obj)
        {
            e1.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            e1.SaveChanges();
            return "Record Update.";
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(e1.employees.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public string DeleteRec(int id)
        {
            e1.employees.Remove(e1.employees.Find(id));
            e1.SaveChanges();
            return "Record Deleted.";
        }
    }
}