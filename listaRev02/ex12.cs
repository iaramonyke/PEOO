using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite dois valores inteiros");
    string valoresf = Console.ReadLine();
    string [] valores = valoresf.Split('+', '-', '*', '/');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int operador = valoresf.IndexOf('+');
    if (operador==-1) operador = valoresf.IndexOf('-');
    if (operador==-1) operador = valoresf.IndexOf('*');
    if (operador==-1) operador = valoresf.IndexOf('/');
    switch(valoresf[operador]){
      case '+' : Console.WriteLine($"O resultado da operação é {a+b}"); break;
      case '-' : Console.WriteLine($"O resultado da operação é {a-b}"); break;
      case '*' : Console.WriteLine($"O resultado da operação é {a*b}"); break;
      case '/' : Console.WriteLine($"O resultado da operação é {a/b}"); break;
    }
  }
}