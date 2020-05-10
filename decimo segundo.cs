using System;

class MainClass {
  public static void Main (string[] args) {
    double credito,debito,saldo,saldo_atual;

    Console.WriteLine("diigte o valor de saldo");
    saldo = double.Parse(Console.ReadLine());
    Console.WriteLine("diigte o valor de credito");
    credito = double.Parse(Console.ReadLine());
    Console.WriteLine("diigte o valor de débito");
    debito = double.Parse(Console.ReadLine());

  saldo_atual = saldo - debito + credito;
  Console.Write($"saldo atual : {saldo_atual}, ");
  if(saldo_atual > 0){
    Console.WriteLine("Saldo Positivo");
  }
  else if (saldo_atual < 0){
    Console.WriteLine("Saldo Negativo");
  }
  else{
    Console.WriteLine("Zerado");
  }
  Console.ReadKey(true);
  }
}