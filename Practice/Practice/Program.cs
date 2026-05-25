namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> people = new();

            people.Add(person);
            people.Add(person);

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}
