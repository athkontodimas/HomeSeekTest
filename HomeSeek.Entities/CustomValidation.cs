using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeSeek.Entities
{
    public class Validations
    {

        public static ValidationResult GreaterThanZero(int value, ValidationContext validationContext)
        {
           
            if (value > 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                //return new ValidationResult(errorMessage: "Value should be greater than 0!");
               return new ValidationResult(string.Format("The field {0} must be greater than zero", validationContext.MemberName), new List<string> { validationContext.MemberName });
            }
        }

        public static ValidationResult MaxWords(string value, ValidationContext validationContext)
        {

            
            int wordCount = value.Split(' ').Length;
            if (wordCount <= 1500)
            {
                return ValidationResult.Success;
            }
            else
            {
                //return new ValidationResult(errorMessage: "Value should be greater than 0!");
                return new ValidationResult(string.Format("Comments should contain 150 or less words"), new List<string> { validationContext.MemberName });
            }
        }

    }
}
