using System;
using System.Collections.Generic;

namespace sim_movement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Please enter the table size and the starting position of the object: ");
      string tableSize = Console.ReadLine();
      List<int> initializationParameters = ToIntList(tableSize);
      RectangleTable rectangle = new RectangleTable();
      rectangle.ComputeMatrix(initializationParameters[0], initializationParameters[1], initializationParameters[2], initializationParameters[3]);

      Console.Write("Please enter the commands: ");
      string commandsStr = Console.ReadLine();
      List<int> commands = ToIntList(commandsStr);
      foreach (var command in commands)
      {
        rectangle.CommandObject(command);
      }
    }

    private static List<int> ToIntList(string input)
    {
      string[] numbersAsStr = input.Split(",");
      List<int> nums = new List<int>();
      int oneNum;
      foreach (string numberAsString in numbersAsStr)
      {
        if (Int32.TryParse(numberAsString, out oneNum))
          nums.Add(oneNum);
      }
      return nums;
    }
  }
}
