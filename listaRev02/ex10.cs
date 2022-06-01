using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string dmaf = Console.ReadLine();
    string [] dma = dmaf.Split('/');
    int d = int.Parse(dma[0]);
    int m = int.Parse(dma[1]);
    int a = int.Parse(dma[2]);
    bool validade = true;
    if (a<1900 || a>2100) validade = false;
    if (m<1 || m>12) validade = false;
    if (d<1 || d>31) validade = false;
    if ((m==4 || m==6 || m==9 || m==11) && (d>30 || d<1)) validade = false;
    if(m==2 && (d>28 || d<1)) validade = false;
    if (validade) Console.WriteLine("A data informada é válida");
    else Console.WriteLine("A data informada não é válida");
    }
  }