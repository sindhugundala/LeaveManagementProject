using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementProject.Models
{
    public class Signin
    {
        [Required(ErrorMessage ="Please enter the UserName")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please enter Passwor")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


    }
}