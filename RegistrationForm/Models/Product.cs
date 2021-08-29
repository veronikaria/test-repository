using RegistrationForm.Attributes;
using System.ComponentModel;

namespace RegistrationForm.Models
{
    [DayForBasic]
    public enum Product
    {
        [Description("JavaScript")]
        JS = 1,
        [Description("C#")]
        C = 2,
        [Description("Java")]
        Java = 3,
        [Description("Python")]
        Python = 4,
        [Description("Основы")]
        Basic = 5
    }
}
