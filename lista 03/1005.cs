using System; 

public class Program {
  public static void Main(string[] args) {
    string valor1 = Console.ReadLine();
    double a = double.Parse(valor1);
    string valor2 = Console.ReadLine();
    double b = double.Parse(valor2);
    double media = (a *3.5 + b*7.5)/11;
    Console.WriteLine($"MEDIA = {media:0.00000}");
  }                         
}