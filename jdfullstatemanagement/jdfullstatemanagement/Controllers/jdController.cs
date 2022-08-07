using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jdfullstatemanagement.Controllers
{
    public class jdController : Controller
    {
        // GET: jd
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string uname = fc["txtuser"];
            string pass = fc["txtpass"];

            if (uname=="jems" && pass=="j972")
            {
                HttpCookie couser = new HttpCookie("username");
                couser.Expires = DateTime.Now.AddDays(2);
                couser.Value = uname;
                Response.Cookies.Add(couser);

                HttpCookie copass = new HttpCookie("password");
                copass.Expires = DateTime.Now.AddDays(2);
                copass.Value = pass;
                Response.Cookies.Add(copass);
            }
            return View();
        }
        public ActionResult QueryString()
        {
            return View();
        }
        public ActionResult GetQ(string fname,string mobile)
        {
            ViewBag.fname = fname;
            ViewBag.mobile = mobile;
            return View();
        }
        //session :time period
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string uname = fc["txtuser"];
            string pass = fc["txtpass"];
            if (uname == "jenees" && pass == "j123")
            {
                Session["username"] = uname;
                Session["password"] = pass;
                Session.Timeout = 30;
                return RedirectToAction("Homepage");
            }
            else
            {
                ViewBag.loginerror = "Invalid username or password.!";
            }

            return View();
        }
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Login");
        }
        public ActionResult svr()
        {
            ViewData["info"] = "writing data from view data";
            ViewBag.msg = "writing data from view bag";
            TempData["data"] = "displaying data from tempdata";
            return View();
        }
        public ActionResult second()
        {
            return View();
        }

    }
}