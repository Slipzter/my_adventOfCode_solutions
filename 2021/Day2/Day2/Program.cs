using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Timpa\source\csharp\AdventOfCode\2021\Day2\Day2\puzzle_input.txt");

            string[] test =
            {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"
            };

            int horizontalValue = 0;

            int depth = 0;

            int aimValue = 0;

            List<int> forward = new List<int>();

            List<int> up = new List<int>();

            List<int> down = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                char last = word[word.Length - 1];

                if (text[i].Contains("forward"))
                {
                    forward.Add((int)Char.GetNumericValue(last));
                }
                else if (text[i].Contains("up"))
                {
                    up.Add((int)Char.GetNumericValue(last));
                }
                else if (text[i].Contains("down"))
                {
                    down.Add((int)Char.GetNumericValue(last));
                }
            }

            horizontalValue = forward.Sum();

            if (up.Sum() > down.Sum())
            {
                depth = up.Sum() - down.Sum();
            }
            else if (up.Sum() < down.Sum())
            {
                depth = down.Sum() - up.Sum();
            }



            int result1 = horizontalValue * depth;


            // First result = 1989014
            Console.WriteLine("First output: " + result1);

            horizontalValue = 0;

            depth = 0;

            aimValue = 0;

            forward.Clear();
            up.Clear();
            down.Clear();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                char last = word[word.Length - 1];

                if (text[i].Contains("forward"))
                {
                    if (aimValue < 0)
                    {
                        aimValue = 0;
                    }
                    horizontalValue += (int)Char.GetNumericValue(last);
                    depth += aimValue * (int)Char.GetNumericValue(last);
                    //forward.Add((int)Char.GetNumericValue(last));
                }
                else if (text[i].Contains("up"))
                {
                    if (aimValue < 0)
                    {
                        aimValue = 0;
                    }
                    aimValue -= (int)Char.GetNumericValue(last);
                    
                    //aim.Add(-(int)Char.GetNumericValue(last));
                }
                else if (text[i].Contains("down"))
                {
                    aimValue += (int)Char.GetNumericValue(last);
                    //aim.Add((int)Char.GetNumericValue(last));
                }
            }




            int result2 = horizontalValue * depth;

            // Second result: 2006917119
            Console.WriteLine("Second output: " + result2);










            Console.ReadLine();

            

        }
    }
}
