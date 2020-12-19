using System;

namespace Revisao
{
  class Program
  {
    static void Main(string[] args)
    {
      Aluno[] alunos = new Aluno[5];
      var indiceAluno = 0;
      string op = Menu();

      while (op.ToUpper() != "X")
      {
        switch (op)
        {
          case "1":
            var aluno = new Aluno();
            Console.WriteLine("\n\tInserir Aluno");
            Console.Write("\nAluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
              aluno.Nota = nota;
            else
              throw new ArgumentException("Nota é decimal");

            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;
          case "2":
            Console.WriteLine("\n\tListar Alunos\n");
            for (int i = 0; i < indiceAluno; i++)
              Console.WriteLine($"ALUNO: {alunos[i].Nome} - NOTA: {alunos[i].Nota}");

            break;
          case "3":
            decimal media = 0;

            for (int i = 0; i < indiceAluno; i++)
              media += alunos[i].Nota;


            Console.WriteLine("\n\tNota e Conceito\n");
            Console.WriteLine($"Media Geral - {media / indiceAluno}");
            ConceitoGeral(media / indiceAluno);
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }

        op = Menu();
      }
      Console.WriteLine("Adeus!");
    }

    private static string Menu()
    {
      Console.WriteLine();
      Console.WriteLine("1 - Inserir aluno");
      Console.WriteLine("2 - Listar alunos");
      Console.WriteLine("3 - Média Geral");
      Console.WriteLine("X - Sair");
      Console.Write("Informe a opção: ");

      return Console.ReadLine();
    }

    private static void ConceitoGeral(decimal nota)
    {
      ConceitoEnun conceito;
      switch (nota)
      {
        case < 2:
          conceito = ConceitoEnun.E;
          break;
        case < 4:
          conceito = ConceitoEnun.D;
          break;
        case < 6:
          conceito = ConceitoEnun.C;
          break;
        case < 8:
          conceito = ConceitoEnun.B;
          break;
        default:
          conceito = ConceitoEnun.A;
          break;
      }
      Console.WriteLine($"Conceito Geral - {conceito}");
    }
  }
}
