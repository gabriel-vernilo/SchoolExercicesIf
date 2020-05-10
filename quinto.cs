using System;

class MainClass {
  public static void Main (string[] args) {
    int num;

    Console.WriteLine("digite um número: ");
    num = int.Parse(Console.ReadLine());
    if((num%3) == 0){
      Console.WriteLine("é divisivel por 3");
    }
    else{
      Console.WriteLine("não é divisivel por 3");
    }
  Console.ReadKey(true);
  }
}