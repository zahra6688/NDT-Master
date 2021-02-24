using NDT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Domain.Interfaces
{
    public interface IMenuRepository
    {
        IEnumerable<MenuModel> GetMenuList();
    }
}
