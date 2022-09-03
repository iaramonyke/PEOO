using System;

public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("digite três números inteiros");
      int n1 = int.Parse(Console.ReadLine());
      int n2 = int.Parse(Console.ReadLine());
      int n3 = int.Parse(Console.ReadLine());
      int menor = Math.Min(n1,Math.Min(n2,n3));
      int soma = (n1 + n2 + n3) - menor;
      Console.WriteLine($"Soma dos dois maiores = {soma}");
  }
}
