﻿using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PlacitaWS.Models
{
    // Models used as parameters to AccountController actions.

    public class AddExternalLoginBindingModel
    {
        [Required]
        [Display(Name = "External access token")]
        public string ExternalAccessToken { get; set; }
    }

    public class ChangePasswordBindingModel
    {
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter just numeric password")]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter just numeric password")]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter just numeric password")]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterBindingModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Identification")]
        public String Identification { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public String Phone { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public String Address { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter just numeric password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter just numeric password")]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class RemoveLoginBindingModel
    {
        [Required]
        [Display(Name = "Login provider")]
        public string LoginProvider { get; set; }

        [Required]
        [Display(Name = "Provider key")]
        public string ProviderKey { get; set; }
    }

    public class SetPasswordBindingModel
    {
        [Required]
        [StringLength(4, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter just numeric password")]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter just numeric password")]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
