using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite dez valores inteiros");
    string valoresf = Console.ReadLine();
    string [] valores = valoresf.Split(' ');
    int a = int.Parse(valores[0]); 
    int b = int.Parse(valores[1]); 
    int c = int.Parse(valores[2]); 
    int d = int.Parse(valores[3]);
    int e = int.Parse(valores[4]);
    int f = int.Parse(valores[5]);
    int g = int.Parse(valores[6]);
    int h = int.Parse(valores[7]);
    int i = int.Parse(valores[8]);
    int j = int.Parse(valores[9]);
    int maior = 0; int menor = 0;
    if(a>b && a>c && a>d && a>e && a>f && a>g && a>h && a>i && a>j) maior=a; else if(a<b && a<c && a<d && a<e && a<f && a<g && a<h && a<i && a<j) menor=a;
    if(b>a && b>c && b>d && b>e && b>f && b>g && b>h && b>i && b>j) maior=b; else if (b<a && b<c && b<d && b<e && b<f && b<g && b<h && b<i && b<j) menor=b;
    if(c>b && c>a && c>d && c>e && c>f && c>g && c>h && c>i && c>j) maior=c; else if(c<b && c<a && c<d && c<e && c<f && c<g && c<h && c<i && c<j) menor=c;
    if(d>b && d>c && d>a && d>e && d>f && d>g && d>h && d>i && d>j) maior=d; else if(d<b && d<c && d<a && d<e && d<f && d<g && d<h && d<i && d<j) menor=d;
    if(e>b && e>c && e>d && e>a && e>f && e>g && e>h && e>i && e>j) maior=e; else if(e<b && e<c && e<d && e<a && e<f && e<g && e<h && e<i && e<j) menor=e;
    if(f>b && f>c && f>d && f>e && f>a && f>g && f>h && f>i && f>j) maior=f; else if(f<b && f<c && f<d && f<e && f<a && f<g && f<h && f<i && f<j) menor=f;
    if(g>b && g>c && g>d && g>e && g>f && g>a && g>h && g>i && g>j) maior=g; else if(g<b && g<c && g<d && g<e && g<f && g<a && g<h && g<i && g<j) menor=g;
    if(h>b && h>c && h>d && h>e && h>f && h>g && h>a && h>i && h>j) maior=h; else if(h<b && h<c && h<d && h<e && h<f && h<g && h<a && h<i && h<j) menor=h;
    if(i>b && i>c && i>d && i>e && i>f && i>g && i>h && i>a && i>j) maior=i; else if(i<b && i<c && i<d && i<e && i<f && i<g && i<h && i<a && i<j) menor=i;
    if(j>b && j>c && j>d && j>e && j>f && j>g && j>h && j>i && j>a) maior=j; else if(j<b && j<c && j<d && j<e && j<f && j<g && j<h && j<i && j<a) menor=j;
    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
  }
}