using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NDT.Application.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required, Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required, Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
