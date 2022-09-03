using System;

public class Program {
  public static void Main(string[] args) {
    Circulo sil = new Circulo();
    Console.WriteLine("Digite um Valor");
    sil.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine(sil.GetRaio());
    Console.WriteLine(sil.CalcArea());
    Console.WriteLine(sil.CalcCircunferencia());    
  }
}

public class Circulo {
  private double raio;
  public void SetRaio(double ra){
    if (ra > 0) raio = ra;
  }
  public double GetRaio(){
    return raio;
  }
  public double CalcArea(){
    double area = 3.14 * (raio * raio);
    return area;
  }
  public double CalcCircunferencia(){
    double circun = 2 * 3.14 * raio;
    return circun;
  }
}