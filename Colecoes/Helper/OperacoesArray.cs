namespace Colecoes.Helper
{

	public class OperacoesArray
	{
        // Implementação do organizador lógico de arrays "BubbleSort";
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if(array[j] > array [j + 1])
                    {
                        temp = array[j + 1]; // Variável temporária para tornar possível as trocas de parâmetros dentro do array ao usar o BoobleSort;
                        array[j + 1] = array [j];
                        array[j] = temp;
                    }
                }
            }
        }

		public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array); // Transformando o array em uma liha separado por vírgula;
            Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        // Método para copiar o array utilizando o Arraay.Copy
        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        // Método Array.Exists
        public bool Existe(int [] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        // Método para verificar toda a lista de array utilizando o "Array.TrueForAll";
        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        // Criando método para encontrar um valor dentro do array utilizando o Array.Find;
        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);
        }
	}

}


