using NDT.Application.ViewModels;
using NDT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDT.Application.Interfaces
{
    public interface IProjectService
    {
        IQueryable<ProjectViewModel> GetProjects();

        Task<ProjectViewModel> GetProjectById(Guid? id);

        Task CreateProject(ProjectViewModel project);

        Task EditProject(ProjectViewModel project);

        Task DeleteProject(Guid Id);

        public IQueryable<Client> GetClients();

        //Project Find(Guid id);

    }
}
