using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Data;
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Product.Include(p => p.category).Include(p => p.gender).Include(p => p.size);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.category)
                .Include(p => p.gender)
                .Include(p => p.size)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId");
            ViewData["GenderId"] = new SelectList(_context.Set<Gender>(), "GenderId", "GenderId");
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ProductDisc,Price,CategoryId,GenderId,SizeId")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId", product.CategoryId);
            ViewData["GenderId"] = new SelectList(_context.Set<Gender>(), "GenderId", "GenderId", product.GenderId);
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId", product.CategoryId);
            ViewData["GenderId"] = new SelectList(_context.Set<Gender>(), "GenderId", "GenderId", product.GenderId);
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ProductDisc,Price,CategoryId,GenderId,SizeId")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId", product.CategoryId);
            ViewData["GenderId"] = new SelectList(_context.Set<Gender>(), "GenderId", "GenderId", product.GenderId);
            ViewData["SizeId"] = new SelectList(_context.Set<Size>(), "SizeId", "SizeId", product.SizeId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.category)
                .Include(p => p.gender)
                .Include(p => p.size)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }

        public ViewResult List(int category)
        {
            int _category = category;
            IEnumerable<Product> products = new List<Product>(); ;
            string currentCategoryName = string.Empty;

            if (currentCategoryName == "View All Products")
            {
                products = _context.Product.OrderBy(p => p.ProductId);
                currentCategoryName = "All Products";
            }
            else
            //{
            {
                products = _context.Product.Where(p => p.category.CategoryId==_category);

            }
            //    if (_category == 1 && currentCategoryName == "clothes")
            //        products = _context.Product.Where(p => p.category.CategoryName.Equals("clothes")).OrderBy(p => p.category.CategoryId);
            //    else if (_category == 2 && currentCategoryName == "Shoes")
            //        products = _context.Product.Where(p => p.category.CategoryName.Equals("Shoes")).OrderBy(p => p.category.CategoryId);
            //    else if (_category == 3 && currentCategoryName == "Accessories")
            //        products = _context.Product.Where(p => p.category.CategoryName.Equals("Accessories")).OrderBy(p => p.category.CategoryId);
            //CurrentCategory = _category;


            return View(new ProductsListView
            {
                Products = products,
                CurrentCategoryName = currentCategoryName
            });
        }

        public async Task<IActionResult> ListOfProducts()
        {
            var applicationDbContext = _context.Product.Include(p => p.category).Include(p => p.gender).Include(p => p.size);
            return View(await applicationDbContext.ToListAsync());
        }











    }







}

