namespace UminekoWeb.Models
{
    public class LentHistory
    {
        public LentHistory() { }

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

        public string? MemberCode { get; set; }

        public int? BookId { get; set; }

        public DateTime? LentDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public string? Memo { get; set; }

        public bool HasReturned { get; set; }
    }
}