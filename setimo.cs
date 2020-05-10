using System;

class MainClass {
  public static void Main (string[] args) {
    int Altura, Base;

    Console.WriteLine("digite a base do retangulo: ");
    Base = int.Parse(Console.ReadLine());
    Console.WriteLine("digite a largura do retangulo: ");
    Altura = int.Parse(Console.ReadLine());

    Console.WriteLine($"a area é : {Base*Altura}");
    Console.ReadKey(true);
  }
}