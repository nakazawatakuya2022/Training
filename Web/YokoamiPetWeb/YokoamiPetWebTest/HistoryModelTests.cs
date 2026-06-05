using YokoamiPetWeb.Models;
using System.Diagnostics;

namespace YokoamiPetWebTests
{
    // Historyモデルはコンストラクタによる値設定のみで、
    // 入力チェックや例外処理を持たないため正常系のみ実施しました
    
    internal class HistoryModelTests
    {
        [Test]
        public void History_一覧表示用コンストラクタ()
        {
            History history = new History(
                1,
                1,
                3,
                new DateTime(2018, 6, 30, 12, 30, 0),
                "内田 太郎",
                "ペット1号",
                "しつけ教室",
                8000);

            Console.WriteLine(
                $"{history.Id}, {history.PetId}, {history.ServiceId}, {history.ServiceDate}, {history.OwnerName}, {history.PetName}, {history.ServiceName}, {history.Price}");
        }

        [Test]
        public void History_新規追加用コンストラクタ()
        {
            History history = new History();

            Console.WriteLine(
                $"{history.Id}, {history.PetId}, {history.ServiceId}, {history.ServiceDate}");
        }

        [Test]
        public void History_更新用コンストラクタ()
        {
            History history = new History(
                1,
                1,
                3,
                new DateTime(2018, 6, 30, 12, 30, 0));

            Console.WriteLine(
                $"{history.Id}, {history.PetId}, {history.ServiceId}, {history.ServiceDate}");
        }
    }
}
