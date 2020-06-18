using System;
using System.Collections.Generic;

namespace sim_movement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Please enter the table size: ");
            // string tableSize = Console.ReadLine();
            // List<int> tableSizelist = ToIntList(tableSize);
            
            // Console.Write("Please enter the object's starting position: ");
            // string startingPostition = Console.ReadLine();
            // List<int> startingPositionList = ToIntList(startingPostition);

            RectangleTable rectangle = new RectangleTable("rectangle");
            rectangle.computeMatrix(4, 4);

    

        }

        
        private static List<int> ToIntList(string input)
        {
            string[] numbersAsStr = input.Split(",");
            List<int> nums = new List<int>();
            int oneNum;
            foreach(string numberAsString in numbersAsStr)
            {
                if (Int32.TryParse(numberAsString, out oneNum))
                    nums.Add(oneNum); 
                    Console.WriteLine(oneNum);
            }
            return nums;
        }
    }
}
