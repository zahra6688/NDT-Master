using Microsoft.Extensions.DependencyInjection;
using NDT.Application.Interfaces;
using NDT.Application.Services;
using NDT.Domain.Interfaces;
using NDT.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IMenuService, MenuService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IMenuRepository, MenuRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IProjectService, ProjectService>();
        }
    }
}
