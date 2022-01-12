using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros [0] = 10;
            arrayInteiros [1] = 20;
            arrayInteiros [2] = 30;

            Console.WriteLine("Parcorrendo o array pelo For");
            for (int i = 0; i < arrayInteiros.Length ; i++)// Usar sempre a propriedade "Length" para tornar o "For" dinâmico;
            {
                Console.WriteLine(arrayInteiros[i]);
            }

            Console.WriteLine("Parcorrendo o array pelo ForEach");// Modo de percorre pelo "ForEach";
            foreach (int item in arrayInteiros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
