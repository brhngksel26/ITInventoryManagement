using Microsoft.AspNetCore.Identity.UI.Services;

namespace ITInventoryManagement.Services
{
    public class NotificationService : BackgroundService
    {
        private readonly IInventoryService _inventoryService;
        private readonly IEmailSender _emailSender;

        public NotificationService(IInventoryService inventoryService, IEmailSender emailSender)
        {
            _inventoryService = inventoryService;
            _emailSender = emailSender;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await CheckInventoryAsync();
                await CheckWarrantiesAsync();
                await Task.Delay(TimeSpan.FromHours(24), stoppingToken); // Günde bir kez kontrol et
            }
        }

        private async Task CheckInventoryAsync()
        {
            var lowStockItems = await _inventoryService.GetLowStockItemsAsync();
            foreach (var item in lowStockItems)
            {
                string subject = $"Düşük Stok Uyarısı: {item.Name}";
                string message = $"Stok durumu kritik seviyede: {item.Name} (Stok: {item.StockQuantity})";

                await _emailSender.SendEmailAsync("admin@example.com", subject, message);
            }
        }

        private async Task CheckWarrantiesAsync()
        {
            var expiringWarranties = await _inventoryService.GetExpiringWarrantiesAsync();
            foreach (var item in expiringWarranties)
            {
                string subject = $"Garanti Süresi Uyarısı: {item.Name}";
                string message = $"{item.Name} için garanti süresi yakında dolacak (Bitiş Tarihi: {item.WarrantyExpiryDate.ToString()})";

                await _emailSender.SendEmailAsync("admin@example.com", subject, message);
            }
        }
    }
}
