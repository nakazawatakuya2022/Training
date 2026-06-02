namespace YokoamiPetWeb.Models
{
    /// <summary>
    /// ペット情報を管理するモデル
    /// </summary>
    public class Pet
    {
        /// <summary>
        /// ペットID
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// ペット名
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 顧客ID
        /// </summary>
        public int? OwnerId { get; set; }

        /// <summary>
        /// 顧客名
        /// </summary>
        public string? OwnerName { get; set; }

        /// <summary>
        /// 新規作成用コンストラクタ
        /// </summary>
        public Pet()
        {
        }

        /// <summary>
        /// 一覧表示用コンストラクタ
        /// </summary>
        /// <param name="id">ペットID</param>
        /// <param name="name">ペット名</param>
        /// <param name="ownerId">顧客ID</param>
        /// <param name="ownerName">顧客名</param>
        public Pet(
            int id,
            string name,
            int ownerId,
            string ownerName)
        {
            Id = id;
            Name = name;
            OwnerId = ownerId;
            OwnerName = ownerName;
        }
    }
}