using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    if (a+b>c && a+c>b && b+c>a){
        if (a==b && b==c && a==c) Console.WriteLine("Esses valores formam um triângulo equilátero");
        if (((a==b && a!=c && b!=c) || (c==b && c!=a && b!=a) || (a==c && a!=b && b!=c))) Console.WriteLine("Esses valores formam um triângulo isósceles");
        if ((a!=b && a!=c && b!=c)) Console.WriteLine("Esses valores formam um triângulo escaleno");
      }
    else Console.WriteLine("Esses valores não formam um Triângulo");
    }
  }