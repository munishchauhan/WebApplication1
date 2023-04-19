using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CateId { get; set; }
    }
}
