using System;

class MainClass {
  public static void Main (string[] args) {
    int qtd_atual,qtd_min,qtd_max,qtd_med;

    Console.WriteLine("diigte o valor atual em estoque");
    qtd_atual = int.Parse(Console.ReadLine());
    Console.WriteLine("diigte o valor minima para o estoque");
    qtd_min = int.Parse(Console.ReadLine());
    Console.WriteLine("diigte o valor maxima para o estoque");
    qtd_max = int.Parse(Console.ReadLine());
    qtd_med = (qtd_min + qtd_max)/2;
    if(qtd_atual >qtd_med){
      Console.WriteLine("Não efetuar Compra");
    }
    else{
      Console.WriteLine("efetuar compra");
    }
  Console.ReadKey(true);
  }
}