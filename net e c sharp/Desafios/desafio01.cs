// minha resposta
using System;

class Desafio01
{
  static void Main()
  {
    int limit;
    if (Int32.TryParse(Console.ReadLine(), out Int32 outLimit))
      limit = outLimit;
    else
      throw new ArgumentException("Apenas número");

    for (int i = 0; i < limit; i++)
    {
      double X, Y;
      string[] line = Console.ReadLine().Split(" ");
      if (double.TryParse(line[0], out double outX) && double.TryParse(line[1], out double outY))
      {
        X = outX;
        Y = outY;
      }
      else
      {
        throw new ArgumentException("Apenas número");
      }

      if (Y == 0 || (X == 0 && Y < 0))
      {
        Console.WriteLine("divisao impossivel");
      }
      else
      {
        double divisao = X / Y; // Digite aqui o calculo da divisao
        Console.WriteLine(divisao.ToString("N1"));
      }
    }
  }
}

// Resposta aceita
// using System;

// class Program
// {
//   static void Main(string[] args)
//   {
//     int limit = Int32.Parse(Console.ReadLine());
//     for (int i = 0; i < limit; i++)
//     {
//       string[] line = Console.ReadLine().Split(" ");
//       double X = double.Parse(line[0]);
//       double Y = double.Parse(line[1]);
//       if (Y == 0)
//       {
//         Console.WriteLine("divisao impossivel");
//       }
//       else
//       {
//         double divisao = (double)X / Y;
//         if (divisao < 0 && divisao > -0.5)
//         {
//           Console.WriteLine("-0.0");
//         }
//         else
//         {
//           Console.WriteLine(Math.Round(divisao, 1).ToString("N1"));
//         }
//       }
//     }
//   }
// }