namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma array multidimencional (Matriz);
            int[,] matriz = new int[4, 2]
            {
                {8,8},
                {10,20},
                {50,100},
                {90,200},
            };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }

            }


            //int[] arrayInteiros = new int[3];

            //arrayInteiros [0] = 10;
            //arrayInteiros [1] = 20;
            //arrayInteiros [2] = int.Parse("30");

            
            //arrayInteiros [3] = 30; // Este elemento não existe no array

            //// Modo de percorrer o array pelo "For";
            //Console.WriteLine("Parcorrendo o array pelo For");
            //for (int i = 0; i < arrayInteiros.Length ; i++)// Usar sempre a propriedade "Length" para tornar o "For" dinâmico;
            //{
            //    Console.WriteLine(arrayInteiros[i]);
            //}

            //// Modo de percorrer o array pelo "ForEach";
            //Console.WriteLine("Parcorrendo o array pelo ForEach");
            //foreach (int item in arrayInteiros)
            //{
            //    Console.WriteLine(item);
            }
        }
    }

