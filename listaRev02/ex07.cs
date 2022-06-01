using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    double r1 = (-b + Math.Sqrt(Math.Pow(b,2)-4*a*c))/(2*a);
    double r2 = (-b - Math.Sqrt(Math.Pow(b,2)-4*a*c))/(2*a);
    if (a == 0.0 || (Math.Pow(b,2)-4*a*c)<0.0) Console.WriteLine("Impossivel calcular");
    else
      Console.WriteLine($"As raízes são {r1} e {r2}");
  }
}