using System;

namespace calculator
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[2]; // Creating the array of user-inputted numbers, integers only
            Console.WriteLine("Type add, subtract, multiply, or divide:");
            string operation = Console.ReadLine();
            Console.Write("Enter first number: ");
            nums[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            nums[1] = int.Parse(Console.ReadLine());
            if(operation == "add")
            {
                int result = add(nums);
                Console.WriteLine($"Sum: {result}"); // outputting sum to the console
            }
            else if (operation == "subtract")
            {
                int result = subtract(nums);
                Console.WriteLine($"Difference: {result}"); // outputting difference to the console
            }
            else if (operation == "multiply")
            {
                int result = multiply(nums);
                Console.WriteLine($"Product: {result}"); // outputting product to the console
            }
            else if (operation == "divide")
            {
                float result = divide(nums); // Result set to float in order to capture decimal quotient
                Console.WriteLine($"Quotient: {result}"); // outputting quotient to the console
            }
            else
            {
                Console.WriteLine("Please enter a valid operator.");
            }
            Main(); // Use recursion to run the method again, allowing for further operations
        }
        public static int add(int[] nums)
        {
            int result = 0;
            foreach(int num in nums) 
            {
                result += num; // for each value in the inputted array, add it to the total
            }
            return result;
        }
        public static int subtract(int[] nums)
        {
            return nums[0]-nums[1]; // simple difference of first two values of input array
        }
        public static int multiply(int[] nums)
        {
            int result = 1;
            foreach (int num in nums)
            {
                result *= num; // for each value in the inputted array, multiply it into the total
            }
            return result;
        }
        public static float divide(int[] nums)
        {
            float result = (float)nums[0] / (float)nums[1]; // cast numbers to floats in order to get decimal values of simple quotient of first two input array values
            return result;
        }
    }
}
