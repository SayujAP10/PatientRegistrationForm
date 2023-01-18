using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientRegistration.Models
{
    public class LoginClass
    {
        [Required(ErrorMessage = "Enter the name")]
        public string name { set; get; }

        [Required(ErrorMessage = "Enter the aadharno")]
        public string aadharno { set; get; }

        public string Msg { set; get; }
    }
}