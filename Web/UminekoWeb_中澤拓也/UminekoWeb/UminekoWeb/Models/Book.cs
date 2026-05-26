using System.ComponentModel.DataAnnotations;

namespace UminekoWeb.Models
{
    /// <summary>
    /// 蔵書を表すクラス
    /// </summary>
    public class Book
    {
        public Book() { }


        public Book(int bookId, string isbn, string title, string author,
                    string publisher, DateTime purchaseDate, int purchasePrice,
                    string? memo, int categoryId, string categoryName, bool lentFlag)
        {
            BookId = bookId;
            Isbn = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            PurchaseDate = purchaseDate;
            PurchasePrice = purchasePrice;
            Memo = memo;
            LentFlag = lentFlag;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        /// <summary>
        /// 蔵書ID
        /// </summary>
        public int? BookId { get; set; }

        /// <summary>
        /// ISBN
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(17, ErrorMessage = "ISBNは17字以内で入力してください")]
        public string? Isbn { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(100, ErrorMessage = "タイトルは100字以内で入力してください")]
        public string? Title { get; set; }

        /// <summary>
        /// 著者
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(30, ErrorMessage = "著者は30字以内で入力してください")]
        public string? Author { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(30, ErrorMessage = "出版社は30字以内で入力してください")]
        public string? Publisher { get; set; }

        /// <summary>
        /// 購入日
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        /// <summary>
        /// 購入価格
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [Range(0, int.MaxValue, ErrorMessage = "価格は0以上を入力してください")]
        public int? PurchasePrice { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        [StringLength(200, ErrorMessage = "メモは200字以内で入力してください")]
        public string? Memo { get; set; }

        /// <summary>
        /// カテゴリID
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// カテゴリ名
        /// </summary>
        public string? CategoryName { get; set; }

        /// <summary>
        /// 貸出中フラグ
        /// </summary>
        public bool LentFlag { get; set; }
    }
}
