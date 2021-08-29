using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Attributes
{
    public class DayForBasicAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                Product product = (Product)value;
                if (DateAttribute.chooseDate.DayOfWeek == DayOfWeek.Monday && product == Product.Basic)
                {
                    ErrorMessage = "Консультация по продукту «Основы» не может проходить по понедельникам";
                   
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
