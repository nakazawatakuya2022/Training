namespace YokoamiPetWeb.Models
{
    /// <summary>
    /// サービス情報を管理するモデル
    /// </summary>
    public class Service
    {
        /// <summary>
        /// サービスID
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// サービス名
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 料金
        /// </summary>
        public int? Price { get; set; }

        /// <summary>
        /// 利用状態
        /// true:利用可能
        /// false:利用停止
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 新規作成用コンストラクタ
        /// </summary>
        public Service()
        {
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        /// <param name="id">サービスID</param>
        /// <param name="name">サービス名</param>
        /// <param name="price">料金</param>
        /// <param name="status">利用状態</param>
        public Service(
            int id,
            string name,
            int price,
            bool status)
        {
            Id = id;
            Name = name;
            Price = price;
            Status = status;
        }
    }
}