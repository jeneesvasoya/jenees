using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project1.EDM;

namespace project1.Areas.users.Controllers
{
    public class jdController : Controller
    {
        // GET: users/jd
        DoctorFinderEntities1 d1 = new DoctorFinderEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public string Login(string email, string password)
        {
            //string email = fc["email"];
            //string pass = fc["password"];

            var userobj = d1.Patients.Where(u => u.p_email == email && u.p_password == password).FirstOrDefault();
            if (userobj!=null)
            {
                Session["username"] = userobj.pf_name;
                Session["userid"] = userobj.patient_id;
                return "1";
            }
            else
            {
                //ViewBag.loginerror = "Invalid EmailId Or Password..!";
                return "0";
            }

            //return "Login Error..";
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index");
        }
        void fillstate()
        {
            List<SelectListItem> li = new List<SelectListItem>();

            var states = d1.States.ToList();
            foreach (var item in states)
            {
                li.Add(new SelectListItem { Value = item.state_id.ToString(), Text = item.state_name });
            }
            ViewBag.state = li;
        }
        public JsonResult Getcitybystateid(int id)
        {
            d1.Configuration.ProxyCreationEnabled = false;
            var cities = d1.Cities.Where(c => c.state_id == id).ToList();
            return Json(cities,JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Register()
        {
            fillstate();
            return View();
        }
        [HttpPost]
        public ActionResult Register(Patient obj,HttpPostedFileBase p_profile_image)
        {
            if (p_profile_image!=null)
            {
                string filename = Path.GetFileName(p_profile_image.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs"),filename);
                p_profile_image.SaveAs(fullpath);
                obj.p_profile_image = filename;

            }
            d1.Patients.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("Index");
        }
        void fillhospital()
        {
            var hospital = from h in d1.Hospitals
                           select new SelectListItem { Value = h.hospital_id.ToString(), Text = h.h_name };
            ViewBag.hospital = hospital.ToList();
        }
        void fillstatus()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            
            li.Add(new SelectListItem { Value = "Pending", Text = "Pending" });

            ViewBag.status = li;
        }
        void fillpatient()
        {
            var patients = from p in d1.Patients
                           select new SelectListItem { Value = p.patient_id.ToString(), Text = p.pf_name };
            ViewBag.patient = patients.ToList();
        }

        public JsonResult Getdoctorbyhospitalid(int id)
        {
            d1.Configuration.ProxyCreationEnabled = false;
            var doctor = d1.Doctors.Where(d => d.hospital_id == id).ToList();
            return Json(doctor, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddAppointment()
        {
            fillstatus();
            fillhospital();
            ViewBag.user = Session["username"].ToString();

            return View();
        }
        [HttpPost]
        public ActionResult AddAppointment(Appointment obj)
        {
            obj.appointment_status = "Pending";
            obj.patient_id= Convert.ToInt32(Session["userid"]);
            d1.Appointments.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("Success");
        }
        public ActionResult FindDoc()
        {
            return View(d1.Doctors.ToList());
        }
        [HttpPost]
        public ActionResult FindDoc(int docid, int hosid)
        {
            Session["docname"] = d1.Doctors.Find(docid).df_name;
            Session["docid"] = d1.Doctors.Find(docid).doctor_id;

            Session["hosname"] = d1.Hospitals.Find(hosid).h_name;
            Session["hosid"] = d1.Hospitals.Find(hosid).hospital_id;
            //TempData["user"] = Session["username"].ToString();
            //TempData["userid"] = Session["userid"].ToString();

            return RedirectToAction("Appo");
        }
        public ActionResult Appo()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Appo(Appointment obj)
        {
            obj.appointment_status = "Pending";
            d1.Appointments.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("Success");
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult ManageAppointment()
        {
            int userid = Convert.ToInt32(Session["userid"]);
            return View(d1.Appointments.Where(a=>a.patient_id==userid).ToList());
        }
        public ActionResult appoDelete(int id)
        {
            return View(d1.Appointments.Find(id));
        }
        [HttpPost]
        [ActionName("appoDelete")]
        public ActionResult appoDeleteRe(int id)
        {
            d1.Appointments.Remove(d1.Appointments.Find(id));
            d1.SaveChanges();
            return RedirectToAction("ManageAppointment");
        }
        public ActionResult FindHos()
        {
            return View(d1.Hospitals.ToList());
        }
        [HttpPost]
        public ActionResult FindHos(int hosid)
        {
            Session["hosname"] = d1.Hospitals.Find(hosid).h_name;
            Session["hosid"] = d1.Hospitals.Find(hosid).hospital_id;

            return View(d1.Hospitals.ToList());
        }
        public ActionResult Appo1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Appo1(Appointment obj)
        {
            obj.appointment_status = "Pending";
            d1.Appointments.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("Success");
        }
        public JsonResult FindDoctoHospitalid(int id)
        {
            d1.Configuration.ProxyCreationEnabled = false;
            var doctors = d1.Doctors.Where(d => d.hospital_id == id).ToList();
            return Json(doctors, JsonRequestBehavior.AllowGet);
        }
        public string Delete(int id)
        {
            d1.Appointments.Remove(d1.Appointments.Find(id));
            d1.SaveChanges();
            return "Delete Success";
        }
    }
}