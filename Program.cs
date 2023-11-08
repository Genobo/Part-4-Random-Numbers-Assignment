using System.Runtime.CompilerServices;

namespace Part_4_Random_Numbers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int minNum;
            int maxNum;
            Console.WriteLine("Please enter a minimum and maximum value below");
            Console.WriteLine("Enter a minimum value:");
            minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum value:");
            maxNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(generator.Next(minNum, maxNum) + " ");
            Console.Write(generator.Next(minNum, maxNum) + " ");
            Console.Write(generator.Next(minNum, maxNum) + " ");
            Console.Write(generator.Next(minNum, maxNum) + " ");
            Console.Write(generator.Next(minNum, maxNum) + " ");
            Console.WriteLine();
            Console.WriteLine("Now enter in two decimal values using the minimum and maximum values");
            minNum = Convert.ToInt32(Console.ReadLine());
            maxNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(generator.Next(minNum, maxNum) + " ");
            Console.Write(generator.Next(minNum, maxNum) + " ");
            Console.Write(generator.Next(minNum, maxNum) + " ");
        }
    }
}