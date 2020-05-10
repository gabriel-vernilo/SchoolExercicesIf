using System;

class MainClass {
  public static void Main (string[] args) {
    int valor_maca, qtd_maca;
  Console.WriteLine("digite o valor de maças: ");
  qtd_maca = int.Parse(Console.ReadLine());

  if(qtd_maca < 12){
    Console.WriteLine($"ficará {qtd_maca * 0.3} ");
  }
  else{
    Console.WriteLine($"ficará {qtd_maca * 0.25} ");
  }

  Console.ReadKey(true);
  }
}