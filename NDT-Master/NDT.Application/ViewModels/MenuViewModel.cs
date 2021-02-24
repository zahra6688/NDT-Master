using NDT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Application.ViewModels
{
    public class MenuViewModel
    {
        public IEnumerable<MenuModel> MenuList { get; set; }
    }
}
