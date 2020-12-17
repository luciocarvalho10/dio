namespace Classes.Herança
{
  public class Ponto3D : Ponto //Herda da classa ponto
  {
    public int z;
    public Ponto3D(int x, int y, int z) : base(x, y)
    {
      this.z = z;
      HerancaDaClassePontoDistancia();
    }

    public static void Calcular(){}

    public override void PodeSerSobrescritoDistancia3()
    {
      //faz algo...
      base.PodeSerSobrescritoDaClassePontoDistancia3();
    }
  }
}