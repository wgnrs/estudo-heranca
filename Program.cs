using System;

namespace estudo_herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estudo de herança!");

            Funcionario pedro = new Funcionario();
            pedro.nome = "Pedro";
            pedro.cpf = "1234567898";
            pedro.salario = 2000;

            System.Console.WriteLine($"Bonificação: {pedro.getBonificacao()}");
        }
    }
}
