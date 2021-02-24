using NDT.Application.Interfaces;
using NDT.Application.ViewModels;
using NDT.Domain.Interfaces;
using NDT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDT.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IGenericRepository<Project> _projectRepository;
        private readonly IGenericRepository<Client> _clientRepository;
        public ProjectService(IGenericRepository<Project> projectRepository, IGenericRepository<Client> clientRepository)
        {
            _projectRepository = projectRepository;
            _clientRepository = clientRepository;
        }

        /// <summary>
        /// ایجاد پروزه ی جدید
        /// </summary>
        /// <param name="projectModel"></param>
        /// <returns></returns>
        public async Task CreateProject(ProjectViewModel projectModel)
        {
            var project = new Project
            {
                Id = Guid.NewGuid(),
                clientId = new Guid(projectModel.clientId),
                projectTitle = projectModel.projectTitle,
                state = projectModel.state,
                city = projectModel.city,
                address = projectModel.address,

            };
            await _projectRepository.Create(project);
        }

        /// <summary>
        /// برگرداندن اطلاعات کارفرما
        /// </summary>
        /// <returns></returns>
        public IQueryable<Client> GetClients()
        {
            var clients = _clientRepository.GetAll();
            return clients;
        }

        /// <summary>
        /// برگرداندن اطلاعات پروژه ها
        /// </summary>
        /// <returns></returns>
        public IQueryable<ProjectViewModel> GetProjects()
        {
            var d = _projectRepository.GetAll();
            var projects = from p in _projectRepository.GetAll()
                           join c in _clientRepository.GetAll()
                           on p.clientId equals c.Id
                           select new ProjectViewModel
                           {
                               Id = p.Id,
                               clientId = c.Id.ToString(),
                               clientName = c.ClientName,
                               projectTitle = p.projectTitle,
                               state = p.state,
                               city = p.city,
                               address = p.address
                           };
            return projects;
        }

        public async Task<ProjectViewModel> GetProjectById(Guid? id)
        {
            var project = _projectRepository.GetById(id);
            
            var clientName = from client in _clientRepository.GetAll()
                             where client.Id == project.clientId
                             select client.ClientName;
            var c = clientName.FirstOrDefault();

            var projectViewModel = new ProjectViewModel
            {
                Id = project.Id,
                clientId = project.clientId.ToString(),
                clientName= clientName.FirstOrDefault(),
                projectTitle = project.projectTitle,
                state = project.state,
                city = project.city,
                address = project.address
            };
           

            
            return projectViewModel;
        }

        public async Task DeleteProject(Guid Id)
        {
            await _projectRepository.Delete(Id);
        }

        public async Task EditProject(ProjectViewModel projectViewModel)
        {
            var projectToUpdate = _projectRepository.GetById(projectViewModel.Id);
            projectToUpdate.clientId = new Guid(projectViewModel.clientId);
            projectToUpdate.projectTitle = projectViewModel.projectTitle;
            projectToUpdate.state = projectViewModel.state;
            projectToUpdate.city = projectViewModel.city;
            projectToUpdate.address = projectViewModel.address;
            await _projectRepository.Update(projectToUpdate);

        }
    }
}
