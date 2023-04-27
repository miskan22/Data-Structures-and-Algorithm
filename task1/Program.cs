using System;
using static System.Console;
using System.IO;
namespace task1{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The numbers in the file are:");
            Task1();
            //ReadFile();
        }

        static void Task1()
        {
            string[]? lines = null;
            try {
                lines = File.ReadAllLines("data.txt");
            }catch (IOException e) {
                WriteLine(e.Source);
            }
            if (lines != null)
            {
                int[] numArr = Array.ConvertAll(lines, int.Parse);
                foreach(int i in numArr)
                {
                    Write(i + " ");//get numbers in the same line.
                }
                //numArr.ToList().ForEach(WriteLine);
                WriteLine();
                int num = numArr.Min();
                WriteLine($"The minimum number is {numArr.Min()}");

                int idx = Array.IndexOf(numArr, num);
                //WriteLine($"The minimum number index is" +idx.Min());
                WriteLine($"The minimum number index is {idx}");
            }
        }
    }
}

        // static void ReadFile() 
        // {
        //     string[]? lines = null;
        //     try {
        //         lines = File.ReadAllLines("data.txt");
        //     }catch (IOException e) {
        //         WriteLine(e.Source);
        //     }
        //     if (lines != null)
        //     {
        //         int[] numArr = Array.ConvertAll(lines, int.Parse);
        //         numArr.ToList().ForEach(WriteLine);
        //         int num = numArr.Min();
        //         WriteLine($"The minimum number is {numArr.Min()}");

        //         int idx = Array.IndexOf(numArr, num);
        //         //WriteLine($"The minimum number index is" +idx.Min());
        //         WriteLine($"The minimum number index is {idx}");
        //         foreach(int i in numArr)
        //         {
        //             Write(i + " ");//get numbers in the same line.
        //         }
        //     }
        // }