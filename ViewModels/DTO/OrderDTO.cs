using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.Models;

namespace WebShop.ViewModels.DTO
{
    public class OrderDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Adress { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal TotalOrderAmount { get; set; }
    }
}