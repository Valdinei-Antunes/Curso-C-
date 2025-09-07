using System;

namespace Progam { 


    class Listas
    {
        static void Main(string[] args)
        {
            //criando uma lista
            List<String> Nomes = new List<String>();

            //criando uma lista e adicionando elementos no momento da criação
            List<int> numeros = new List<int> { 1,2,4,5,6};

            //adicionando elementos na lista
            Nomes.Add("Erik");
            Nomes.Add("Ana");
            Nomes.Add("Maria");
            Nomes.Add("João");
            Nomes.Add("Pedro");

            //adicionando elementos na lista passando o indice
            Nomes.Insert(1, "Valdinei");

            //removendo elementos da lista
            Nomes.Remove("Valdinei");


            //exibindo os elementos da lista com foreach
            foreach (var i in Nomes){
                Console.WriteLine($"Nome: {i}");
            }


            Console.WriteLine("\n\n\n\n");
            //exibindo os elementos da lista com for
            for(int i = 0; i < Nomes.Count; i++)
            {
                    Console.WriteLine($"Nome: {Nomes[i]}");
            }

            //removendo elementos da lista passando o indice
            Nomes.RemoveAt(0);

            //removendo todos os elementos da lista
            Nomes.Clear();



        }
    }

}