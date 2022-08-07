using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project1.EDM;
using project1.Models;

namespace project1.Areas.admin.Controllers
{

    public class jdController : Controller
    {
        // GET: admin/jd
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

            var adminobj = d1.Admins.Where(a => a.email_id == email && a.password == pass).FirstOrDefault();

            if (adminobj != null)
            {
                Session["admin"] = adminobj.f_name;
                Session["adminID"] = adminobj.Admin_id;
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
            return RedirectToAction("Login");
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
        public ActionResult ManageDoctor()
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

        public ActionResult AddDoctor()
        {
            fillspeciality();
            filldegree();
            fillhospital();
            return View();
        }
        [HttpPost]
        public ActionResult AddDoctor(Doctor obj)
        {
            d1.Doctors.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("ManageDoctor");
        }
        [HttpGet]
        public ActionResult DoctorEdit(int id)
        {
            fillspeciality();
            filldegree();
            fillhospital();
            return View(d1.Doctors.Find(id));
        }
        [HttpPost]
        public ActionResult DoctorEdit(Doctor obj)
        {
            d1.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            d1.SaveChanges();
            return RedirectToAction("ManageDoctor");
        }
        [HttpGet]
        public ActionResult DoctorDelete(int id)
        {
            return View(d1.Doctors.Find(id));
        }
        [HttpPost]
        [ActionName("DoctorDelete")]
        public ActionResult DoctorDeleteRec(int id)
        {
            d1.Doctors.Remove(d1.Doctors.Find(id));
            d1.SaveChanges();
            return RedirectToAction("ManageDoctor");
        }
        public ActionResult ManageUser()
        {
            return View(d1.Patients.ToList());
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            fillstate();
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(Patient obj, HttpPostedFileBase p_profile_image)
        {
            if (p_profile_image != null)
            {
                string filename = Path.GetFileName(p_profile_image.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs"), filename);
                p_profile_image.SaveAs(fullpath);
                obj.p_profile_image = filename;

            }
            d1.Patients.Add(obj);
            d1.SaveChanges();
            return RedirectToAction("ManageUser");

        }
        [HttpGet]
        public ActionResult UserEdit(int id)
        {
            fillstate();
            return View(d1.Patients.Find(id));
        }
        [HttpPost]
        public ActionResult UserEdit(Patient obj, HttpPostedFileBase p_profile_image)
        {
            if (p_profile_image != null)
            {
                string filename = Path.GetFileName(p_profile_image.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs/Hospitals"), filename);
                p_profile_image.SaveAs(fullpath);
                obj.p_profile_image = filename;

            }
            d1.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            d1.SaveChanges();
            return RedirectToAction("ManageUser");
        }
        [HttpGet]
        public ActionResult UserDelete(int id)
        {
            return View(d1.Patients.Find(id));
        }
        [HttpPost]
        [ActionName("UserDelete")]
        public ActionResult UserDeleteRec(int id)
        {
            d1.Patients.Remove(d1.Patients.Find(id));
            d1.SaveChanges();
            return RedirectToAction("ManageUser");
        }
        public ActionResult ManageAppointment()
        {
            return View(d1.Appointments.ToList());
        }
        //void filldoctor()
        //{
        //    var doctor = from d in d1.Doctors
        //                 select new SelectListItem { Value = d.doctor_id.ToString(), Text = d.df_name };
        //    ViewBag.doctor = doctor.ToList();
        //}
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
        public ActionResult AddAppointment()
        {
            fillpatient();
            fillstatus();
            fillhospital();
            return View();
        }
        [HttpPost]
        public ActionResult AddAppointment(Appointment obj)
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