using System;

public class RectangleTable : BasicTable
{
  private int[,] matrix;

  public RectangleTable(){}

  public void ComputeMatrix(int width, int height, int x, int y)
  {
    matrix = new int[width, height];

    currentObjectPosition[0] = x;
    currentObjectPosition[1] = y;
    matrix[x, y] = 1;
  }

  // maybe we should decompose this so its easier to extend functionality such as rotating the table instead of the object
  public override void CommandObject(int command)
  {
    switch (command)
    {
      case 0:
        // Console.WriteLine("Quitting simulation");
        Console.WriteLine("[{0}, {1}]", currentObjectPosition[1], currentObjectPosition[0]);
        Environment.Exit(1);
        break;
      case 1:
        // Console.WriteLine("Current object direction: " + (Direction)currentObjectDirection);
        try
        {
          moveForward();
        }
        catch (IndexOutOfRangeException)
        {
          Console.WriteLine("[-1, -1]");
          Environment.Exit(1);
        }
        break;
      case 2:
        // Console.WriteLine("Current object direction: " + (Direction)currentObjectDirection);
        try
        {
          moveBackward();
        }
        catch (IndexOutOfRangeException)
        {
          Console.WriteLine("[-1, -1]");
          Environment.Exit(1);
        }
        break;
      case 3:
        // Console.WriteLine("Rotating clockwise 90 degrees");
        if (currentObjectDirection < 3)
        {
          currentObjectDirection++;
        }
        else
        {
          currentObjectDirection = 0;
        }
        // Console.WriteLine("Current object direction: " + (Direction)currentObjectDirection);
        break;
      case 4:
        if (currentObjectDirection > 0)
        {
          currentObjectDirection--;
        }
        else
        {
          currentObjectDirection = 3;
        }
        // Console.WriteLine("Rotating counterclockwise 90 degrees");
        // Console.WriteLine("Current object direction: " + (Direction)currentObjectDirection);
        break;
      default:
        Console.WriteLine("Default case");
        break;
    }
  }

  private void moveForward()
  {
    // visualizeMatrix();
    // Console.WriteLine("Moving forward 1 step");
    if (currentObjectDirection == 0)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[--currentObjectPosition[0], currentObjectPosition[1]] = 1;
    }
    else if (currentObjectDirection == 1)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[currentObjectPosition[0], ++currentObjectPosition[1]] = 1;
    }
    else if (currentObjectDirection == 2)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[++currentObjectPosition[0], currentObjectPosition[1]] = 1;
    }
    else if (currentObjectDirection == 3)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[currentObjectPosition[0], --currentObjectPosition[1]] = 1;
    }
    // Console.WriteLine("-----------");
    // visualizeMatrix();
  }

  private void moveBackward()
  {
    // visualizeMatrix();
    // Console.WriteLine("Moving backward 1 step");
    if (currentObjectDirection == 0)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[++currentObjectPosition[0], currentObjectPosition[1]] = 1;
    }
    else if (currentObjectDirection == 1)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[currentObjectPosition[0], --currentObjectPosition[1]] = 1;
    }
    else if (currentObjectDirection == 2)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[--currentObjectPosition[0], currentObjectPosition[1]] = 1;
    }
    else if (currentObjectDirection == 3)
    {
      matrix[currentObjectPosition[0], currentObjectPosition[1]] = 0;
      matrix[currentObjectPosition[0], ++currentObjectPosition[1]] = 1;
    }
    // Console.WriteLine("-----------");
    // visualizeMatrix();
  }

  public override void VisualizeMatrix()
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

  public override void RotateTable(int direction)
  {
    throw new NotImplementedException();
  }

  public override void MoveObject(int direction)
  {
    throw new NotImplementedException();
  }
}