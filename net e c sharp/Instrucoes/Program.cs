using System;

namespace Instrucoes
{
  class Program
  {
    static void Declaracoes()
    {
      int a;
      int b = 2, c = 3;
      const int d = 4;
      a = 1;
      Console.WriteLine(a + b + c + d);
    }

    static void InstrucaoIf(String[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("Sem argumentos");
      }
      else if (args.Length == 1)
      {
        Console.Write("Um argumentos");
      }
      else
      {
        Console.WriteLine($"{args.Length} argumentos");
      }
    }
    
    static void InstrucaoSwitch(String[] args)
    {
      switch (args.Length)
      {
        case 0:
          Console.WriteLine("Nenhum argumento");
          break;
        case 1:
          Console.WriteLine("Um argumento");
          break;
        default:
          Console.WriteLine($"{args.Length} argumentos");
          break;
      }
    }
    
    static void InstrucaoWhile(String[] args)
    {
      int i = 0;
      while (args.Length > i)
      {
        Console.WriteLine($"{args[i]} - {i}");
        i++;
      }
    }

    static void InstucaoDo()
    {
      string text;
      do
      {
        text = Console.ReadLine();
        Console.WriteLine(text);
      } while (!string.IsNullOrEmpty(text));
    }
    
    static void InstucaoFor(string[] args)
    {
      for (int i = 0; i < args.Length; i++)
      {
        Console.WriteLine($"{args[i]} - {i}");
      }
    }
    
    static void InstucaoForeach(string[] args)
    {
      foreach (string s in args)
      {
        Console.WriteLine(s);
      }
    }

    static void InstrucaoBreak(string[] args)
    {
      while (true)
      {
        string s = Console.ReadLine();
        if (string.IsNullOrEmpty(s)) break;

        Console.WriteLine(s);
      }
    }

    static void InstrucaoContinue(string[] args)
    {
      for (int i = 0; i < args.Length; i++)
      {
          if (args[i].StartsWith("/")) continue;

          Console.WriteLine(args[i]);
      }
    }

    static void InstrucaoReturn()
    {
      int Somar(int a, int b)
      {
        return a + b;
      }

      Console.WriteLine(Somar(2 ,3));
      Console.WriteLine(Somar(3, 4));
      Console.WriteLine(Somar(4, 5));
      return;
    }

    static void InstrucaoTryCatchFinallyThrow(string[] args)
    {
      double Dividir(double x, double y)
      {
        if(y == 0)
          throw new DivideByZeroException("ainda não existe divisão por zero!");

        return x / y;
      }

      try
      {
        if(args.Length != 2)
          throw new InvalidOperationException("Informe 2 numeros");

        double x = double.Parse(args[0]);
        double y = double.Parse(args[1]);
        Console.WriteLine(Dividir(x, y));
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (Exception e)
      {
        Console.WriteLine($"Erro genérico: {e.Message}");
      }
      finally
      {
        Console.WriteLine("Até breve!!!!!");
      }
    }

    static void InstrucaoUsing(string[] args)
    {
      using(System.IO.TextWriter w = System.IO.File.CreateText("Teste.txt"))
      {
        w.WriteLine("Line 1");
        w.WriteLine("Line 2");
        w.WriteLine("Line 3");
      }
    }
    
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
