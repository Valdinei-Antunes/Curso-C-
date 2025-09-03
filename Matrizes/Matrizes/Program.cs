using System;


namespace Program
{
    class Program {

        public static void Main(string[] args) {

            // Declaração de uma matriz
            int[,] terreno = new int[3,3];

            for(int x = 0; x < terreno.GetLength(0); x++)
            {
                Console.Write("Digite quantos metros de comprimento: ");
                terreno[x, 0] = int.Parse(Console.ReadLine());

                for(int y = 0; y < terreno.GetLength(0); y++)
                {
                Console.Write("Digite quantos metros de largura: ");
                terreno[y, 1] = int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine("\n\n--------Tamanho dos terrenos--------");
            for (int x = 0; x < terreno.GetLength(0); x++)
            {
                for (int y = 0; y < terreno.GetLength(0); y++)
                {
                    Console.WriteLine("Terreno: " + terreno[x, 0] + " x " + terreno[y, 1]);
                }
            }

        }
    
    }
}