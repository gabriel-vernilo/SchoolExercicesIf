using System;

class MainClass {
  public static void Main (string[] args) {
    int num;
    Console.WriteLine("digite um número: ");
    num =  int.Parse(Console.ReadLine());
    Console.WriteLine($"seu antecessor é {num - 1} ");
    Console.ReadKey(true);
  }
}