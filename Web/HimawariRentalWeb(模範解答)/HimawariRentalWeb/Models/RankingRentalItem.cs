using System.ComponentModel.DataAnnotations;

namespace HimawariRentalWeb.Models
{
    /// <summary>
    /// レンタル回数を加えたレンタル品を表すクラス
    /// </summary>
    public class RankingRentalItem : RentalItem
    {
        RankingRentalItem() { }

        public RankingRentalItem(int rentalItemId, string management_code, string item_name, string maker,
            string storage_location, DateTime purchaseDate, int purchasePrice,
            string? memo, int categoryId, string categoryName, bool rentalFlag, 
            int rentalTimes) : base(
                rentalItemId, management_code, item_name, maker, storage_location, purchaseDate, 
                purchasePrice, memo, categoryId, categoryName, rentalFlag)
        {
            RentalTimes = rentalTimes;
        }

        /// <summary>
        /// レンタル回数
        /// </summary>
        public int RentalTimes { get; set; }
    }
}
