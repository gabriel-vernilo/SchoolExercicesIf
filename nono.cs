using System;

class MainClass {
  public static void Main (string[] args) {
    int hora_fim, hora_comeco;

    Console.WriteLine("digite a hora de começo: ");
    hora_comeco = int.Parse(Console.ReadLine());
    Console.WriteLine("digite a hora de termino: ");
    hora_fim = int.Parse(Console.ReadLine());

    if(hora_comeco > hora_fim){
      Console.WriteLine($"durou {24 - (hora_comeco - hora_fim)}h");
    }
    else if (hora_comeco < hora_fim){
      Console.WriteLine($"durou {hora_fim - hora_comeco}h");
    }
    else{
      Console.WriteLine($"o jogo começou e acabou na mesma hora, menos de 1 hora ou então 24 horas");
    }
  Console.ReadKey(true);
  }
}