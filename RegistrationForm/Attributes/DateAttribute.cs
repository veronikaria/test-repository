using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Attributes
{
    public class DateAttribute : ValidationAttribute
    {
        internal static DateTime chooseDate;

        DateTime begin = DateTime.Now;

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                DateTime dateTime = (DateTime)value;
                chooseDate = dateTime;

                if (dateTime < begin)
                {
                    ErrorMessage = "You can't choose past time";
                    return false;
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    ErrorMessage = "You can't choose weekend";
                    return false;
                }

                return true;
            }

            return false;
        }


    }
}
