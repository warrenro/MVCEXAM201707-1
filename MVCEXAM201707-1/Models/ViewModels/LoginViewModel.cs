using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEXAM201707_1.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Username]
        [Display(Name = "電子郵件")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(10),MinLength(4)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }
    }
}