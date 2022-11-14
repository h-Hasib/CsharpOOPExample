namespace CsharpAdvanceConcepts.AnonymousMethods
{
    internal class Program
    {
        // #1 :: Delegates
        delegate int Calculate(int firstNum, int secondNum);

        static void Main(string[] args)
        {
            // #2 :: Anonymous Method
            // var addMethod = -------- [ OK ]
            Calculate addMethod = delegate (int firstNum, int secondNum)
            {
                return firstNum + secondNum;
            };

            int result = addMethod(1, 2);
            Console.WriteLine("Add = " + result);


            // ***  FUNC, ACTION are C# built-in delegates ***
            // Func <> -> has return type
            // Action <> -> return type : VOID
            // Doesn't need Explicit Delegate signature declaration
            // Func<param1, param2, ....., returnType> anonymousFuncName = delegate anonymousFunction(){}
            Func<int, double, double> divisionMethod = delegate (int dividend, double divisor)
            {
                double result = dividend / divisor;
                return result;
            };
            Console.WriteLine("Div = " + divisionMethod(35, 7));

            Action<string> randomMethod = delegate (string aString)
            {
                Console.WriteLine($"I'm here for {aString}");
            };

            randomMethod("Hasib");


            // #3 :: Lambda Expression/Statement  ( => )

            // Statement
            Func<string, string, string> GetFullName = (firstName, lastName) =>
            {
                string fullName = firstName + " " + lastName;
                return fullName;
            };
            Console.WriteLine("Name: " + GetFullName("Hasibul", "Hasan"));

            // Expression
            Func<double, double> Square = (x) => x * x;
            Console.WriteLine("Square = " + Square(5));

        }
    }
}