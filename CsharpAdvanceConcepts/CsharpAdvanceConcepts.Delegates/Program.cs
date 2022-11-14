namespace CsharpAdvanceConcepts.Delegates
{
    public delegate int Calculator(int firstNum, int secondNum);  // Declaring delegate signature
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum = " + Calculate(10, 20, Add));
            Console.WriteLine("Sub = " + Calculate(10, 20, Subtract));
            Console.WriteLine("Mul = " + Calculate(10, 20, Multiply));

            var result = Calculate(10, 5, Add);
            Console.WriteLine("Sum = " + result);
        }

        // Delegate Handler function
        public static int Calculate(int firstNum, int secondNum, Calculator calculateFunction)
        {
            int result = calculateFunction(firstNum, secondNum);   // It will call whichever function it gets from Main()
            return result;
        }

        // Some methods
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public static int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        public static int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
    }
}