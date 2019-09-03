using System;

namespace aula1
{
    class Program
    {
        public static int[] vetor = new int[5];
        static void Main(string[] args)
        {
            

            for (int i = 0; i < 5; i++)
            {
                vetor[i] = i+1;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" "+vetor[i]);
            }

            Console.WriteLine("digite o numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o sinal: + ou -");
            string operador = Console.ReadLine();
            char op = operador[0];
            Console.WriteLine(op);
            
            realizarOperacao(numero,operador);

        }

        public static void realizarOperacao(int numero, string op)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (op.Equals("+"))
                {
                    vetor[i] = vetor[i] + numero;
                }
                else
                {
                    vetor[i] = vetor[i] - numero;
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("" + vetor[i]);
            }
        }


    }



}
