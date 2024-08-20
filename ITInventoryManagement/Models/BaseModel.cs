using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ITInventoryManagement.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [DefaultValue(typeof(DateTime), "GetDate()")]
        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
