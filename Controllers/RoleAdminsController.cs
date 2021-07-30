using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EShop1.Models;
using Ecommerce.Data;

namespace Ecommerce.Controllers
{
    public class RoleAdminsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoleAdminsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoleAdmins
        public async Task<IActionResult> Index()
        {
            var rolesDefault = (from role in _context.Roles
                                select new
                                {
                                    RoleAdminId = role.Id,
                                    RoleAdminName = role.Name
                                }).ToListAsync();
            
            return View(await rolesDefault);
        }

        // GET: RoleAdmins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleAdmin = await _context.RoleAdmins
                .FirstOrDefaultAsync(m => m.RoleAdminId == id);
            if (roleAdmin == null)
            {
                return NotFound();
            }

            return View(roleAdmin);
        }

        // GET: RoleAdmins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoleAdmins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleAdminId,RoleAdminName")] RoleAdmin roleAdmin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roleAdmin);
        }

        // GET: RoleAdmins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleAdmin = await _context.RoleAdmins.FindAsync(id);
            if (roleAdmin == null)
            {
                return NotFound();
            }
            return View(roleAdmin);
        }

        // POST: RoleAdmins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoleAdminId,RoleAdminName")] RoleAdmin roleAdmin)
        {
            if (id != roleAdmin.RoleAdminId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleAdminExists(roleAdmin.RoleAdminId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roleAdmin);
        }

        // GET: RoleAdmins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleAdmin = await _context.RoleAdmins
                .FirstOrDefaultAsync(m => m.RoleAdminId == id);
            if (roleAdmin == null)
            {
                return NotFound();
            }

            return View(roleAdmin);
        }

        // POST: RoleAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleAdmin = await _context.RoleAdmins.FindAsync(id);
            _context.RoleAdmins.Remove(roleAdmin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleAdminExists(int id)
        {
            return _context.RoleAdmins.Any(e => e.RoleAdminId == id);
        }
    }
}
