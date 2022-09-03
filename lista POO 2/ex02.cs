using System;

public class Program {
  public static void Main(string[] args) {
   Console.WriteLine("Digite uma Disciplina:");
    Disciplina y = new Disciplina();
    y.SetNome(Console.ReadLine());
    Console.WriteLine("Digite as suas 4 notas:");
    y.SetNota1(int.Parse(Console.ReadLine()));
    y.SetNota2(int.Parse(Console.ReadLine()));
    y.SetNota3(int.Parse(Console.ReadLine()));
    y.SetNota4(int.Parse(Console.ReadLine()));
    Console.WriteLine($"A sua média Parcial foi:{y.CalcMediaParcial()}");
    if (y.CalcMediaParcial() < 60) {
      Console.WriteLine("Digite sua nota Final:");
      y.SetNotaFinal(int.Parse(Console.ReadLine()));
      Console.WriteLine($"A sua nota final foi: {y.CalcMediaFinal()}");
    }
    
  }
}
public class Disciplina{
  private string nome;
  private int nota1;
  private int nota2;
  private int nota3;
  private int nota4;
  private int notafinal;

  public void SetNome(string s){
    nome = s;
  }
  public void SetNota1(int n){
    if (n >= 0 && n <= 100) nota1 = n;
  }
  public void SetNota2(int n){
    if (n >= 0 && n <= 100) nota2 = n;
  }
  public void SetNota3(int n){
    if (n >= 0 && n <= 100) nota3 = n;
  }
  public void SetNota4(int n){
    if (n >= 0 && n <= 100) nota4 = n;
  }
  public void SetNotaFinal(int n){
    if (n >= 0 && n <= 100) notafinal = n;
  }
  public string GetNome(){
    return nome;
  }
  public int GetNota1(){
    return nota1;
  }
  public int GetNota2(){
    return nota2;
  }
  public int GetNota3(){
    return nota3;
  }
  public int GetNota4(){
    return nota4;
  }
  public int GetNotaFinal(){
    return notafinal;
  }
  public int CalcMediaParcial(){
    int mediaparc = (nota1 * 2 + nota2 *2 + nota3 * 3 + nota4 * 3 ) / 10;
    return mediaparc;
  }
  public int CalcMediaFinal(){
    int mediafim = (CalcMediaParcial() + notafinal) / 2;
    return mediafim;
  }
}
