using Microsoft.AspNetCore.Mvc;
using NDT.Application.Interfaces;
using NDT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NDTManagement.MVC.Component
{
    public class MenuComponent:ViewComponent
    {
        //private readonly NdtDbContext _dbContext;
        //public MenuComponent( NdtDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}
        private IMenuService _menuService;
        public MenuComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var menuList = _dbContext.menuItems.ToList();
            var menuList = _menuService.GetMenu();
            try
            {
                //var menuItems = (from m in menuList
                //                 select new MenuModel
                //                 {
                //                     Id = m.Id,
                //                     ParentId = m.ParentId,
                //                     Title = m.Title,
                //                     ActionName = m.ActionName,
                //                     ControllerName = m.ControllerName,
                //                     ClassIcon = m.ClassIcon
                //                 }).ToList();

                //return View("Default", menuItems);
                return View("Default", menuList);
            }
            catch (Exception ex)
            {
                var error = ex.Message.ToString();
                return Content("Error");
            }
        }
       
    }
}
