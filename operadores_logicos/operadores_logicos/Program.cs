using System;

namespace operadores_logicos {

    class Program {

        public static void Main(string[] args) { 
            
            // operadores aritméticos

            int a, b;

            Console.Write("Digite ó primeiro número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Adição: " + (a + b)); //adição
            Console.WriteLine("Subtração: " + (a - b) ); //subtração
            Console.WriteLine("Multiplicação: " + ( a * b)); //multiplicação
            Console.WriteLine("Divisão: " + (a / b)); //divisão
            Console.WriteLine("Resto da divisão: " + (a % b)); //resto da divisão
            Console.WriteLine("Incremento: " + (++a)); //incremento
            Console.WriteLine("Decremento: " + (--b)); //decremento


            //operadores de comparação

            int x = 10 , y = 20;

            Console.WriteLine( x == y ); // == igual à
            Console.WriteLine( x != y ); // != diferente de
            Console.WriteLine( x > y ); // > maior que
            Console.WriteLine(x < y); // < menor que
            Console.WriteLine(x >= y); // >= maior ou igual a
            Console.WriteLine(x <= y); // <= menor ou igual a
            

            //operadores lógicos

            bool c1 = true, c2 = false;

            Console.WriteLine(c1 && c2); // && "E"
            Console.WriteLine(c1 || c2); // || "OU"
            Console.WriteLine(!c1); // ! "NÃO"

            //operadores de atribuição

            int c = 30;

            c = 30; // = igual
            c += 10; // += adição
            c -= 10; // -= subtração
            c *= 10; // *= multiplicação
            c /= 10; // /= divisão
            c %= 10; // &= resto da divisão

        }
    
    }

}