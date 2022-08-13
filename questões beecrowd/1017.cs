using System; 

public class Program {
  public static void Main(string[] args) {
    string tempo1 = Console.ReadLine();
    string velocidade1 = Console.ReadLine();
    int velocidade = int.Parse(velocidade1);
    int tempo = int.Parse(tempo1);
    double distancia = velocidade * tempo;
    double litros = distancia / 12.0;
    Console.WriteLine($"{litros:0.000}");
  }
}