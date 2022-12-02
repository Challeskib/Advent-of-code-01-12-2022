using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_of_code_01
{
    class Program
    {
        static void Main(string[] args)
        {


            int sum = 0;

            int thirdLargestSum = 0;
            int secondLargestSum = 0;
            int largestSum = 0;

            List<int> elfList = new List<int>();


            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"C:/Users/GayLord/Desktop/food.txt"))
            {

                //If the line is not null
                if (line != "")
                {
                    //convert the lineValue to int
                    int lineValue = int.Parse(line);
                    //Console.WriteLine(lineValue);
                    sum = sum + lineValue;

                }
                else
                {
                    if (sum > largestSum)
                    {
                        largestSum = sum;
                    }
                    elfList.Add(sum);
                    sum = 0;
                }

            }

            Console.WriteLine($"Älvan som bär mest antal kalorier = {elfList.ElementAt(248)} kalorier");

            elfList.Sort();

            Console.WriteLine($"Det finns {elfList.Count} älvor i listan");
            

            int greatestElfs = elfList.ElementAt(246) + elfList.ElementAt(247) + elfList.ElementAt(248);

            Console.WriteLine($"Totala antal kalorier = {greatestElfs}");
        }
    }
}
