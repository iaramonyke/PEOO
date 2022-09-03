using System;

public class Program {
  public static void Main(string[] args) {
    Viagem v = new Viagem();
    Console.WriteLine("Digite sua distância:");
    v.SetDistancia(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite seu tempo:");
    v.SetTempo(double.Parse(Console.ReadLine()));
    Console.WriteLine($"a vm foi: {v.VelocidadeMedia()}"); 
  }
}
  public class Viagem{
    private double distancia;
    private double tempo;
    public void SetDistancia(double d){
      if (d > 0) distancia = d;
  }
  public void SetTempo(double t){
    if (t > 0) tempo = t;
    
  }
  public double GetDistancia(){
    return distancia;
    
  }
  public double GetTempo(){
    return tempo;
    
  }
  public double VelocidadeMedia(){
    double vm = distancia / tempo;
    return vm;
    
  }
  }