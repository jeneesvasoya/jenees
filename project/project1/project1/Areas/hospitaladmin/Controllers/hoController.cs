using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project1.EDM;

namespace project1.Areas.hospitaladmin.Controllers
{
    public class hoController : Controller
    {
        // GET: hospitaladmin/ho
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
        public ActionResult Login(FormCollection fc)
        {
            string email = fc["email"];
            string pass = fc["password"];

            var hoadminobj = d1.Hospitals.Where(a => a.h_email == email && a.h_password == pass).FirstOrDefault();

            if (hoadminobj != null)
            {
                Session["hoadmin"] = hoadminobj.h_name;
                Session["hoadminID"] = hoadminobj.hospital_id;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.loginer = "Invalid EmailID or Password.!";
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult Managehospital()
        {
            return View(d1.Hospitals.ToList());
        }
        void fillstate()
        {
            var states = from s in d1.States
                         select new SelectListItem { Value = s.state_id.ToString(), Text = s.state_name };
            ViewBag.states = states.ToList();
        }
        public JsonResult Getcitybystateid(int id)
        {
            d1.Configuration.ProxyCreationEnabled = false;
            var cities = d1.Cities.Where(c => c.state_id == id).ToList();
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Addhospital()
        {
            fillstate();
            return View();
        }
        [HttpPost]
        public ActionResult Addhospital(Hospital obj, HttpPostedFileBase h_profile_image)
        {
            if (h_profile_image != null)
            {
                string filename = Path.GetFileName(h_profile_image.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs/Hospitals"), filename);
                h_profile_image.SaveAs(fullpath);
                obj.h_profile_image = filename;
            }
            d1.Hospitals.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("Managehospital");
        }
        [HttpGet]
        public ActionResult HospitalEdit(int id)
        {
            fillstate();
            return View(d1.Hospitals.Find(id));
        }
        [HttpPost]
        public ActionResult HospitalEdit(Hospital obj, HttpPostedFileBase h_profile_image)
        {
            if (h_profile_image != null)
            {
                string filename = Path.GetFileName(h_profile_image.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs/Hospitals"), filename);
                h_profile_image.SaveAs(fullpath);
                obj.h_profile_image = filename;
            }
            d1.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            d1.SaveChanges();
            return RedirectToAction("Managehospital");
        }
        [HttpGet]
        public ActionResult HospitalDelete(int id)
        {
            return View(d1.Hospitals.Find(id));
        }
        [HttpPost]
        [ActionName("HospitalDelete")]
        public ActionResult HospitalDeleteRe(int id)
        {
            d1.Hospitals.Remove(d1.Hospitals.Find(id));
            d1.SaveChanges();
            return RedirectToAction("Managehospital");
        }
        public ActionResult ManageDoc()
        {
            return View(d1.Doctors.ToList());
        }
        void fillhospital()
        {
            var hospital = from h in d1.Hospitals
                           select new SelectListItem { Value = h.hospital_id.ToString(), Text = h.h_name };
            ViewBag.hospital = hospital.ToList();
        }
        void filldegree()
        {
            var degree = from d in d1.Degrees
                         select new SelectListItem { Value = d.Degree_id.ToString(), Text = d.Degree_name };
            ViewBag.degree = degree.ToList();
        }
        void fillspeciality()
        {
            var speciality = from d in d1.specialities
                             select new SelectListItem { Value = d.speciality_id.ToString(), Text = d.speciality_name };
            ViewBag.speciality = speciality.ToList();
        }
        [HttpGet]
        public ActionResult AddDoc()
        {
            fillhospital();
            filldegree();
            fillspeciality();
            return View();
        }
        [HttpPost]
        public ActionResult AddDoc(Doctor obj, HttpPostedFileBase d_profile_image)
        {
            if (d_profile_image != null)
            {
                string filename = Path.GetFileName(d_profile_image.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs/doctors"), filename);
                d_profile_image.SaveAs(fullpath);
                obj.d_profile_image = filename;
            }

            d1.Doctors.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("ManageDoc");
        }
        public ActionResult DocEdit(int id)
        {
            fillhospital();
            filldegree();
            fillspeciality();
            return View(d1.Doctors.Find(id));
        }
        [HttpPost]
        public ActionResult DocEdit(Doctor obj, HttpPostedFileBase d_profile_image)
        {
            if (d_profile_image != null)
            {
                string filename = Path.GetFileName(d_profile_image.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs/doctors"), filename);
                d_profile_image.SaveAs(fullpath);
                obj.d_profile_image = filename;
            }
            d1.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            d1.SaveChanges();
            return RedirectToAction("ManageDoc");
        }
        [HttpGet]
        public ActionResult DocDelete(int id)
        { 
            return View(d1.Doctors.Find(id));
        }
        [HttpPost]
        [ActionName("DocDelete")]
        public ActionResult DocDeleteRec(int id)
        {
            d1.Doctors.Remove(d1.Doctors.Find(id));
            d1.SaveChanges();
            return RedirectToAction("ManageDoc");
        }
        public ActionResult ManageAppointment()
        {
            return View(d1.Appointments.ToList());
        }
        void fillstatus()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Value = "Confirm", Text = "Confirm" });
            li.Add(new SelectListItem { Value = "Cancel", Text = "Cancel" });
            li.Add(new SelectListItem { Value = "pending", Text = "pending.." });

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
        public ActionResult AddApp()
        {
            fillpatient();
            fillstatus();
            fillhospital();
            return View();
        }
        [HttpPost]
        public ActionResult AddApp(Appointment obj)
        {
            d1.Appointments.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("ManageAppointment");
        }
          
        [HttpGet]
        public ActionResult AppoEdit(int id)
        {
            fillpatient();
            fillstatus();
            fillhospital();
            return View(d1.Appointments.Find(id));
        }
        [HttpPost]
        public ActionResult AppoEdit(Appointment obj)
        {
            d1.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            d1.SaveChanges();
            return RedirectToAction("ManageAppointment");
        }
        [HttpGet]
        public ActionResult AppoDelete(int id)
        {
            return View(d1.Appointments.Find(id));
        }
        [HttpPost]
        [ActionName("AppoDelete")]
        public ActionResult AppoDeleteRec(int id)
        {
            d1.Appointments.Remove(d1.Appointments.Find(id));
            d1.SaveChanges();
            return RedirectToAction("ManageAppointment");
        }
    }
}