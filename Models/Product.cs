using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public string ProductDisctiption { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductPrice { get; set; }

    }
}
