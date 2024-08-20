using ITInventoryManagement.Models;

namespace ITInventoryManagement.ViewModel
{
    public class SearchModel
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public DateTime? PurchaseDateFrom { get; set; }
        public DateTime? PurchaseDateTo { get; set; }
        public int? StockQuantity { get; set; }
        public bool? IsAssigned { get; set; }
        public bool? IsLoaned { get; set; }
        public IEnumerable<InventoryItem> InventoryItems { get; set; }
    }
}
