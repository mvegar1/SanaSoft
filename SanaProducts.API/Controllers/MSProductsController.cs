using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SanaProducts.Domain.EntitiesMS;
using SanaProducts.Infraestructure.Persistence;

namespace SanaProducts.API.Controllers
{
    public class MSProductsController : Controller
    {
        private readonly SanaProductsMemoryContext _context;

        public MSProductsController(SanaProductsMemoryContext context)
        {
            _context = context;
        }

        // GET: MSProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: MSProducts/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProduct = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSProduct == null)
            {
                return NotFound();
            }

            return View(mSProduct);
        }

        // GET: MSProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MSProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,TradeMark,Image")] MSProduct mSProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mSProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mSProduct);
        }

        // GET: MSProducts/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProduct = await _context.Products.FindAsync(id);
            if (mSProduct == null)
            {
                return NotFound();
            }
            return View(mSProduct);
        }

        // POST: MSProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,TradeMark,Image")] MSProduct mSProduct)
        {
            if (id != mSProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mSProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MSProductExists(mSProduct.Id))
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
            return View(mSProduct);
        }

        // GET: MSProducts/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProduct = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSProduct == null)
            {
                return NotFound();
            }

            return View(mSProduct);
        }

        // POST: MSProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var mSProduct = await _context.Products.FindAsync(id);
            _context.Products.Remove(mSProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MSProductExists(long id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
