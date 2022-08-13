using System; 

public class Program {

  public static void Main(string[] args) {
    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());
    double sol = vendas*0.15;
    double total = salario + sol;
    Console.WriteLine($"TOTAL = R$ {total:0.00}");
    
  }
}