using ITInventoryManagement.Data;
using ITInventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ITInventoryManagement.Controllers
{
    public class InventoryItemsController : Controller
    {
        private readonly DataContext _context;
        public InventoryItemsController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.InventoryItems.Include(i => i.Category);
            return View(await dataContext.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventoryItem = await _context.InventoryItems
                .Include(i => i.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventoryItem == null)
            {
                return NotFound();
            }

            return View(inventoryItem);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchInventory(
                string? name = null,
                string? serialNumber = null,
                string? model = null,
                string? brand = null,
                string? category = null,
                DateTime? purchaseDateFrom = null,
                DateTime? purchaseDateTo = null,
                int? StockQuantity = null,
                bool? isAssigned = null,
                bool? isLoaned = null)
        {
            var query = _context.InventoryItems.AsQueryable();

            query = query
                .Where(i => (name == null || i.Name.Contains(name)) &&
                            (serialNumber == null || i.SerialNumber.Contains(serialNumber)) &&
                            (model == null || i.Model.Contains(model)) &&
                            (brand == null || i.Brand.Contains(brand)) &&
                            (category == null || i.Category.Name.Contains(category)) &&
                            (!purchaseDateFrom.HasValue || i.PurchaseDate >= purchaseDateFrom) &&
                            (!purchaseDateFrom.HasValue || i.PurchaseDate >= purchaseDateFrom) &&
                            (!StockQuantity.HasValue || i.StockQuantity <= StockQuantity) &&
                            (!isAssigned.HasValue || i.IsAssigned == isAssigned) &&
                            (!isLoaned.HasValue || i.IsLoaned == isLoaned));

            var result = await query.ToListAsync();

            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,SerialNumber,Model,Brand,PurchaseDate,WarrantyExpiryDate,CategoryId,Id,CreatedAt,UpdatedAt,DeletedAt")] InventoryItem inventoryItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventoryItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", inventoryItem.CategoryId);
            return View(inventoryItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Name,SerialNumber,Model,Brand,PurchaseDate,WarrantyExpiryDate,CategoryId,Id,CreatedAt,UpdatedAt,DeletedAt")] InventoryItem inventoryItem)
        {
            if (id != inventoryItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventoryItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryItemExists(inventoryItem.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", inventoryItem.CategoryId);
            return View(inventoryItem);
        }

        private bool InventoryItemExists(int id)
        {
            return _context.InventoryItems.Any(e => e.Id == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var inventoryItem = await _context.InventoryItems.FindAsync(id);
            if (inventoryItem != null)
            {
                _context.InventoryItems.Remove(inventoryItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
