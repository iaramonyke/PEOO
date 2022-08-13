using System; 

public class Program {
  public static void Main(string[] args) {
    string entrada = Console.ReadLine();
    string [] abc = entrada.Split();
    double a = double.Parse(abc[0]);
    double b = double.Parse(abc[1]);
    double c = double.Parse(abc[2]);
    double areatriangulo = (a*c)/2.0;
    double areacirculo = 3.14159 * Math.Pow(c , 2);
    double areatrapezio = ((a+b)*c)/2.0;
    double areaquadrado = Math.Pow(b , 2);
    double arearetangulo = a * b;
    Console.WriteLine($"TRIANGULO: {areatriangulo:0.000}");
    Console.WriteLine($"CIRCULO: {areacirculo:0.000}");
    Console.WriteLine($"TRAPEZIO: {areatrapezio:0.000}");
    Console.WriteLine($"QUADRADO: {areaquadrado:0.000}");
    Console.WriteLine($"RETANGULO: {arearetangulo:0.000}");
  }
}