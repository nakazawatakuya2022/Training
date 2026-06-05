using System.ComponentModel.DataAnnotations;

namespace YokoamiPetWeb.Models
{
    /// <summary>
    /// 実施サービス履歴を管理するモデル
    /// </summary>
    public class History
    {
        /// <summary>
        /// 実施サービスID
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// ペットID
        /// </summary>
        [Required(ErrorMessage = "ペットを選択してください")]
        public int? PetId { get; set; }

        /// <summary>
        /// サービスID
        /// </summary>
        [Required(ErrorMessage = "サービスを選択してください")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 実施日時
        /// </summary>
        [Required(ErrorMessage = "実施日時を入力してください")]
        public DateTime? ServiceDate { get; set; }

        /// <summary>
        /// 顧客名
        /// </summary>
        public string? OwnerName { get; set; }

        /// <summary>
        /// ペット名
        /// </summary>
        public string? PetName { get; set; }

        /// <summary>
        /// サービス名
        /// </summary>
        public string? ServiceName { get; set; }

        /// <summary>
        /// 料金
        /// </summary>
        public int? Price { get; set; }

        /// <summary>
        /// 一覧表示用コンストラクタ
        /// </summary>
        public History(
            int id,
            int petId,
            int serviceId,
            DateTime serviceDate,
            string ownerName,
            string petName,
            string serviceName,
            int price)
        {
            Id = id;
            PetId = petId;
            ServiceId = serviceId;
            ServiceDate = serviceDate;
            OwnerName = ownerName;
            PetName = petName;
            ServiceName = serviceName;
            Price = price;
        }

        /// <summary>
        /// 新規追加用コンストラクタ
        /// </summary>
        public History()
        {
        }

        /// <summary>
        /// 更新用コンストラクタ
        /// </summary>
        public History(
            int id,
            int petId,
            int serviceId,
            DateTime serviceDate)
        {
            Id = id;
            PetId = petId;
            ServiceId = serviceId;
            ServiceDate = serviceDate;
        }
    }
}