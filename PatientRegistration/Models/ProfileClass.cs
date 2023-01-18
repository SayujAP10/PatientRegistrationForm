using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientRegistration.Models
{
    public class ProfileClass
    {
        public string name { set; get; }
        public string address { set; get; }
        public int pin { set; get; }
        public string aadhar { set; get; }
        public string mobile { set; get; }
        public string blood { set; get; }
        public DateTime visit_date { set; get; }

        public string purpose { set;  get; }
        public string msg { set; get; }
    }
}