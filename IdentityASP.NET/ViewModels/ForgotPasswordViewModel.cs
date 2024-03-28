﻿using System.ComponentModel.DataAnnotations;

namespace IdentityASPNet.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
