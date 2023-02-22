using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode_2022_day5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> one = new List<string> { "B", "V", "S", "N", "T", "C", "H", "Q" };
            List<string> two = new List<string> { "W", "D", "B", "G" };
            List<string> three = new List<string> { "F", "W", "R", "T", "S", "Q", "B" };
            List<string> four = new List<string> { "L", "G", "W", "S", "Z", "J", "D", "N" };
            List<string> five = new List<string> { "M", "P", "D", "V", "F" };
            List<string> six = new List<string> { "F", "W", "J" };
            List<string> seven = new List<string> { "L", "N", "Q", "B", "J", "V" };
            List<string> eight = new List<string> { "G", "T", "R", "C", "J", "Q", "S", "N" };
            List<string> nine = new List<string> { "J", "S", "Q", "C", "W", "D", "M" };


            List<string> stringList = System.IO.File.ReadAllLines(@"C:\Users\Timpa\source\csharp\adventOfCode_2022_day5\adventOfCode_2022_day5.txt").ToList();
            //lines = System.IO.File.ReadAllLines(@"C:\Users\Timpa\source\csharp\adventOfCode_2022_day5\adventOfCode_2022_day5.txt");

            List<int> intList = new List<int>();

            char firstNumber;
            char secondNumber;
            char thirdNumber;

            for (int i = 0; i < stringList.Count; i++)
            {
                stringList[i] = stringList[i].Replace("move ", "");
                stringList[i] = stringList[i].Replace("from ", "");
                stringList[i] = stringList[i].Replace("to ", "");

                foreach (string item in stringList)
                {
                    if (item != " ")
                    {
                        intList[i] = Int32.Parse(stringList[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
                
                
                Console.WriteLine(intList[i]);
            }

           
            //List<int> intList = stringList.ConvertAll(int.Parse);

            //for (int i = 0; i < intList.Count; i++)
            //{
            //    firstNumber = lines[i][0];
            //    secondNumber = lines[i][2];
            //    thirdNumber = lines[i][4];

            //    Console.WriteLine(intLines[i]);
                
            //}



            Console.ReadKey();


            void moveBoxes(int amount, int fromStack, int toStack)
            {
                
            }
        }
    }
}
