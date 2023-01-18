using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientRegistration.Models;

namespace PatientRegistration.Controllers
{
    public class PatientProfileController : Controller
    {
        HospitalEntities dbobj = new HospitalEntities();
        // GET: PatientProfile
        public ActionResult UserProfileLoad()
        {
            var getdata = dbobj.sp_profile(Session["name"].ToString()).FirstOrDefault();

            return View(new ProfileClass
            {
                name = getdata.Name,
                address=getdata.Address,
                pin=getdata.Pin,
                aadhar=getdata.Aadhar_no,
                mobile=getdata.Mobile,
                blood=getdata.Blood_group,
                visit_date=getdata.Visit_date,
                purpose=getdata.purpose_of_visit
            });
        }
        public ActionResult Profile_Update(ProfileClass obj)
        {
            dbobj.sp_edit(Session["name"].ToString(), obj.address, obj.pin,obj.mobile,obj.blood);
            obj.msg = "Successfully Updated...";
            return View("UserProfileLoad", obj);
        }

    }
}