using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVCEXAM201707_1.Models
{
    public class UsernameAttribute : ValidationAttribute
    {
       
        // Methods
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string username = (string)value;
            

            if (username.Contains("skilltree") == true || username.Contains("twMVC") == true || username.Contains("demo") == true)
            {
                // invalid
                var errorMsg = "This word cant be username";
                return new ValidationResult(errorMsg);
            }
            else
            {
                // valid
                return ValidationResult.Success;
               
            }
        }
    }
}