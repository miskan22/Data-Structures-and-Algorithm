using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
namespace task2
{
    class Program
    {
        static void Main()
        {
            Task2();
        }

        static void Task2()
        {
            /* Task 2 pseudo code
            function LinearSearch(int[] a, int x)
            {
                foreach (int i in a)
                {
                    if (i == x)
                    {
                        WriteLine(x + " found");
                    }
                }
                WriteLine(x + " not found");
            }
            */
            int[] a = GenerateUniqueNumbers(5);
            a.ToList().ForEach(n => Write(n + " "));
            CountPrime(a);
            SegregateEvenOdd(a, 0, a.Length - 1);
            WriteLine($"Array elements after segregation");
            a.ToList().ForEach(n => Write(n + " "));
        }
        static int[] GenerateUniqueNumbers(int size)
        {
            Random random = new Random();
            HashSet<int> values = new HashSet<int>();
            while (true)
            {
                values.Add(random.Next(1, 100));
                if (values.Count == size) break;
            }
            return values.ToArray();
        }
        static bool IsPrime(int n)//determine this primeter
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            //all even numbers (except 2) are not prime
            if (n % 2 == 0) return false;
            for (int i = 3; i < Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        static void SegregateEvenOdd(int[] arr, int left, int right)
        {
            while (arr[left] % 2 == 0) left++;
            while (arr[right] % 2 == 1) right--;
            if (left >= right) return;
            //swap arr[left] with arr[right]
            int t = arr[left];
            arr[left] = arr[right];
            arr[right] = t;
            SegregateEvenOdd(arr, left, right);
        }
        static void CountPrime(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (IsPrime(a[i]))
                {
                    count++;
                }
            }
            WriteLine();
            WriteLine($"Count of prime numbers:" + count);

        }
    }
}