using System;

class MainClass {
  public static void Main (string[] args) {
    int ano;
    Console.WriteLine("digite o ano que vc nasceu: ");
    ano = int.Parse(Console.ReadLine());
    if ((2020 - ano)>=16){
      Console.WriteLine("sim você poderá votar");
    }
    else{
      Console.WriteLine("você não poderá votar");
    }

    Console.ReadKey(true);
  }
}