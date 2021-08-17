using Hastane.Yonetimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hastane.Yonetimi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PatientBuisness()
        {
            return View();


        }
        public ActionResult PatientInformation()
        {
            return View();


        }

        public ActionResult PatientAcceptance()
        {
            return View();


        }
        

        public JsonResult PatientAcceptanceControl(PatientRegistrationProduct patientRegistration)
        {

            // return Json(patientAcceptance.FirstName, JsonRequestBehavior.AllowGet);
            return Json(null, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult PatientAcceptanceControl(PatientAcceptanceProduct patientAcceptance)
        {
            
           // return Json(patientAcceptance.FirstName, JsonRequestBehavior.AllowGet);
           return Json(null,JsonRequestBehavior.AllowGet);

        }
        
        public JsonResult SelectKey(string selectKey)
        {
            SelectDockerProduct a = new SelectDockerProduct();
            a.Name = selectKey;


            
            return Json(a, JsonRequestBehavior.AllowGet);


        }


         
        public JsonResult isim(string a)
        {




            return Json(a, JsonRequestBehavior.AllowGet);


        }
    }
}