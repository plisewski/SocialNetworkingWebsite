using System.ComponentModel.DataAnnotations;

namespace SocialNetworkingWebsite.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
