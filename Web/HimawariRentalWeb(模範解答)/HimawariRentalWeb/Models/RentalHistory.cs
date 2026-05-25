using System.ComponentModel.DataAnnotations;

namespace HimawariRentalWeb.Models
{
    /// <summary>
    /// レンタル履歴を表すクラス
    /// </summary>
    public class RentalHistory
    {
        public RentalHistory() { }

        public RentalHistory(string customerCode, int rentalItemId,
            DateTime rentalDate, DateTime returnDate, string? memo, bool has_returned)
        {
            CustomerCode = customerCode;
            RentalItemId = rentalItemId;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            Memo = memo;
            HasReturned = has_returned;
        }

        /// <summary>
        /// 顧客番号
        /// </summary>
        [Required]
        public string? CustomerCode { get; set; }

        /// <summary>
        /// レンタル品ID
        /// </summary>
        public int? RentalItemId { get; set; }

        /// <summary>
        /// レンタル日
        /// </summary>
        public DateTime? RentalDate { get; set; }

        /// <summary>
        /// 返却日
        /// </summary>
        public DateTime? ReturnDate { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        public string? Memo { get; set; }

        /// <summary>
        /// 返却済みフラグ
        /// </summary>
        public bool HasReturned { get; set; }
    }
}
