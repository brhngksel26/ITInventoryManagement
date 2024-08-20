using System.ComponentModel.DataAnnotations;

namespace ITInventoryManagement.Models
{
    public class Category : BaseModel
    {
        [StringLength(50)]
        public required string Name { get; set; }

        public ICollection<InventoryItem>? InventoryItems { get; set; }
    }
}
