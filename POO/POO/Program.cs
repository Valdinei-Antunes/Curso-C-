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

            conta1.AdicionarLimite(2000);
            conta1.Depositar(2000);
            conta1.Depositar(3000);
            conta1.Depositar(4000);
      

            bool saque = conta1.Sacar(50000);

            if (saque)
            {

                double saldo = conta1.ConsultaSaldoDisponivel();

                Console.WriteLine("Esse é seu saldo disponível: " + conta1.ConsultaSaldoDisponivel());
                Console.WriteLine("Seu limite é: " + conta1.Limite);
            

            }
            Console.ReadLine();
        }

    }

}