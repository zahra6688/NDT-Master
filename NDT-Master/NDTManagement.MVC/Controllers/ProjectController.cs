using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NDT.Application.Interfaces;
using NDT.Application.ViewModels;

namespace NDTManagement.MVC.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var projects = _projectService.GetProjects();
            return View(projects);
        }

        #region Create Project
        public IActionResult Create()
        {
            var clientList = _projectService.GetClients().ToList();
            ViewBag.Clients = clientList.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.ClientName }).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectViewModel project)
        {
            if (ModelState.IsValid)
            {

                await _projectService.CreateProject(project);

                return RedirectToAction("Index");
            }

            return View(project);
        }
        #endregion

        #region Delete Project
        public async Task<IActionResult> Delete(Guid? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _projectService.GetProjectById(id);
            if (project == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(project);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {

            await _projectService.DeleteProject(id);
            return RedirectToAction("Index");
        }
        #endregion

        #region Edit Project
        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _projectService.GetProjectById(id);

            var clientList = _projectService.GetClients().ToList();
            ViewBag.Clients = clientList.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.ClientName }).ToList();

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Guid? id, ProjectViewModel model)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectToUpdate = await _projectService.GetProjectById(id);

            try
            {
                await _projectService.EditProject(model);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException  ex )
            {
                //Log the error (uncomment ex variable name and write a log.)
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists, " +
                    "see your system administrator.");
            }


            return View(projectToUpdate);
        }
        #endregion
    }
}