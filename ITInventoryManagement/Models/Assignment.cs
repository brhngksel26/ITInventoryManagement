using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ITInventoryManagement.Models
{
    public class Assignment : BaseModel
    {
        public int InventoryItemId { get; set; }
        public InventoryItem InventoryItem { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public bool IsReturned { get; set; } = false;
    }
}
