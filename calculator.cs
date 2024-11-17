  
   class Program  
      {
        static void Main(string[] args)
        {
            int num1, num2;
            string operation;
            Console.WriteLine("Enter the first number:");
            if (!Int32.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Console.WriteLine("Enter the second number:");
            if (!Int32.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Console.WriteLine("Enter the logical operation (&, |, ^):");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "&":
                    Console.WriteLine($"Result in decimal: {num1 & num2}");
                    Console.WriteLine($"Result in bimary: {Convert.ToString(num1 & num2, 2)}");
                    Console.WriteLine($"Result in hexadecimal: {Convert.ToString(num1 & num2, 16)}");
                    break;
                case "|":
                    Console.WriteLine($"Result in decimal: {num1 | num2}");
                    Console.WriteLine($"Result in bimary: {Convert.ToString(num1 | num2, 2)}");
                    Console.WriteLine($"Result in hexadecimal: {Convert.ToString(num1 | num2, 16)}");
                    break;
                case "^":
                    Console.WriteLine($"Result in decimal: {num1 ^ num2}");
                    Console.WriteLine($"Result in bimary: {Convert.ToString(num1 ^ num2, 2)}");
                    Console.WriteLine($"Result in hexadecimal: {Convert.ToString(num1 ^ num2, 16)}");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid operation (&, |, ^):");
                    break;
            }
        }
      }
 
