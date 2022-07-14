using System;

namespace HelloFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 3, 4, 9, 19, 33, 75};
            // Console.WriteLine("Enter x: ");
            // int x = Convert.ToInt32(Console.ReadLine());
            // int position = Search(a, x);
            // if (position == -1) Console.WriteLine("Not found");
            // else Console.WriteLine("Found at " + position);

            // Console.WriteLine("Sum of array: " + Sum(a));
            // Ask user to choose even or odd then call SearchEvenOdd function
            Console.WriteLine("Which type of sum/count do you want?");
            Console.WriteLine("1. Even");
            Console.WriteLine("2. Odd");
            int choice = Convert.ToInt32(Console.ReadLine());
            const int EVEN = 1;
            const int ODD = 2;
            // if (choice == 1) Console.WriteLine("Sum of even numbers: " + SumEvenOrOdd(a, true));
            // else Console.WriteLine("Sum of odd numbers: " + SumEvenOrOdd(a, false));
            Console.WriteLine("Sum = " + SumEvenOrOdd(a, choice == EVEN));
            // Count of even or odd numbers in array
            Console.WriteLine("Count: " + CountEvenOrOdd(a, choice == EVEN));
        }
        static int Search(int[] arr, int x)
        {
            // find x in arr, return found index or -1 if not found
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i]) return i;
            }
            return -1;
        }
        // write a function to calculate sum of array
        static int Sum(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
                s = s + a[i];
            
            return s;
        }

        // write a function to calculate sum of even or odd numbers in array
        static int SumEvenOrOdd(int[] a, bool even)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 2 == 0) == even)
                    s += a[i];          
            }
            return s;
        }

        // write a function to count number of even or odd numbers in array
        static int CountEvenOrOdd(int[] a, bool even)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 2 == 0) == even)
                    count++;
            }
            return count;
        }
    }
}
