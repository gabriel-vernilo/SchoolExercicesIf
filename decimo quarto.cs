using System;

class MainClass {
  public static void Main (string[] args) {
    double altura;
    char sexo;

    Console.WriteLine("digite sua altura: ");
    altura = double.Parse(Console.ReadLine());
    Console.WriteLine("digite seu sexo M ou F");
    sexo = char.Parse(Console.ReadLine());
    if(sexo == 'm' || sexo == 'M'){
      Console.WriteLine($"peso ideal é {(altura * 100) * 0.95 - 95}");
    }
    else if(sexo == 'f' || sexo == 'F'){
      Console.WriteLine($"peso ideal é {(altura * 100) * 0.85 - 85}");
    }
    else{
      Console.WriteLine("Invalido");
    }
  Console.ReadKey(true);
  }
}