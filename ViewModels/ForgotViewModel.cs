using System.ComponentModel.DataAnnotations;

namespace AlongSide.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
