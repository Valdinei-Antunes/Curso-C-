using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{

    class Funcoes
    {
    
        public static void Main(string[] args)
        {
            
            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();
            Saudacao(nome);

            int n1 = 0 , n2 = 0;

            Somar(n1, n2);


        }
    


        //Função sem retorno

        static void Saudacao(String nome)
        {
            Console.WriteLine("Olá, " + nome);
        }


        //Função com retorno
        static int Somar(int a, int b)
        {
            Console.WriteLine("\n\n------Somar------");
            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());
            
            int resultado = a + b;
            Console.WriteLine("Resultado: " + resultado);

            return resultado;
        }

    }

}