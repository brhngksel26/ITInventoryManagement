using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ITInventoryManagement.Models
{
    public class InventoryItem : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        public int StockQuantity { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime? WarrantyExpiryDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsAssigned { get; set; } = false;
        public bool IsLoaned { get; set; } = false;
    }
}
