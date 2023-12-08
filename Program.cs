namespace LinearEquationResolver
{
    public class Program
    {
        public static double GetConstantInput(string prompt)
        {
            // Return Result 
            double num;

        askNumInput:
            Console.Write($"{prompt}: ");
            bool issuccess = Double.TryParse(Console.ReadLine(), out num);
            if (!issuccess)
            {
                Console.WriteLine($"{prompt} Cannot Be A Character or String!");
                goto askNumInput;
            }

            return num;
        }

        public static void Main(string[] args)
        {
            // Print Out Headline
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants");

            // Get the constants
            double a = GetConstantInput("a");
            double b = GetConstantInput("b");

            // Validate a and b
            if (a != 0)
            {
                double result = -b / a;
                Console.Write($"The solution is {result}!");
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("No solution!");
                }
            }
        }
    }
}
