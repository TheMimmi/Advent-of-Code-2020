using System;
using System.IO;
using System.Linq;


namespace day1
{
    public class tasks
    {
        public static void Part1()
        {
            string[] lines = File.ReadAllLines(@"../../../input.txt");
            foreach (string line in lines)
            {
                int entry1 = int.Parse(line);

                foreach (string line2 in lines)
                {
                    int entry2 = int.Parse(line2);
                    if (entry1 + entry2 == 2020)
                    {
                        Console.WriteLine("The two entries are "+ entry1 + " and " + entry2);
                        Console.WriteLine("The sum of the entries is "+ entry1 * entry2);
                        return;
                    }
                }
            }


        }


        public static void Part2()
        {
            string[] lines = File.ReadAllLines(@"../../../input.txt");
            foreach (string line in lines)
            {
                int entry1 = int.Parse(line);

                foreach (string line2 in lines)
                {
                    int entry2 = int.Parse(line2);
                    int entry3 = 2020 - entry1 - entry2;

                    if (lines.Contains(entry3.ToString()))
                    {
                        Console.WriteLine("The three entries are " + entry1 + " and " + entry2 + " and " + entry3);
                        Console.WriteLine("The sum of the entries is " + entry1 * entry2 * entry3);
                        return;
                    }

                }

            }
        }
    }
}
