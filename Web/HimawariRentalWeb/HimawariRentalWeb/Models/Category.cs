using System.ComponentModel.DataAnnotations;

namespace HimawariRentalWeb.Models
{
    /// <summary>
    /// カテゴリを表すクラス
    /// </summary>
    public class Category
    {
        public Category() { }

        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        /// <summary>
        /// カテゴリID
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// カテゴリ名
        /// </summary>
        public string? CategoryName { get; set; }
    }
}
