using RegistrationForm.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Date]
        public DateTime Date { get; set; }

        [EnumDataType(typeof(Product))]
        public Product ProductType { get; set; }

    }
}
