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
    int[,] matrix = new int[4, 4];
    // int[,] matrix = new int[4, 4]{ { 1, 2, 3, 4 }, 
    //                                 { 5, 6, 7, 8 }, 
    //                                 { 9, 10, 11, 12 }, 
    //                                 { 13, 14, 15, 16 }
    //                                 };
    
    return matrix;
  }

  public void visualizeMatrix(int [,] matrix)
  {
    int rowLength = matrix.GetLength(0);
    int colLength = matrix.GetLength(1);
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(string.Format("{0} ", matrix[i, j]));
                // Console.Write(string.Format("{0} ", matrix[2, 1]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
  }

  public override void commandObject(int command)
  {

  }
}