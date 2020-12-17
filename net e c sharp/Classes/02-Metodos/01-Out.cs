namespace Classes.Metodos
{
  public class Ref
  {
    static void Inverter(ref int x, ref int y)
    {
      int temp = x;
      x = y;
      y = temp;
    }

    public static void Inverter()
    {
      int xx = 1, yy = 2;
      Inverter(ref xx, ref yy);
      // Escreve "2 1"
      System.Console.WriteLine($"i = {xx} | j = {yy} ???");
    }
  }
}
