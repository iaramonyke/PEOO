using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string valorf1 = Console.ReadLine();
    string [] valor1 = valorf1.Split(':');
    int hora1 = int.Parse(valor1[0]);
    int min1 = int.Parse(valor1[1]);
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string valorf2 = Console.ReadLine();
    string [] valor2 = valorf2.Split(':');
    int hora2 = int.Parse(valor2[0]);
    int min2 = int.Parse(valor2[1]);
    int hora = hora1 + hora2;
    int minutos = min1 + min2;
    if (minutos >= 60) {
      minutos = minutos - 60; 
      hora +=1;
    }
    Console.WriteLine($"Total de horas = {hora:00}:{minutos:00}"); 
  }
}