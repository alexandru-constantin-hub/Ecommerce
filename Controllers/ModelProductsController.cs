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
    public class ModelProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModelProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ModelProducts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Models.Include(m => m.Brand);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ModelProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelProduct = await _context.Models
                .Include(m => m.Brand)
                .FirstOrDefaultAsync(m => m.ModelProductId == id);
            if (modelProduct == null)
            {
                return NotFound();
            }

            return View(modelProduct);
        }

        // GET: ModelProducts/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId");
            return View();
        }

        // POST: ModelProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModelProductId,ModelProductName,BrandId")] ModelProduct modelProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modelProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", modelProduct.BrandId);
            return View(modelProduct);
        }

        // GET: ModelProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelProduct = await _context.Models.FindAsync(id);
            if (modelProduct == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", modelProduct.BrandId);
            return View(modelProduct);
        }

        // POST: ModelProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ModelProductId,ModelProductName,BrandId")] ModelProduct modelProduct)
        {
            if (id != modelProduct.ModelProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modelProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModelProductExists(modelProduct.ModelProductId))
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
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandId", modelProduct.BrandId);
            return View(modelProduct);
        }

        // GET: ModelProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelProduct = await _context.Models
                .Include(m => m.Brand)
                .FirstOrDefaultAsync(m => m.ModelProductId == id);
            if (modelProduct == null)
            {
                return NotFound();
            }

            return View(modelProduct);
        }

        // POST: ModelProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modelProduct = await _context.Models.FindAsync(id);
            _context.Models.Remove(modelProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModelProductExists(int id)
        {
            return _context.Models.Any(e => e.ModelProductId == id);
        }
    }
}
