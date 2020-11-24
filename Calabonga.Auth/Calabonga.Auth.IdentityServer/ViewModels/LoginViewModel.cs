﻿using System.ComponentModel.DataAnnotations;

namespace Calabonga.Auth.IdentityServer.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; } = "User";

        [Required]
        public string Password { get; set; } = "123qwe";

        [Required]
        public string ReturnUrl { get; set; }
    }
}