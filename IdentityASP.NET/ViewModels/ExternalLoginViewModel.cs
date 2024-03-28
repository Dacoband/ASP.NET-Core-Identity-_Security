using System.ComponentModel.DataAnnotations;

namespace IdentityASPNet.ViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
