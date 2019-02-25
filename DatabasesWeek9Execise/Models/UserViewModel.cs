using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabasesWeek9Execise.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username required")]
        [Remote("IsUsernameValid", "Validation", ErrorMessage = "This username is already used.")]
        public string Username { get; set; }

        [Display(Name = "Password"),DataType(DataType.Password)]
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }

        [Display(Name = "Street")]
        [Required(ErrorMessage = "Street name also required")]
        public string StreetName { get; set; }

        [Display(Name = "Street number")]
        [Required(ErrorMessage = "Street without number? Nah, required!")]
        public int StreetNumber { get; set; }

        [Display(Name = "Post number")]
        [Required(ErrorMessage = "Last one I promise, fill it in please!")]
        public int PostNr { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Just in case.")]
        [Remote("IsAddressValidFromApi", "Validation", AdditionalFields = "PostNr,StreetNumber,StreetName", ErrorMessage = "The address is invalid. Check the post code/city.")]
        public string City { get; set; }
    }
}
