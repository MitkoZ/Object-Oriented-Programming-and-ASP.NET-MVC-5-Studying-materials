using MVCHashPasswordAndCustomValidator.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHashPasswordAndCustomValidator.Models
{
    public class RegistrationViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
      //  [DataType(DataType.Password)]
        [CustomPassword]
        public string Password { get; set; }

        [Required]
       // [DataType(DataType.Password)]
        [CustomPassword]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}