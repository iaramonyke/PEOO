using System;

public class Program {
    public static void Main(string[] args) {
      Console.WriteLine("digite uma data");
      string data = Console.ReadLine();
      string [] datas = data.Split("/");
      string dia = datas[0];
      string mes = datas[1];
      int ano = int.Parse(datas[2]);
      int luz = ano + 1;
      Console.WriteLine($"{dia}/{mes}/{luz}");    
  }
}
