using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite quatro valores inteiros");
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    int valor3 = int.Parse(Console.ReadLine());
    int valor4 = int.Parse(Console.ReadLine());
    int pares  = 0;
    int impares = 0;
    if (valor1%2==0) pares += valor1; else impares +=valor1;
    if (valor2%2==0) pares += valor2; else impares +=valor2;
    if (valor3%2==0) pares += valor3; else impares +=valor3;
    if (valor4%2==0) pares += valor4; else impares +=valor4;
    Console.WriteLine($"Soma dos pares = {pares}");
    Console.WriteLine($"Soma dos ímpares = {impares}");  
  }
}