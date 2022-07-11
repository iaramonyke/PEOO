using System; 

public class Program {
  public static void Main() {
    int x =1;
    int y =1;
  while (x<=10) {
    Console.WriteLine($"{x} {y:2} = {x * y}");
    x++;
    y = -y;
  }
  }
}

    
// public static void Main(){
