using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;
using System.Diagnostics;

namespace YokoamiPetWebTest
{
    internal class DbServiceDataServiceTests
    {
        [Test]
        public void GetListTest()
        {
            DbServiceDataService service = new DbServiceDataService();

            List<Service> services = service.GetList();

            foreach (var item in services)
            {
                Console.WriteLine(
                    $"{item.Id}, {item.Name}, {item.Price}, {item.Status}");
            }
        }
        [Test]
        public void GetByIDTest()
        {
            DbServiceDataService service = new DbServiceDataService();

            Service? services = service.GetById(1);

            if (service == null)
            {
                Console.WriteLine("NG: service が null です。");
            }
            else
            {
                Console.WriteLine($"Id: {services.Id}");
                Console.WriteLine($"Name: {services.Name}");
                Console.WriteLine($"Price: {services.Price}");
                Console.WriteLine($"Status: {services.Status}");
            }
        }
        [Test]
        public void GetByID_該当のIDが登録されていない()
        {
            DbServiceDataService service = new DbServiceDataService();

            Service? services = service.GetById(999);

            if (services == null)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NG");
            }
        }
        [Test]
        public void RegisterTest()
        {
            DbServiceDataService dataService = new DbServiceDataService();

            Service service = new Service
            {
                Name = "単体テスト用",
                Price = 9999,
                Status = true
            };

            dataService.Register(service);

            Console.WriteLine("登録処理が完了しました");
        }
        [Test]
        public void Register_名前が入力されていない()
        {
            DbServiceDataService dataService = new DbServiceDataService();

            try
            {
                Service service = new Service
                {
                    Name = null,
                    Price = 9999,
                    Status = true
                };

                dataService.Register(service);

                Console.WriteLine("登録されました");
            }
            catch
            {
                Console.WriteLine("例外エラーが発生しました。");
            }
        }
        [Test]
        public void Register_料金が入力されていない()
        {
            DbServiceDataService dataService = new DbServiceDataService();

            try
            {
                Service service = new Service
                {
                    Name = "単体テスト用",
                    Price = null,
                    Status = true
                };

                dataService.Register(service);

                Console.WriteLine("登録されました");
            }
            catch
            {
                Console.WriteLine("例外エラーが発生しました");
            }
        }

        [Test]
        public void UpdateTest()
        {
            DbServiceDataService dataService = new DbServiceDataService();

            Service service = new Service
            {
                Id = 1,
                Name = "更新後",
                Price = 8888,
                Status = false
            };

            dataService.Update(service);

            Service? updatedService = dataService.GetById(1);

            if (updatedService == null)
            {
                Console.WriteLine("NG: 更新後データが取得できません。");
            }
            else
            {
                Console.WriteLine($"Id:{updatedService.Id}");
                Console.WriteLine($"Name:{updatedService.Name}");
                Console.WriteLine($"Price:{updatedService.Price}");
                Console.WriteLine($"Status:{updatedService.Status}");
            }
        }
        [Test]
        public void Update_該当のIdが存在しない()
        {
            DbServiceDataService dataService = new DbServiceDataService();

            Service service = new Service
            {
                Id = 999,
                Name = "更新後",
                Price = 8888,
                Status = false
            };

            dataService.Update(service);

            Console.WriteLine("OK: 例外は発生しませんでした。");
        }
    }
}
