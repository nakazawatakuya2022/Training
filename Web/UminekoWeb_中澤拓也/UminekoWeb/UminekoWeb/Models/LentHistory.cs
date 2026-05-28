using System.ComponentModel.DataAnnotations;

namespace UminekoWeb.Models
{
    public class LentHistory
    {
        // 新規登録用のコンストラクタ
        public LentHistory() { }

        // 一覧表示用のコンストラクタ
        public LentHistory(
            string memberCode,
            int bookId,
            DateTime lentDate,
            DateTime? returnDate,
            string? memo,
            bool hasReturned)
        {
            MemberCode = memberCode;
            BookId = bookId;
            LentDate = lentDate;
            ReturnDate = returnDate;
            Memo = memo;
            HasReturned = hasReturned;
        }

        [Required]
        public string? MemberCode { get; set; }

        public int? BookId { get; set; }

        public DateTime? LentDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [StringLength(200)]
        public string? Memo { get; set; }

        public bool HasReturned { get; set; }
    }
}