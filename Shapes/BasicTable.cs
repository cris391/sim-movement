public abstract class BasicTable
{
  protected int[] currentObjectPosition = new int[2];
  protected int currentObjectDirection = 0;

  public abstract void CommandObject(int command);

  public abstract void RotateTable(int direction);

  public abstract void MoveObject(int direction);
  
  public abstract void VisualizeMatrix();
}