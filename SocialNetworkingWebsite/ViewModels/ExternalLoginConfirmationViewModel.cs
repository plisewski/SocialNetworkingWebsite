﻿using System.ComponentModel.DataAnnotations;

namespace SocialNetworkingWebsite.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
