using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode_2021_day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of days: ");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Final count: " + maxCount(amount));

            // Antal efter 80 dagar: 345793

            // Antal efter 256 dagar: 

            Console.ReadKey();


            long[] convertFishes(List<int> fishes)
            {
                var fishGroups = new long[9];
                //return an array with the count of each
                //time to birth
                for (int i = 0; i < fishes.Count; i++)
                {
                    fishGroups[fishes[i]]++;
                }
                return fishGroups;
            }


            long maxCount(int days)
            {
                string[] input = System.IO.File.ReadAllText(@"C:\Users\Timpa\source\csharp\adventOfCode_2021_day6\input.txt").Split(',');

                ulong[] ints = Array.ConvertAll(input, s => ulong.Parse(s));

                List<int> fishes = Array.ConvertAll(input, s => int.Parse(s)).ToList();
                // fishes.AddRange(ints);

                int counter = 0;


                /*  
                
                Initial:
                3, 4, 3, 1, 2
                [0, 1, 1, 2, 1, 0, 0, 0, 0] 

                Day 1:
                2,3,2,0,1
                [1, 1, 2, 1, 0, 0, 0, 0, 0]

                Day 2:
                1,2,1,6,0,8
                [1, 2, 0, 0, 0, 0, 1, 0, 1]

                */
                long[] groups = convertFishes(fishes);
                //Array.ForEach(groups, g => Console.Write($"{g}, "));



                //for (int x = 0; x < days; x++)
                //{

                //    for (int i = 0; i < list.Count; i++)
                //    {
                //        if (list[i] == 0)
                //        {
                //            list[i] = 6;
                //            list.Add(9);
                //        }
                //        else
                //        {
                //            list[i] -= 1;
                //        }
                //    }

                //    foreach (var item in list)
                //    {
                //        if (item == 8)
                //        {
                //            counter++;
                //        }
                //    }
                //}
                //return list.Count;
                for (int i = 0; i < days; i++)
                {
                    long births = groups[0];
                    Array.Copy(groups, 1, groups, 0, groups.Length - 1);
                    groups[groups.Length - 1] = births;
                    groups[6] += births;
                    //Array.ForEach(groups, g => Console.Write($"{g}, "));
                }
                
                return groups.Sum();
            }
        }
    }
}
