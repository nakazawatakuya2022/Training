using YokoamiPetWeb.Models;
using System.Diagnostics;

namespace YokoamiPetWebTest
{
    internal class PetModelTests
    {
        [Test]
        public void Pet_新規作成用コンストラクタ()
        {
            Pet pet = new Pet();

            Console.WriteLine(
                $"{pet.Id}, {pet.Name}, {pet.OwnerId}, {pet.OwnerName}");
        }

        [Test]
        public void Pet_一覧表示用コンストラクタ()
        {
            Pet pet = new Pet(
                1,
                "ポチ",
                1,
                "内田 太郎");

            Console.WriteLine(
                $"{pet.Id}, {pet.Name}, {pet.OwnerId}, {pet.OwnerName}");
        }
    }
}
