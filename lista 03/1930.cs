using System; 

public class Program {
  public static void Main(string[] args) {
    string entrada = Console.ReadLine();
    String [] entradaf = entrada.Split();
    int t1 = int.Parse(entradaf[0]);
    int t2 = int.Parse(entradaf[1]);
    int t3 = int.Parse(entradaf[2]);
    int t4 = int.Parse(entradaf[3]);
    int saida = (t1 -1)+(t2-1)+(t3-1)+t4;
    Console.WriteLine(saida);
  }                         
}