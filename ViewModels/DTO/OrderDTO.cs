using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShop.Models;

namespace WebShop.ViewModels.DTO
{
    public class OrderDTO
    {
        
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Adress { get; set; }
        public DateTime OrderedAt { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal TotalOrderAmount { get; set; }
    }
}