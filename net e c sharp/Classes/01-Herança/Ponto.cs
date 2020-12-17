namespace Classes.Herança
{
  public class Ponto
  {
    public int x, y;
    private int distancia;
    // private int _distancia;

    public Ponto(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    protected void HerancaDaClassePontoDistancia(){}
    private void ExclusivoDaClassePontoDistancia2(){}
    public virtual void PodeSerSobrescritoDaClassePontoDistancia3(){}
  }
}