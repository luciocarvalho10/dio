using Classes.Herança;

namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      // HERANÇA
      Ponto p1 = new Ponto(10 ,20);
      // p1.PodeSerSobrescritoDistancia3();
      // p1.x;
      // p1.y;

      Ponto p2 = new Ponto3D(5, 10, 15);
      // p2.PodeSerSobrescritoDistancia3();
      // p2.x;
      // p2.y;

      Ponto3D p3 = new Ponto3D(10 ,20, 30);
      // p3.PodeSerSobrescritoDistancia3();
      // p3.x;
      // p3.y;
      // p3.z;

      // função static
      Ponto3D.Calcular();
    }
  }
}
