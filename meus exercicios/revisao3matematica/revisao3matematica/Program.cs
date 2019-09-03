using System;

namespace revisao3matematica
{
    class Program
    {
        int[] vetor;
        int[,] matriz;
        int[] vetor_tmp;
        public void mostraVetor(int[] vet)
        {
            Console.Write("Vetor:");
            for (int index = 0; index < vet.Length; index++)
            {
                Console.Write("\t" + vet[index]);
            }
            Console.WriteLine("\n");
        }
        public void mostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i <= matriz.GetUpperBound(0); i++)//percoro as linhas todas
            {
                for (int j = 0; j <= matriz.GetUpperBound(1); j++) // percoro as clunas todas
                {
                    Console.Write("\t "+matriz[i,j]);
                }
                Console.Write("\n");
            }

        }

        static void Main(string[] args)
        {
            Program programa = new Program();
            int valor = 0;
            Console.WriteLine("Informe o tamanho do vetor:");
            int quantidade = Int32.Parse(Console.ReadLine());
            programa.vetor = new int[quantidade];
            programa.matriz = new int[quantidade,quantidade];

            for (int x = 0; x < programa.vetor.Length; x++)
            {
                Console.WriteLine("Digite um valor inteiro para o vetor: ");
                programa.vetor[x] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quantidade; i++)
            {
                for (int j = 0; j < quantidade; j++)
                {
                    Console.WriteLine("Digite um valor inteiro para a matriz: ");
                    programa.matriz[i,j] = Int32.Parse(Console.ReadLine());
                }
            }

            programa.vetor_tmp = new int[quantidade]; ;
            programa.mostraVetor(programa.vetor);
            
            programa.mostrarMatriz(programa.matriz);

            for (int i = 0; i < quantidade; i++)
            {
                valor = 0;
                for (int j = 0; j < quantidade; j++)
                {
                    valor  += programa.matriz[j, i] * programa.vetor[i];
                    programa.vetor_tmp[i] = valor;                  
                }
                
            }
            Console.WriteLine("");
            programa.mostraVetor(programa.vetor_tmp);

        }
    }
}
