using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientRegistration.Models;

namespace PatientRegistration.Controllers
{
    public class DBInsertController : Controller
    {
        HospitalEntities dbobj = new HospitalEntities();
        // GET: DBInsert
        public ActionResult Insert_pageload()
        {
            return View();
        }
        public ActionResult Insert_click(Patient obj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_Insert(obj.name, obj.address, obj.pin, obj.aadhar, obj.mobile, obj.blood, obj.date, obj.purpose);
                obj.msg = "Successfully Inserted...";
                ModelState.Clear();
            }
            return View("Insert_pageload", obj);
        }
    }
}