using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode_2021_day1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Timpa\source\csharp\adventOfCode_2021_day1\adventOfCode_2021_day1\puzzle_input.txt");

            int[] ints = Array.ConvertAll(lines, s => int.Parse(s));

            int counter = 0;

            int[] test = new int[10] {199,
                            200,
                            208,
                            210,
                            200,
                            207,
                            240,
                            269,
                            260,
                            263};

            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i - 1] < ints[i])
                {
                    counter++;
                }
            }

            // First answer: 1301

            Console.WriteLine("Total measurements larger than the previous one: " + counter);

            List<int> threeSums = new List<int>();

            int threeCounter = 0;

            for (int i = 0; i < ints.Length - 2; i++)
            {
                threeSums.Add(ints[i] + ints[i + 1] + ints[i + 2]);
            }

            for (int i = 1; i < threeSums.Count; i++)
            {
                if (threeSums[i - 1] < threeSums[i])
                {
                    threeCounter++;
                }
            }

            //Second answer: 1346

            Console.WriteLine("Total three-measurements larger than the previous one: " + threeCounter);


            Console.ReadLine();
        }
    }
}
