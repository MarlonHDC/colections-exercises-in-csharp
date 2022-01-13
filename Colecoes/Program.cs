using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Programa de ordenação de array;
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];



            //// Programa para encontrar o valor específico no array;
            //int valorProcurado = 9; // Alterar este valor para testar;

            //int valorAchado = op.ObterValor(array, valorProcurado);

            //if (valorAchado > 0)
            //{
            //    Console.WriteLine("Encontrei o valor");
            //}
            //else
            //{
            //    Console.WriteLine("Não encontrei o valor");
            //}



            ////Programa para verificar todo o array;
            //int ValorProcurado = 0; // Alterar o valor de "0" para testar;

            //bool todosMaiorQue = op.TodosMaiorQue(array, ValorProcurado);

            //if (todosMaiorQue)
            //{
            //    Console.WriteLine("Todos os valores são maior que {0}", ValorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existem valores que não são maiorres do que {0}", ValorProcurado);
            //}


            //// Programa para verificar a existencia de algum elemento;
            //int ValorProcurado = 10;
            //bool existe = op.Existe(array, ValorProcurado);

            //if (existe)
            //{
            //    Console.WriteLine("Encontrei o valor: {0}", ValorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Não Encontrei o valor: {0}", ValorProcurado);
            //}       
                          
                           

            //// Copiando arrays (array para arrayCopia);
            //Console.WriteLine("Array antes da cópia:");
            //op.ImprimirArray(arrayCopia);

            //op.Copiar(ref array, ref arrayCopia);
            //Console.WriteLine("Array  após a cópia:");
            //op.ImprimirArray(arrayCopia);

            //Console.WriteLine("Array original:");
            //op.ImprimirArray(array);

            // Programa de ordenação de array usando o "BubbleSort";
            //op.OrdenarBubbleSort(ref array);

            // Ordenação através da Classe Array utilizando o método "Sort";
            // op.Ordenar(ref array); 

            //Console.WriteLine("Array ordenado:");
            //op.ImprimirArray(array);


            //// Criando uma array multidimencional (Matriz);
            //int[,] matriz = new int[4, 2]
            //{
            //    {8,8},
            //    {10,20},
            //    {50,100},
            //    {90,200},
            //};

            // Percorrendo uma Matriz com DOIS "For";
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matriz[i, j]);
            //    }

            //}


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

