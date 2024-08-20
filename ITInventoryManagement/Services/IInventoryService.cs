using ITInventoryManagement.Data;
using ITInventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ITInventoryManagement.Services
{
    public interface IInventoryService
    {
        Task<IEnumerable<InventoryItem>> GetLowStockItemsAsync();
        Task<IEnumerable<InventoryItem>> GetExpiringWarrantiesAsync();
    }

    public class InventoryService : IInventoryService
    {
        private readonly DataContext _context;

        public InventoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InventoryItem>> GetLowStockItemsAsync()
        {
            return await _context.InventoryItems
                .Where(i => i.StockQuantity <= 5) // Stok sınırını belirleyin
                .ToListAsync();
        }

        public async Task<IEnumerable<InventoryItem>> GetExpiringWarrantiesAsync()
        {
            var nextMonth = DateTime.Now.AddMonths(1);
            return await _context.InventoryItems
                .Where(i => i.WarrantyExpiryDate <= nextMonth)
                .ToListAsync();
        }
    }
}
