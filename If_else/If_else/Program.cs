using System;


namespace If_Else {

    class Program { 
    
    static void Main(String[] args)
        {
            // condicionais 

            Console.Write("Digite a nota 1: ");
            double nota1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            double nota2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            double nota3 = Double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 ) / 3;

            Console.WriteLine("Sua média é: " + media);

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");

            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine("Recuperação");
            }
            else {
                Console.WriteLine("Reprovado");
            }
        }
    
    }

}