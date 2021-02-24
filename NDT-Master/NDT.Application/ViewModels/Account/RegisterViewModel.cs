using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NDT.Application.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "ایمیل")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "رمزعبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "تکرار رمزعبور")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}


//[MaxLength(300)]
//[EmailAddress]
//[Display(Name = "ایمیل")]
//[Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
//public string Email { get; set; }



//[Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
//[MaxLength(50)]
//[DataType(DataType.Password)]
//[Display(Name = "کلمه عبور")]
//public string Password { get; set; }

//[Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
//[MaxLength(50)]
//[DataType(DataType.Password)]
//[Compare("Password")]
//[Display(Name = "تکرار کلمه عبور")]
//public string RePassword { get; set; }
