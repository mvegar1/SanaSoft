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
    public class MSCategoriesController : Controller
    {
        private readonly SanaProductsMemoryContext _context;

        public MSCategoriesController(SanaProductsMemoryContext context)
        {
            _context = context;
        }

        // GET: MSCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: MSCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSCategory = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSCategory == null)
            {
                return NotFound();
            }

            return View(mSCategory);
        }

        // GET: MSCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MSCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] MSCategory mSCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mSCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mSCategory);
        }

        // GET: MSCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSCategory = await _context.Categories.FindAsync(id);
            if (mSCategory == null)
            {
                return NotFound();
            }
            return View(mSCategory);
        }

        // POST: MSCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] MSCategory mSCategory)
        {
            if (id != mSCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mSCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MSCategoryExists(mSCategory.Id))
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
            return View(mSCategory);
        }

        // GET: MSCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSCategory = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSCategory == null)
            {
                return NotFound();
            }

            return View(mSCategory);
        }

        // POST: MSCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mSCategory = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(mSCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MSCategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
