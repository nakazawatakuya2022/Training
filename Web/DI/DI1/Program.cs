namespace DI1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            Car car = new Car(engine);

            car.Run();
        }
    }
}
