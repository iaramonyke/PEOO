using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite quatro valores inteiros");
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    int valor3 = int.Parse(Console.ReadLine());
    int valor4 = int.Parse(Console.ReadLine());
    int maior = Math.Max((Math.Max(valor1,valor2)),(Math.Max(valor3,valor4)));
    int menor = Math.Min((Math.Min(valor1,valor2)),(Math.Min(valor3,valor4)));
    if (valor1!=valor2 && valor1!=valor3 && valor1!=valor4 && valor2!=valor3 && valor3!=valor4) {
      Console.WriteLine($"Maior valor = {maior}");
      Console.WriteLine($"Menor valor = {menor}");
      if (valor1!=maior && valor1!=menor && valor2!=maior && valor2!=menor) Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {valor1+valor2}");
      if (valor1!=maior && valor1!=menor && valor3!=maior && valor3!=menor) Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {valor1+valor3}");
      if (valor1!=maior && valor1!=menor && valor4!=maior && valor4!=menor) Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {valor1+valor4}");
      if (valor2!=maior && valor2!=menor && valor3!=maior && valor3!=menor) Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {valor2+valor3}");
      if (valor2!=maior && valor2!=menor && valor4!=maior && valor4!=menor) Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {valor2+valor4}");
      if (valor3!=maior && valor3!=menor && valor4!=maior && valor4!=menor) Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {valor3+valor4}");
    }
    else Console.WriteLine("Valores inválidos");
  }
}
