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
    public class MSProductDetailsController : Controller
    {
        private readonly SanaProductsMemoryContext _context;

        public MSProductDetailsController(SanaProductsMemoryContext context)
        {
            _context = context;
        }

        // GET: MSProductDetails
        public async Task<IActionResult> Index()
        {
            var sanaProductsMemoryContext = _context.ProductDetails.Include(m => m.Product);
            return View(await sanaProductsMemoryContext.ToListAsync());
        }

        // GET: MSProductDetails/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProductDetail = await _context.ProductDetails
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSProductDetail == null)
            {
                return NotFound();
            }

            return View(mSProductDetail);
        }

        // GET: MSProductDetails/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: MSProductDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,ProducedBy,TechnicalDataSheet,Model,Description,Score,Gender")] MSProductDetail mSProductDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mSProductDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", mSProductDetail.ProductId);
            return View(mSProductDetail);
        }

        // GET: MSProductDetails/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProductDetail = await _context.ProductDetails.FindAsync(id);
            if (mSProductDetail == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", mSProductDetail.ProductId);
            return View(mSProductDetail);
        }

        // POST: MSProductDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,ProductId,ProducedBy,TechnicalDataSheet,Model,Description,Score,Gender")] MSProductDetail mSProductDetail)
        {
            if (id != mSProductDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mSProductDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MSProductDetailExists(mSProductDetail.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", mSProductDetail.ProductId);
            return View(mSProductDetail);
        }

        // GET: MSProductDetails/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mSProductDetail = await _context.ProductDetails
                .Include(m => m.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mSProductDetail == null)
            {
                return NotFound();
            }

            return View(mSProductDetail);
        }

        // POST: MSProductDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var mSProductDetail = await _context.ProductDetails.FindAsync(id);
            _context.ProductDetails.Remove(mSProductDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MSProductDetailExists(long id)
        {
            return _context.ProductDetails.Any(e => e.Id == id);
        }
    }
}
