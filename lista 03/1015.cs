using System; 

public class Program {
  public static void Main(string[] args) {
    string xy1 = Console.ReadLine();
    string [] xy = xy1.Split();
    double x1 = double.Parse(xy[0]);
    double y1 = double.Parse(xy[1]);
    string yx1 = Console.ReadLine();
    string [] yx = yx1.Split();
    double x2 = double.Parse(yx[0]);
    double y2 = double.Parse(yx[1]);
    double distancia = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
    Console.WriteLine($"{distancia:0.0000}");  
  }                         
}