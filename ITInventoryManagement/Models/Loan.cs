using Microsoft.AspNetCore.Identity;

namespace ITInventoryManagement.Models
{
    public class Loan : BaseModel
    {
        public int InventoryItemId { get; set; }
        public InventoryItem InventoryItem { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public DateTime LoanedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public bool IsReturned { get; set; } = false;
    }
}
