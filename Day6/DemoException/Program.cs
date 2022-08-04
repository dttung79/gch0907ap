using System;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                // Enter array items
                for (int i = 0; i < 5; i++)
                {
                    // Console.Write("Enter arr[{0}]", i);
                    // arr[i] = Convert.ToInt32(Console.ReadLine());
                    arr[i] = InputInteger("Enter arr[" + i + "]");
                }
                // enter number n
                // Console.Write("Enter number n: ");
                int n = InputInteger("Enter number n: ");
                int count = 0;
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        sum += arr[i];
                        count++;
                    }
                }
                double avg = (double) sum / count;
                Console.WriteLine("Sum of even numbers: {0}", sum);
                Console.WriteLine("Average of even numbers: {0}", avg);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input error: {0}", ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array error: {0}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Operation error: {0}", ex.Message);
            }
        }

        static int InputInteger(string message)
        {
            int n = 0;
            bool invalid = true;
            while (invalid)
            {
                try 
                {
                    Console.Write(message);
                    n = Convert.ToInt32(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid integer format");
                }
            }
            return n;
        }
    }
}
