using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite quatro valores inteiros");
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    int valor3 = int.Parse(Console.ReadLine());
    int valor4 = int.Parse(Console.ReadLine());
    int media = (valor1+valor2+valor3+valor4)/4;
    Console.WriteLine($"Média = {media}");
    Console.WriteLine("Números menores que a média");
    if(valor1<media) Console.WriteLine(valor1);
    if(valor2<media) Console.WriteLine(valor2);
    if(valor3<media) Console.WriteLine(valor3);
    if(valor4<media) Console.WriteLine(valor4);
    Console.WriteLine("Números maiores ou iguais à média");
    if(valor1>=media) Console.WriteLine(valor1);
    if(valor2>=media) Console.WriteLine(valor2);
    if(valor3>=media) Console.WriteLine(valor3);
    if(valor4>=media) Console.WriteLine(valor4);
  }
}