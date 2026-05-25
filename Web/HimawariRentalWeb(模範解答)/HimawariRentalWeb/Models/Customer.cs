namespace HimawariRentalWeb.Models
{
    /// <summary>
    /// 顧客を表すクラス
    /// </summary>
    public class Customer
    {
        public Customer() { }

        public Customer(string customerCode, string customerName, string customerKana,
            int gender, string zipCode, string address1, string? address2,
            string tel, string? email, string? memo, DateTime inputDate)
        {
            CustomerCode = customerCode;
            CustomerName = customerName;
            CustomerKana = customerKana;
            Gender = gender;
            ZipCode = zipCode;
            Address1 = address1;
            Address2 = address2;
            Tel = tel;
            Email = email;
            Memo = memo;
            InputDate = inputDate;
        }

        /// <summary>
        /// 顧客番号
        /// </summary>
        public string? CustomerCode { get; set; }

        /// <summary>
        /// 顧客名
        /// </summary>
        public string? CustomerName { get; set; }

        /// <summary>
        /// 顧客名カナ
        /// </summary>
        public string? CustomerKana { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// 郵便番号f
        /// </summary>
        public string? ZipCode { get; set; }

        /// <summary>
        /// 住所１
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// 住所２
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string? Tel { get; set; }

        /// <summary>
        /// 電子メールアドレス
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// メモ
        /// </summary>
        public string? Memo { get; set; }

        /// <summary>
        /// 申込日
        /// </summary>
        public DateTime InputDate { get; set; }
    }
}
