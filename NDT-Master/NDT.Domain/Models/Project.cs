using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NDT.Domain.Models
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// شناسه ی کارفرما
        /// </summary>
        public Guid clientId { get; set; }
        [ForeignKey("clientId")]
        public Client client { get; set; }
        /// <summary>
        /// عنوان پروژه
        /// </summary>
        public string projectTitle { get; set; }
        /// <summary>
        /// تاریخ شروع پروژه
        /// </summary>
        public DateTime startDate { get; set; }
        /// <summary>
        /// استان
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// شهر
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// نوع رادیوگرافی
        /// </summary>
        public string radiographyType { get; set; }
    }
}
