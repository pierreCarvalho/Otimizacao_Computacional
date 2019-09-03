using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorVetor
{
    class Program
    {
        //o software deve possuir um vetor inicial, com valores já alocados
        int[] vetor = {1,2,3,4,5,6,7,8,9,10};

        public void mostraVetor(int[] vet) {
            for(int index = 0; index < vet.Length; index++)
            {
                Console.Write("\t" + vet[index]);
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            
            //instancio a classe
            Program programa = new Program();
            //vetor para armazenar os valores digitados pelo usuário
            int[] vetorUsuario = new int[programa.vetor.Length];

            for (int x=0; x < programa.vetor.Length; x++)
            {
                Console.WriteLine("Digite um valor inteiro: ");
                vetorUsuario[x] = Int32.Parse(Console.ReadLine());                
            }

            Console.WriteLine("Digite a operação: (soma, sub, mult, div):");
            String op = Console.ReadLine();
            
            for(int y=0; y < programa.vetor.Length; y++)
            {
                if (op.Equals("soma")) { programa.vetor[y] = programa.vetor[y] + vetorUsuario[y]; }
                if (op.Equals("sub")) { programa.vetor[y] = programa.vetor[y] - vetorUsuario[y]; }
                if (op.Equals("mult")) { programa.vetor[y] = programa.vetor[y] * vetorUsuario[y]; }
                if (op.Equals("div")) { programa.vetor[y] = programa.vetor[y] / vetorUsuario[y]; }

            }

            programa.mostraVetor(programa.vetor);
            //para ficar esperando o fim da execução
            Console.ReadLine();
        }
    }
}
