using System;

class MainClass {
  public static void Main (string[] args) {
    int num1, num2;

    Console.WriteLine("digite o primeiro número ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o segundo número ");
    num2 = int.Parse(Console.ReadLine());
    if (num1 < num2){
      Console.WriteLine($"{num1}, {num2}");
    }
    else if (num1> num2){
      Console.WriteLine($"{num2}, {num1}");
    }
    else{
      Console.WriteLine($"{num1} é igual {num2}");
    }
    Console.ReadKey(true);
  }
}