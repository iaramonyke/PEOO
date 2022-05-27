using System; 

public class Program {
  public static void Main(string[] args) {
    string raio1 = Console.ReadLine();
    double raio = double.Parse(raio1);
    double volume = (4.0/3) * 3.14159 * (raio *raio *raio);
    Console.WriteLine($"VOLUME = {volume:0.000}");   
  }                         
}