using NDT.Domain.Interfaces;
using NDT.Domain.Models;
using NDT.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Infra.Data.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        public NdtDbContext _context;
        public MenuRepository(NdtDbContext context)
        {
            _context = context;
        }
        public IEnumerable<MenuModel> GetMenuList()
        {
            return _context.menuItems;
        }
    }
}
