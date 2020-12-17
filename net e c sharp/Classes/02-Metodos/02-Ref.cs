namespace Classes.Metodos{
  public class Out{
    static void Dividir(int x, int y, out int res, out int ext){
      res = x / y;
      ext = x % y;
    }

    public static void Dividir(){
      Dividir(10, 3, out int res, out int ext);
      System.Console.WriteLine("{0} {1}", res, ext);
    }
  }
}
