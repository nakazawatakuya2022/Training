using System.ComponentModel.DataAnnotations;

namespace HimawariRentalWeb.Models
{
    /// <summary>
    /// レンタル品を表すクラス
    /// </summary>
    public class RentalItem
    {
        public RentalItem() { }


        public RentalItem(int rentalItemId, string management_code, string item_name, string maker,
                    string storage_location, DateTime purchaseDate, int purchasePrice,
                    string? memo, int categoryId, string categoryName, bool rentalFlag)
        {
            RentalItemId = rentalItemId;
            ManagementCode = management_code;
            ItemName = item_name;
            Maker = maker;
            StorageLocation = storage_location;
            PurchaseDate = purchaseDate;
            PurchasePrice = purchasePrice;
            Memo = memo;
            RentalFlag = rentalFlag;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        /// <summary>
        /// レンタル品ID
        /// </summary>
        public int? RentalItemId { get; set; }

        /// <summary>
        /// 管理番号
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(17, ErrorMessage = "管理番号は17字以内で入力してください")]
        public string? ManagementCode { get; set; }

        /// <summary>
        /// 品名
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(100, ErrorMessage = "品名は100字以内で入力してください")]
        public string? ItemName { get; set; }

        /// <summary>
        /// メーカー
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(30, ErrorMessage = "メーカーは30字以内で入力してください")]
        public string? Maker { get; set; }

        /// <summary>
        /// 保管場所
        /// </summary>
        [Required(ErrorMessage = "この項目は必須です")]
        [StringLength(30, ErrorMessage = "保管場所は30字以内で入力してください")]
        public string? StorageLocation { get; set; }

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
        /// レンタル中フラグ
        /// </summary>
        public bool RentalFlag { get; set; }
    }
}
