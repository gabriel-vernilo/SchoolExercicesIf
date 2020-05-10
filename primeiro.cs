using System;

class MainClass {
  public static void Main (string[] args) {
    int num1,num2;
    Console.WriteLine("digite o primeiro número");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o segundo número");
    num2 = int.Parse(Console.ReadLine());
    if(num1 > num2){
      Console.WriteLine("o primeiro é maior");
    }
    else if(num1 < num2){
      Console.WriteLine("o segundo é maior");
    }
    else{
      Console.WriteLine("são iguais");
    }

    Console.ReadKey(true);
  }
}