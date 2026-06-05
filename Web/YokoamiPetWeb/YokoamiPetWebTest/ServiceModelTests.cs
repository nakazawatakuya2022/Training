using YokoamiPetWeb.Models;
using System.Diagnostics;

namespace YokoamiPetWebTest
{
    internal class ServiceModelTests
    {
        [Test]
        public void Service_新規作成用コンストラクタ()
        {
            Service service = new Service();

            Console.WriteLine(
                $"{service.Id}, {service.Name}, {service.Price}, {service.Status}");
        }

        [Test]
        public void Service_更新用コンストラクタ()
        {
            Service service = new Service(
                1,
                "シャンプー",
                3000,
                true);

            Console.WriteLine(
                $"{service.Id}, {service.Name}, {service.Price}, {service.Status}");
        }
    }
}
