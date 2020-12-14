using System;
using System.IO;
using System.Linq;

namespace day2

{
    public class Tasks
    {
        public static void Part1()
        {
            var lines = File.ReadAllLines(@"../../../input.txt");
            int validPassports = 0;

            foreach (string line in lines){

                string[] data = line.Split(" ");
                string[] range = data[0].Split("-");
                int low = int.Parse(range[0]);
                int high = int.Parse(range[1]);
                char letter = data[1].ToCharArray()[0];
                string password = data[2];
                int letterCount = password.Count(c=> c == letter);
                if (letterCount >= low && letterCount <= high)
                {
                    validPassports++;
                }
            }

            Console.WriteLine("There are " + validPassports + " valid passports");
            return;


        }

        public static void Part2()
        {
            var lines = File.ReadAllLines(@"../../../input.txt");
            int validPassports = 0;

            foreach (string line in lines)
            {

                string[] data = line.Split(" ");
                string[] range = data[0].Split("-");
                int low = int.Parse(range[0]);
                int high = int.Parse(range[1]);
                char letter = data[1].ToCharArray()[0];
                char[] password = data[2].ToCharArray();

                if (password[low-1] == letter ^ password[high-1] == letter){            
                    validPassports++;
                }
            }

            Console.WriteLine("There are " + validPassports + " valid passports");
            return;


        }
    }
}
