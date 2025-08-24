using System;

namespace For
{
    class Program {
    
    static void Main(string[] args) {

            Console.Write("Digite um número para fazer a tabuada até 10:");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("" + numero + " * " + "" + i + " = " + resultado);
            }
        
        }
            
            }
}