using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o horário no formato hh:mm");
    string valorf = Console.ReadLine();
    string [] valor = valorf.Split(':');
    int hora = int.Parse(valor[0]);
    int min = int.Parse(valor[1]);
    int angulo = Math.Abs((30*hora)-(11*min/2));
    if (angulo>180) angulo = Math.Abs(360-angulo);
    if(hora>24 || hora<0 || min<0 || min>60) Console.WriteLine("Hora Inválida");
    else Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");
  }
}