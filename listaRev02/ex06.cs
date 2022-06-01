using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores inteiros");
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    int valor3 = int.Parse(Console.ReadLine());
    int maior1 = Math.Max(valor1,valor2);
    int maior = Math.Max(maior1,valor3);
    int menor1 = Math.Min(valor1,valor2);
    int menor = Math.Min(menor1,valor3);
    int soma = maior + menor;
    Console.WriteLine($"A soma do maior com o menor número é {soma}");
  }
}