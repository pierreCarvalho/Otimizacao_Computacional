using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagonalizacao
{
    public partial class Form1 : Form
    {
        //matriz [coluna,linhas]
        float[,] matriz = new float[4, 3];
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        /**
         * Inicializa a matriz com valores randômicos de 1 a 10 em cada posição (valores float)
         * **/
        public String inicializaMatriz() {
            String saida = "";
            for(int linha = 0; linha < 3; linha++)
            {
                for(int coluna = 0; coluna < 4; coluna++)
                {
                    matriz[coluna, linha] = random.Next(9)+1;//+1 para não existir coeficiente = 0
                    saida = saida + "\t"+ matriz[coluna, linha].ToString();
                }
                saida = saida + "\n";
            }
            return saida;
        }


        /**
         * Método que converte a matriz para String (a fim de colocar o conteúdo no richTextBox
         * **/
        public String montaStringMatriz()
        {
            String saida = "";
            for(int linha = 0; linha< 3; linha++)
            {
                for(int coluna = 0; coluna < 4; coluna++)
                {
                    saida = saida + "\t" + matriz[coluna, linha];
                }
                saida = saida + "\n";
            }
            return saida;
        }

        /**
         * Método que torna o valor das diagonais = 1
         * */
        public void diagonalIgualUm()
        {
            for(int indice = 0; indice < 3; indice++)
            {
                if (matriz[indice, indice] != 1)
                {
                    Console.WriteLine("Valor da diagonal " + indice + " diferente de 1: " + matriz[indice, indice]);
                    float divisor = matriz[indice, indice];
                    for(int n = 0; n < 4; n++)
                    {
                        matriz[n, indice] = matriz[n, indice] / divisor;
                        Console.WriteLine("V: " + matriz[n, indice]);
                    }
                    richTextBox1.Text = montaStringMatriz();
                }
            }
        }

        /**
         * Botão que chama a conversão da diagonal para valores = 1
         * **/
        private void button1_Click(object sender, EventArgs e)
        {

            diagonalIgualUm();
        }


        /**
         * Botão que inicializa a matriz com valores randômicos
         * **/
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = inicializaMatriz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zerarMatriz(matriz[0,1]);
            //diagonalIgualUm();
            //zerarMatriz(matriz[0,2]);
            //zerarMatriz(matriz[0, 1]);
        }


        public void zerarMatriz(float numero)
        {
            float valor, result;
            valor = numero;

            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                result = (((-1) * valor) * matriz[i, 0]) + matriz[i, 1];
                if (matriz[1, 1] == 0)
                {
                    MessageBox.Show("Não pode");
                }
                {
                    matriz[i, 1] = result;
                    result = 0;
                }

            }
            richTextBox1.Clear();
            richTextBox1.Text = montaStringMatriz();
        }
    }
}
