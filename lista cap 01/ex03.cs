using System;

public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("digite dois números inteiros");
      int n1 = int.Parse(Console.ReadLine());
      int n2 = int.Parse(Console.ReadLine());
      int quo = n1/n2;
      int resto = n1%n2;
      Console.WriteLine($"{n1} / {n2} = {quo}");
      Console.WriteLine($"{n1} % {n2} = {resto}");
  }
}
