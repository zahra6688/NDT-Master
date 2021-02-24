using NDT.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NDT.Application.ViewModels
{
    public class ProjectViewModel
    {
        //public IEnumerable<Project> ProjectList { get; set; }

        //[Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "لطفا {0} را انتخاب کنید ")]
        [Display(Name = "کارفرما")]
        public string clientId { get; set; }
        
        public string clientName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "عنوان پروژه")]
        public string projectTitle { get; set; }

        //[Required]
        //public DateTime startDate { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "استان")]
        public string state { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "شهر")]
        public string city { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید ")]
        [Display(Name = "آدرس")]
        public string address { get; set; }

        //[Required]
        //public bool radiographyType { get; set; }
    }
}
