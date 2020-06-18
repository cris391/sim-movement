using System.Collections.Generic;

public abstract class Shape 
{
  /*
  Summary
  0 - quit simulation and print result
  1 - move forward 1 step
  2 - move backwards 1 step
  3 - rotate clockwise 90 degrees
  4 - rotate counterclockwise 90 degrees
  */
  private int currentObjectCommand = 0;

    // string name;
    string color = "black";

    // public Shape(string name) 
    // {
    //     this.name = name;
    // }

    // public abstract void setSize(params int[] values);
    public abstract void setSize(int width, int height);
    public abstract int[] getSize();

    public void setObjCommand(int input)
    {
        currentObjectCommand = input;
    }
    public int GetObjCommand()
    {
        return currentObjectCommand;
    }

    public abstract void commandObject(int command);
    public abstract int[,] computeMatrix(int width, int height);

    public void change_color(string color) 
    {
        this.color = color;
    }
}