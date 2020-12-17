using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
  class Program
  {
    static void Main(string[] args)
    {
      //pode ser feiro uma das linhas abaixo
      // using EstruturaDoPrograma.Exemplos;
      // var s = new Exemplos.Pilha();
      var s = new Pilha();
      s.Empilha(1);
      s.Empilha(10);
      s.Empilha(100);
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
      Console.WriteLine(s.Desempilha());
    }
  }
}