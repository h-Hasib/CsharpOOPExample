namespace CsharpOOP.InheritancePolymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();

            zoo.Add(new Eagle());
            zoo.Add(new Tiger());

            foreach (var item in zoo)
            {
                Console.WriteLine(item.MakeSound());
            }
        }
    }
}