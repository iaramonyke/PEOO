using System; 

public class Program {

  public static void Main(string[] args) {
  Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
  string nota1 = Console.ReadLine();
  int valor1 = int.Parse(nota1);

  Console.WriteLine("Digite a nota do segundo bimestre da disciplina: ");
  string nota2 = Console.ReadLine();
  int valor2 = int.Parse(nota2);
  int media = ((valor1*2) + (valor2*3)) / 5;
  Console.WriteLine("Média parcial = " + media);
  }
}