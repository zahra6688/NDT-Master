using NDT.Application.Interfaces;
using NDT.Application.ViewModels;
using NDT.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Application.Services
{
    public class MenuService : IMenuService
    {
        public IMenuRepository _menuRepository;
        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public MenuViewModel GetMenu()
        {
            return new MenuViewModel()
            {
                MenuList = _menuRepository.GetMenuList()
            };
        }
    }
}
