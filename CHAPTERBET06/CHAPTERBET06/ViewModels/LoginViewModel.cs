﻿using System.ComponentModel.DataAnnotations;

namespace CHAPTERBET06.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe e-mail do usuario")]
        public  string email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuario")]
        public string senha { get; set; }
    }
}
