﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanArchTemplate.BC.AccessControl.Account.Presentation.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}