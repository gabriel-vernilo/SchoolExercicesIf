using System;

class MainClass {
  public static void Main (string[] args) {
    string input_senha;
    const string senha = "1234";
  Console.WriteLine("digite a senha: ");
  input_senha = Console.ReadLine();

  if (input_senha == senha){
    Console.WriteLine("Acesso Permitido");
  }
  else{
    Console.WriteLine("Acesso negado");
  }

  Console.ReadKey(true);
  }
}