using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Domain.Models
{
    public class MenuModel
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Title { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ClassIcon { get; set; }

    }
}
