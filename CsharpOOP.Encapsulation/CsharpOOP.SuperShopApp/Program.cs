namespace CsharpOOP.SuperShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inputProduct = true;
            int i = 1;

            Console.WriteLine("Shop Information: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine();

            Shop shop = new Shop(name, address);

            Console.WriteLine("Product Information:");
            do
            {
                Console.WriteLine($"Product {i}:");
                Console.Write("Product/Item Id: ");
                string productId = Console.ReadLine();
                Console.Write("Quantity: ");
                int quantity = Int32.Parse(Console.ReadLine());

                Product product = new Product(productId, quantity);

                string feedback = shop.AddProduct(product);
                if (feedback == "Updated")
                {
                    Console.WriteLine($"Product updated.");
                }
                else if (feedback == "Added")
                {
                    Console.WriteLine($"Product {i} added.");
                    i++;
                }
                else
                {
                    Console.WriteLine("Sorry!");
                }

                Console.WriteLine();
                Console.Write("Want to add more product?(y/n)__");
                string choice = Console.ReadLine();

                if (choice == "y")
                {
                    inputProduct = true;
                }
                else
                {
                    inputProduct = false;
                }
            } while (inputProduct);

            Console.WriteLine();
            Console.WriteLine(shop.GetInfo());
        }
    }
}