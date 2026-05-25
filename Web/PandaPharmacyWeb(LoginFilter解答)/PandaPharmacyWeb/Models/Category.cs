using System.ComponentModel.DataAnnotations;

namespace PandaPharmacyWeb.Models
{
    public class Category
    {
        public Category() { }

        public Category(int? categoryId, string? categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public int? CategoryId { get; set; }

        [Required]
        public string? CategoryName { get; set; }
    }
}
