using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        /// <summary>
        /// نام کارفرما
        /// </summary>
        public string ClientName { get; set; } 

        /// <summary>
        /// زمینه‌ی کاری
        /// </summary>
        public string JobDomain{ get; set; }
        /// <summary>
        /// نام مدیر عامل
        /// </summary>
        public string CeoName { get; set; }
        /// <summary>
        /// آدرس دفتر مرکزی
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// تلفن دفتر مرکزی
        /// </summary>
        public string CentralPhoneNo { get; set; }
        /// <summary>
        /// فکس دفتر مرکزی
        /// </summary>
        public string CentralFaxNo { get; set; }
        /// <summary>
        /// تلفن سایت
        /// </summary>
        public string SitePhoneNo { get; set; }
        /// <summary>
        /// فکس سایت
        /// </summary>
        public string SiteFaxNo { get; set; }
        /// <summary>
        /// پست الکترونیکی
        /// </summary>
        public string EmailAddress { get; set; }
    }
}
