namespace DI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 問題点3. 使う側が毎回 new しなければならない
            // ・new を省略して <IEngine, Engine> って書けたらいいな
            // ・差し替える時は <IEngine, ElectricEngine> に変えるだけなら楽だな
            // ・これを実現するASP.NETの機能が DIコンテナ
            IEngine engine = new Engine();

            Car car = new Car(engine);

            car.Run();
        }
    }
}
