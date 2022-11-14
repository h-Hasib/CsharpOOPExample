namespace CsharpAdvanceConcepts
{
    // Var - Dynamic
    internal class Program
    {
        static void Main(string[] args)
        {
            // var isn't a type. implicitly it checks the data type of *assigned-value and set the type to the variable 
            var product = new { Id = 101, Name = "Hexisol", Quantity = 500 };
            PrintProduct(product);
        }
        public static void PrintProduct(dynamic product)
        {
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Qunatity: {product.Quantity}");
        }
    }
}