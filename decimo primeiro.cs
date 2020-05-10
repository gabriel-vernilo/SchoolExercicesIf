using System;

class MainClass {
  public static void Main (string[] args) {
    double salario_fixo,salario_fim,vendas;

    Console.WriteLine("digite o salario fixo");
    salario_fixo = double.Parse(Console.ReadLine());
    Console.WriteLine("valor das vendas");
    vendas = double.Parse(Console.ReadLine());

    if(vendas<=1500){
      salario_fim = (vendas*0.3) + salario_fixo;
      Console.WriteLine($"o salario final sera {salario_fim}");
    }
    else{
      salario_fim = (vendas*0.5) + salario_fixo;
      Console.WriteLine($"o salario final sera {salario_fim}");
    }
  Console.ReadKey(true);
  }
}