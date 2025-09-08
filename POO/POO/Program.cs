using System;


namespace POO
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo POO!");

            //criar uma instancia da classe Conta


            Conta conta1 = new Conta();

            conta1.Nome = "Valdinei";
            conta1.Saldo = 1000.00;
            conta1.Limite = 5000.00;
            conta1.Numero = 12345;

            Console.WriteLine($"Exibindo informações da conta1: \nNome: {conta1.Nome}\nSaldo da conta: {conta1.Saldo}\nLimite da conta: {conta1.Limite}\nNúmero da conta: {conta1.Numero}");


            Conta conta2 = new Conta();

            conta2.Nome = "André";
            conta2.Saldo = 10000.00;
            conta2.Limite = 25000.00;
            conta2.Numero = 123;

            Console.WriteLine("\n");
            Console.WriteLine($"Exibindo informações da conta2: \nNome: {conta2.Nome}\nSaldo da conta: {conta2.Saldo}\nLimite da conta: {conta2.Limite}\nNúmero da conta: {conta2.Numero}");


        }

    }

}