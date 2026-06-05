using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;
using System.Diagnostics;

namespace YokoamiPetWebTest
{
    public class DbHistoryDataServiceTests
    {
        [Test]
        public void GetListTest()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            List<History> histories = service.GetList();

            foreach (var history in histories)
            {
                Console.WriteLine(
                    $"{history.Id}, {history.PetId}, {history.ServiceId}, {history.ServiceDate}, {history.OwnerName}, {history.PetName}, {history.ServiceName}, {history.Price}");
            }
        }

        [Test]
        public void GetByIdTest()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History? history = service.GetById(1);

            Console.WriteLine(
                $"{history.Id}, {history.PetId}, {history.ServiceId}, {history.ServiceDate}, {history.OwnerName}, {history.PetName}, {history.ServiceName}, {history.Price}");
        }
        [Test]
        public void GetByIdNotFoundTest()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History? history = service.GetById(99);

            if (history == null)
            {
                Console.WriteLine("nullです");
            }
        }

        [Test]
        public void Register_正常に登録できる()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History history = new History(0, 1, 1, new DateTime(2026, 6, 3, 10, 0, 0));

            service.Register(history);

            Console.WriteLine("登録処理を実行しました。");
        }

        [Test]
        public void Register_PetId異常()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History history = new History(0, 999, 1, new DateTime(2026, 6, 3, 10, 0, 0));

            try
            {
                service.Register(history);

                Console.WriteLine("登録成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine("登録失敗");
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void Register_サービスId異常()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History history = new History(0, 1, 999, new DateTime(2026, 6, 3, 10, 0, 0));

            try
            {
                service.Register(history);

                Console.WriteLine("登録成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine("登録失敗");
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void UpdateTest()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History history = new History(
                1,  // 更新対象ID
                1,
                2,
                new DateTime(2026, 6, 4, 10, 0, 0));

            service.Update(history);
            Console.WriteLine("更新処理を実行しました。");
        }

        [Test]
        public void Update_実施サービス履歴データが存在しない()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History history = new History(
                999,
                1,
                2,
                new DateTime(2026, 6, 4, 10, 0, 0));

            service.Update(history);
            Console.WriteLine("更新処理成功");
        }

        [Test]
        public void Update_ペットIdが存在しない()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History history = new History(
                1,
                999,
                2,
                new DateTime(2026, 6, 4, 10, 0, 0));
            try
            {
                service.Update(history);
                Console.WriteLine("更新処理成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine("更新処理失敗");
                Console.WriteLine(ex.Message);
            }
        }

        [Test]
        public void Update_サービスIdが存在しない()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            History history = new History(
                1,
                1,
                999,
                new DateTime(2026, 6, 4, 10, 0, 0));
            try
            {
                service.Update(history);
                Console.WriteLine("更新処理成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine("更新処理失敗");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void DeleteTest()
        {
            DbHistoryDataService service = new DbHistoryDataService();

            service.Delete(9);

            Console.WriteLine("削除処理成功");
        }

        [Test]
        public void Delete_実施サービス履歴データが存在しない()
        {
            DbHistoryDataService service = new DbHistoryDataService();
                
            service.Delete(999);
            Console.WriteLine("削除処理成功");
        }
    }
}

