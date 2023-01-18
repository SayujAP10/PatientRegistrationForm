using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientRegistration.Models;

namespace PatientRegistration.Controllers
{
    public class LoginController : Controller
    {
        HospitalEntities dbobj = new HospitalEntities();
        // GET: Login
        public ActionResult LogPageLoad()
        {
            return View();
        }

        public ActionResult Log_Click(LoginClass objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objcls.name, objcls.aadharno,op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    Session["name"] = objcls.name;
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    objcls.Msg = "Invalid Login";
                    return View("LogPageLoad", objcls);
                }
            }
            return View("LogPageLoad", objcls);
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}