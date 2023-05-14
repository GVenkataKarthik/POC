using System.ComponentModel.DataAnnotations;

namespace POC.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string OrderName { get; set; }
        public int DisplayOrder { get; set; }

    }
}
