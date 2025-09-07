using System;

namespace Estacionamento
{

    class Estacionamento
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao estacionamento!");
            Console.Write("Selecione uma das opções \n\n");

            int opcao = 0;

            do
            {
                

                Console.WriteLine("1 - Cadastrar veículo \n2 - Remover veículo \n3 - Listar veículos \n4 - sair");
                 opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CadastrarVeiculo();
                    break;

                    case 2:
                        RemoverVeiculo();
                        break;

                    case 3:
                        ListarVeiculos();
                        break;

                    case 4:
                        Console.WriteLine("Saindo...");
                        Environment.Exit(0);
                        break;

                }
            }
            while (opcao != 4);

        }

        static List<String> Placas = new List<string>();


        public static void CadastrarVeiculo()
        {
            Console.WriteLine("\n\nDigite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            Placas.Add(placa);
        
        }
        public static void RemoverVeiculo()
        {
            Console.WriteLine("\n\nDigite a placa do veículo para remover: ");
            String placa = Console.ReadLine();

            if (Placas.Contains(placa))
            {
                decimal precofixo = 5;
                Console.WriteLine("\n\nDigite quantas horas o veículo ficou estacionado: ");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precofixo * horas;
                Placas.Remove(placa);
                Console.WriteLine("Veículo retirado com sucesso");
                Console.WriteLine("Valor a ser pago: " + valorTotal);

            }
            else
            {
                Console.WriteLine("Este veículo não existe!");
            }
        }
        
        public static void ListarVeiculos()
        {
           if(Placas.Count == 0)
            {
                Console.WriteLine("\n\nNão tem veículos cadastrados");
            }
            else
            {
                Console.WriteLine("\n\nVeículos cadastrados: ");
                foreach (var i in Placas)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}