using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string dmaf = Console.ReadLine();
    string [] dma = dmaf.Split('/');
    string d = dma[0];
    string m = dma[1];
    string a = dma[2];
    switch (m){
        case "01": Console.WriteLine($"A data é {d} de janeiro de {a}"); break;
        case "02": Console.WriteLine($"A data é {d} de fevereiro de {a}"); break;
        case "03": Console.WriteLine($"A data é {d} de março de {a}"); break;
        case "04": Console.WriteLine($"A data é {d} de abril de {a}"); break;
        case "05": Console.WriteLine($"A data é {d} de maio de {a}"); break;
        case "06": Console.WriteLine($"A data é {d} de junho de {a}"); break;
        case "07": Console.WriteLine($"A data é {d} de julho de {a}"); break;
        case "08": Console.WriteLine($"A data é {d} de agosto de {a}"); break;
        case "09": Console.WriteLine($"A data é {d} de setembro de {a}"); break;
        case "10": Console.WriteLine($"A data é {d} de outubro de {a}"); break;
        case "11": Console.WriteLine($"A data é {d} de novembro de {a}"); break;
        case "12": Console.WriteLine($"A data é {d} de dezembro de {a}"); break;
        default: Console.WriteLine("Data Inexistente"); break; 
      }
    }
  }