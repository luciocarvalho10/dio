private static void Teste()
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