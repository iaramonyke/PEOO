using System; 

public class Program {
  public static void Main(string[] args) {
    string valor1 = Console.ReadLine();
    int a = int.Parse(valor1);
    string valor2 = Console.ReadLine();
    int b = int.Parse(valor2);
    int x = a + b;
    Console.WriteLine("X = " + x);
  }
}