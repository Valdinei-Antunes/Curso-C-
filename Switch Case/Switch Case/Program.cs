using System;

namespace Switch_Case {


    class Program {
    
        static void Main(string[] args)
        {
        
        Console.WriteLine("------------ Digite qual opção você quer: ------------ \n\n");
        Console.WriteLine("1 - Abrir conta \n2 - Pedir empréstimo \n3 - Encerrar conta");
        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine("Opção escolhida: " + opcao);



            switch (opcao)
            {

                case 1:
                    Console.WriteLine("Insira seus dados...");
                break;

                case 2:
                    Console.WriteLine("Qual o valor...");
                break;

                case 3:
                    Console.WriteLine("Ok, vamos encerrar sua conta...");
                break;

                default:
                    Console.WriteLine("Escolha uma opção válida...");
                break;
            }
            
        // com String

        Console.WriteLine("------------ Qual é o seu nome: ------------ \n\n");
        String nome = Console.ReadLine();


            Console.WriteLine("Nome digitado: " + nome);


            switch (nome) {

                case "Valdinei":
                    Console.WriteLine("Olá Valdinei");
                break;

                case "Maria":
                    Console.WriteLine("Olá Maria");
                break;

                case "Lucas":
                    Console.WriteLine("Olá Lucas");
                break;

                default:
                    Console.WriteLine("nome feio " + nome);
                break;
            }

        }
    
    }

    }