using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;
using System.Diagnostics;

namespace YokoamiPetWebTest
{
    internal class DbPetServiceTests
    {
        [Test]
        public void GetListTest()
        {
            DbPetServices service = new DbPetServices();

            List<Pet> pets = service.GetList();

            foreach (var pet in pets)
            {
                Console.WriteLine(
                    $"{pet.Id}, {pet.Name}, {pet.OwnerId}, {pet.OwnerName}");
            }
        }
    }
}
