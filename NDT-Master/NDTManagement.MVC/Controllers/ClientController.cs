using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NDT.Infra.Data.Context;
using NDT.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using NDT.Domain.Models;

namespace NDTManagement.MVC.Controllers
{
    public class ClientController : Controller
    {
        //private readonly IClientRepository _clientRepository;
        private readonly NdtDbContext _dbContext;
        private readonly ILogger<ClientController> _logger;

        public ClientController(NdtDbContext dbContext, ILogger<ClientController> logger)
        {
            // _clientRepository = clientRepository;
            _dbContext = dbContext;
            _logger = logger;
        }


        public IActionResult Index()
        {
            var clients = _dbContext.Clients.ToList();
            return View(clients);
        }

        [HttpGet]

        [AllowAnonymous]
        public IActionResult ShowClients()
        {
            var clients = _dbContext.Clients.ToList();
            return View(clients);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientName,CeoName,Address,CentralPhoneNo")] Client client)
        {
            if (ModelState.IsValid)
            {
                client.Id = Guid.NewGuid();
                _dbContext.Add(client);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(ShowClients));
            }
         
            return View(client);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _dbContext.Clients
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }
           
            return View(client);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientToUpdate = await _dbContext.Clients
                .FirstOrDefaultAsync(c => c.Id == id);

            if (await TryUpdateModelAsync<Client>(clientToUpdate,
                "",
                c => c.ClientName, c => c.CeoName, c => c.Address, c=>c.CentralPhoneNo))
            {
                try
                {
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(ShowClients));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            
            return View(clientToUpdate);
        }
        public async Task<IActionResult> Delete(Guid? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _dbContext.Clients
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(client);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var client = await _dbContext.Clients.FindAsync(id);
            _dbContext.Clients.Remove(client);

            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(ShowClients));
        }



        //public IActionResult EditClient(Guid clientId)
        //{

        //}
    }
}
