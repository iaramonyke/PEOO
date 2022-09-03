using System;

public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("digite dois números inteiros:");
      int numero1 = int.Parse(Console.ReadLine());
      
      string numero = Console.ReadLine();
      int numero2 = int.Parse(numero);

      int soma = numero1 + numero2;

      Console.WriteLine($"SOMA = {soma}");
  }
}
