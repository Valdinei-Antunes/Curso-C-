using System;


namespace Program{

    class Arrays { 
    
        public static void Main(string[] args)
        {
            //declaração de array

            // forma tradicional
            int[] numeros = new int[5];

            //forma simplificada
            String[] times2 = new String[] {"Flamengo","Vasco","Corinthians","Palmeiras","São Paulo"};

            //outra forma
            int[] numeros2 = new int[] {1,2,3,4,5};
        
            //percorrendo um array

            //for
            for(int i = 0; i < times2.Length; i++)
            {
                Console.WriteLine("Time:" + times2[i]);
            }

            //foreach
            foreach(String i in times2)
            {
                Console.WriteLine("Time:" + i);
            }


            //adicionar elementos em um array

            String[] times3 = new string[6];

            Console.WriteLine("---------\n\nAdicionando elementos a um array---------");
            
            for(int i = 0; i <times3.Length; i++)
            {   
                Console.Write("Digite o nome do time: ");
                times3[i] = Console.ReadLine();
            }

            Console.WriteLine("--------\n\nExibindo os times digitados--------");
            for(int i = 0; i <times3.Length; i++)
            {
                Console.WriteLine("Time: " + times3[i]);
            }


            Array.Resize(ref times3, times3.Length + 10);

            Console.WriteLine("--------\n\nExibindo o tamanho do array após o redimensionamento--------");
            Console.WriteLine("Tamanho do array times3: " + times3.Length);


        }

    }

}