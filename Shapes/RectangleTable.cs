using System;

public class RectangleTable : Shape
{
  private string name;
  private int width;
  private int height;
  private int[] currentObjectPosition = {0, 0};

  public RectangleTable(string name)
  {
    this.name = name;
  }


  public override void setSize(int width, int height)
  {
    this.width = width;
    this.height = height;
  }

  public override int[] getSize()
  {
    return new int[] { width, height };
  }

  public override int[,] computeMatrix(int width, int height)
  {
    // int[,] matrix = new int[4, 4];
    int[,] matrix = new int[4, 4]{ { 1, 2, 3, 4 }, 
                                    { 5, 6, 7, 8 }, 
                                    { 9, 10, 11, 12 }, 
                                    { 13, 14, 15, 16 }
                                    };
    // double[,] matrix = new double[width, height];
    // The same array with dimensions specified.
    // int[, ,] array3Da = new int[4, 4, 2] {
    //                                         { { 1, 2}, { 4, 5 }, { 4, 5 }, { 4, 5 }  },
    //                                         { { 7, 8}, { 10, 11}, { 4, 5 } , { 4, 5 } }, 
    //                                         { { 7, 8}, { 10, 11}, { 4, 5 } , { 4, 5 } },
    //                                         { { 7, 8}, { 10, 11}, { 4, 5 } , { 4, 5 } } 
    //                                    };
    // int[, ,] array3Da = new int[4, 4, 2];
    // Console.WriteLine(array3Da.GetLength(0));
    // Console.WriteLine(array3Da.GetLength(1));

    int rowLength = matrix.GetLength(0);
    int colLength = matrix.GetLength(1);
    // int rowLength = array3Da.GetLength(0);
    // int colLength = array3Da.GetLength(1);

        // for (int i = 0; i < rowLength; i++)
        // {
        //     for (int j = 0; j < colLength; j++)
        //     {
        //         // Console.Write(string.Format("{0} ", matrix[i, j]));
        //         matrix[i, j] = 0.10;
        //     }
        //     // Console.Write(Environment.NewLine + Environment.NewLine);
        // }

        // for (int i = 0; i < rowLength; i++)
        // {
        //     for (int j = 0; j < colLength; j++)
        //     {
        //         // Console.Write(string.Format("{0} ", matrix[i, j]));
        //         Console.Write(string.Format("{0} ", array3Da[i, j, 1]));
        //     }
        // }

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                // Console.Write(string.Format("{0} ", matrix[i, j]));
                Console.Write(string.Format("{0} ", matrix[2, 1]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    
    return new int[,] { {}, {} };
  }

  public override void commandObject(int command)
  {

  }
}