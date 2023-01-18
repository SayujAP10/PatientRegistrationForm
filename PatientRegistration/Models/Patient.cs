using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientRegistration.Models
{
    public class Patient
    {
        [Required (ErrorMessage ="Enter your Full Name...")]
        public string name { set; get; }
        [Required(ErrorMessage = "Enter your Address...")]
        public string address { set; get; }
        [Required(ErrorMessage = "Enter your Pin Number...")]
        public int pin { set; get; }
        [Required(ErrorMessage = "Enter your Aadhar Number...")]
        public string aadhar { set; get; }
        [Required(ErrorMessage = "Enter your Mobile Number...")]
        public string mobile { set; get; }
        [Required(ErrorMessage = "Enter your Blood Group...")]
        public string blood { set; get; }
        public DateTime date { set; get; }
        public  string purpose { set; get; }
        public string msg { set; get; }


    }
}