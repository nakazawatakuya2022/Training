using System.ComponentModel.DataAnnotations;

namespace PandaPharmacyWeb.Models
{
    public class Product
    {
        public Product() { }

        public Product(int? productId, string? productName,
            int? price, string? memo,
            int? categoryId, string? categoryName)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Memo = memo;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public int? ProductId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "商品名は50字以内で入力してください")]
        public string? ProductName { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "価格は0以上を入力してください")]
        public int? Price { get; set; }

        [StringLength(200, ErrorMessage = "商品説明は200字以内で入力してください")]
        public string? Memo { get; set; }

        [Required]
        public int? CategoryId { get; set; }

        public string? CategoryName { get; set; }
    }
}
