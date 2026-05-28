using System.ComponentModel.DataAnnotations;

namespace UminekoWeb.Models
{
    /// <summary>
    /// カテゴリを表すクラス
    /// </summary>
    public class Category
    {
        // 新規登録用のコンストラクタ
        public Category() { }

        // 一覧表示用のコンストラクタ
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
