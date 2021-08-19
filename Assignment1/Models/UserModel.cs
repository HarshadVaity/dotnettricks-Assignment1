using Assignment1.CustomValidation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is mandatory")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is mandatory")]
        [Compare("Password",ErrorMessage = "Confirm Password should match with password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Contact is mandatory")]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage ="Enter valid contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Country is mandatory")]
        public string Country { get; set; }

        public List<SelectListItem> Countries { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="",Text=""},
            new SelectListItem {Value="India",Text="India"},
            new SelectListItem {Value="Australia",Text="Australia"}
        };

        [Required(ErrorMessage = "City is mandatory")]
        public string City { get; set; }

        public List<SelectListItem> Cities { get; } = new List<SelectListItem>
        {
            
        };


        [Required(ErrorMessage = "Please select gender")]
        public string  Gender { get; set; }
        public string[] Genders = new[] { "Male", "Female"};
    

        [ValidateCheckBox(ErrorMessage = "Please accept terms")]
        [Display(Name= "Accept Terms")]
        public bool AcceptTerms { get; set; }

    }

    


}
