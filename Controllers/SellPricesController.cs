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
    public class SellPricesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SellPricesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SellPrices
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SellPrices.Include(s => s.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SellPrices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sellPrice = await _context.SellPrices
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.SellPriceId == id);
            if (sellPrice == null)
            {
                return NotFound();
            }

            return View(sellPrice);
        }

        // GET: SellPrices/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
            return View();
        }

        // POST: SellPrices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SellPriceId,ProductId,Price,From,Until")] SellPrice sellPrice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sellPrice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", sellPrice.ProductId);
            return View(sellPrice);
        }

        // GET: SellPrices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sellPrice = await _context.SellPrices.FindAsync(id);
            if (sellPrice == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", sellPrice.ProductId);
            return View(sellPrice);
        }

        // POST: SellPrices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SellPriceId,ProductId,Price,From,Until")] SellPrice sellPrice)
        {
            if (id != sellPrice.SellPriceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sellPrice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellPriceExists(sellPrice.SellPriceId))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", sellPrice.ProductId);
            return View(sellPrice);
        }

        // GET: SellPrices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sellPrice = await _context.SellPrices
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.SellPriceId == id);
            if (sellPrice == null)
            {
                return NotFound();
            }

            return View(sellPrice);
        }

        // POST: SellPrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sellPrice = await _context.SellPrices.FindAsync(id);
            _context.SellPrices.Remove(sellPrice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SellPriceExists(int id)
        {
            return _context.SellPrices.Any(e => e.SellPriceId == id);
        }
    }
}
