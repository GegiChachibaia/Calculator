namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Welcome to my calculator app");
                Console.WriteLine("-------------------------------");
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.Write("Enter number 1: ");
                double.TryParse(Console.ReadLine(), out num1);

                Console.Write("Enter number 2: ");
                double.TryParse(Console.ReadLine(), out num2);

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Substraciton");
                Console.WriteLine("\t/ : Division");
                Console.WriteLine("\t* : Multiplication");
                Console.Write("Enter an option: ");
            do
            {

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid  option, please try again");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = no)");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thanks!");
            Console.ReadKey();
        }
    }
}
