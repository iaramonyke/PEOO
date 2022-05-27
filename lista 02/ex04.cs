using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo");
    string bas3 = Console.ReadLine();
    string altura = Console.ReadLine();
    double b = double.Parse(bas3);
    double h = double.Parse(altura);
    double area = b*h;
    double perimetro = (b*2) + (h*2);
    double diagonal = Math.Sqrt(((b*b) + (h*h)));
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {perimetro:0.00} - Diagonal = {diagonal:0.00}");                             
  }
}