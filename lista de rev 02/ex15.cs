using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite três valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int maior = 0;
    int menor = 0;
    int meio = 0;
    if (a>b && a>c) maior +=a;
    else if ((a>b && a<c) || (a>c && a<b)) meio +=a;
    else menor +=a;

    if (b>a && b>c) maior +=b;
    else if ((b>a && b<c) || (b>c && b<a)) meio +=b;
    else menor +=b;

    if (c>b && c>a) maior +=c;
    else if ((c>b && c<a) || (c>a && c<b)) meio +=c;
    else menor +=c;
    Console.WriteLine($"{menor}, {meio}, {maior}");
    }
  }