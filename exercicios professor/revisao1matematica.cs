using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        int[] v = { 1, 2, 3, 5, 7, 9 };

        /**
         * Método para mostrar o conteúdo da lista
         * */
        public void mostra(int[] lista)
        {
            for (int index = 0; index < lista.Length; index++)
                Console.Write("\t" + lista[index]);
        }

        static void Main(string[] args)
        {
            //instancio o programa
            Program programa = new Program();            
            Console.WriteLine("Digite o valor a aplicar no vetor:");
            string valor = Console.ReadLine();
            Console.WriteLine("Digite o sinal a aplicar: (+ ou -):");
            string sinal = Console.ReadLine();
            int valor_converte = int.Parse(valor);
            for(int x = 0; x < programa.v.Length; x++)
            {
                if (sinal.Equals("+")) {
                    programa.v[x] = programa.v[x] + valor_converte;
                } else
                {
                    programa.v[x] = programa.v[x] - valor_converte;
                }
            }
            programa.mostra(programa.v);
            Console.ReadLine();
        }
    }
}
