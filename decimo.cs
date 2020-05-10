using System;

class MainClass {
  public static void Main (string[] args) {
    double horas_trabalhadas, salario_ph, salario_final;

    Console.WriteLine("digite as horas trabalhadas");
    horas_trabalhadas = int.Parse(Console.ReadLine());
    Console.WriteLine("digite salário por hora");
    salario_ph = int.Parse(Console.ReadLine());


    if(horas_trabalhadas > 160){
      salario_final = 160.0 * salario_ph + ((salario_ph/2.0) * (horas_trabalhadas - 160.0));
      Console.WriteLine($"o salario sera {salario_final}");
    }
    else{
      salario_final = salario_ph*horas_trabalhadas;
      Console.WriteLine($"o salario sera {salario_final}");
    }
    Console.ReadKey(true);
  }
}