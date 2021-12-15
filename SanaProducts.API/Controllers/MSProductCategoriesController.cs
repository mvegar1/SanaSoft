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
    public class MSProductCategoriesController : Controller
    {
        private readonly SanaProductsMemoryContext _context;

        public MSProductCategoriesController(SanaProductsMemoryContext context)
        {
            _context = context;
        }

        // GET: MSProductCategories
        public async Task<IActionResult> Index()
        {
            var sanaProductsMemoryContext = _context.ProductCategories.Include(m => m.Category).Include(m => m.Product);
            return View(await sanaProductsMemoryContext.ToListAsync());
        }

        // GET: MSProductCategories/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProductCategory = await _context.ProductCategories
                .Include(m => m.Category)
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSProductCategory == null)
            {
                return NotFound();
            }

            return View(mSProductCategory);
        }

        // GET: MSProductCategories/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: MSProductCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,CategoryId")] MSProductCategory mSProductCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mSProductCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", mSProductCategory.CategoryId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", mSProductCategory.ProductId);
            return View(mSProductCategory);
        }

        // GET: MSProductCategories/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProductCategory = await _context.ProductCategories.FindAsync(id);
            if (mSProductCategory == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Description", mSProductCategory.CategoryId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", mSProductCategory.ProductId);
            return View(mSProductCategory);
        }

        // POST: MSProductCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,ProductId,CategoryId")] MSProductCategory mSProductCategory)
        {
            if (id != mSProductCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mSProductCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MSProductCategoryExists(mSProductCategory.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", mSProductCategory.CategoryId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", mSProductCategory.ProductId);
            return View(mSProductCategory);
        }

        // GET: MSProductCategories/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProductCategory = await _context.ProductCategories
                .Include(m => m.Category)
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSProductCategory == null)
            {
                return NotFound();
            }

            return View(mSProductCategory);
        }

        // POST: MSProductCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var mSProductCategory = await _context.ProductCategories.FindAsync(id);
            _context.ProductCategories.Remove(mSProductCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MSProductCategoryExists(long id)
        {
            return _context.ProductCategories.Any(e => e.Id == id);
        }
    }
}
