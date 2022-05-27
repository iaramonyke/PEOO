using System; 

public class Program {
  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[]v = s.Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]); 
    if (a > b)
    {
      Console.WriteLine(a % b);
    }
    else
    {
      Console.WriteLine(b % a);
    }
  }                         
}