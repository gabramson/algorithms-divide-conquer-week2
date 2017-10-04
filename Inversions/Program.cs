using System;
using System.IO;

namespace Inversions
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberList numberList = new NumberList();
            string line;

            using (StreamReader srStreamRdr = new StreamReader(@"D:\Projects\C#\Coursera\algorithms-divide-conquer\Week2\IntegerArray.txt"))
            {
                while ((line = srStreamRdr.ReadLine()) != null)
                {
                    numberList.Add(int.Parse(line));
                }
            }
            Console.WriteLine(numberList.Inversions());
            Console.ReadKey();

        }
    }
}
