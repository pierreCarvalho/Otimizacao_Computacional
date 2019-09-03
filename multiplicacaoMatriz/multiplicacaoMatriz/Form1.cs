using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplicacaoMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int[,] matriz_1,matriz_2, matriz_resultado;
        private int[,] iniciaMatriz(int tamanho, int[,] matriz)
        {
            
            for (int linha = 0; linha < tamanho; linha++)
            {
                for (int coluna = 0; coluna < tamanho; coluna++)
                {
                    matriz[linha, coluna] = random.Next(20);
                }
            }
            return matriz;
        }

        private string mostraMatriz(int[,] matriz)
        {
            String smatriz = "";
            for (int a = 0; a < matriz.GetLength(0); a++)
            {
                for (int b = 0; b < matriz.GetLength(0); b++)
                {
                    smatriz += matriz[a, b]+ "\t";
                }
                smatriz = smatriz + "\n";
            }
            return smatriz;
        }

        public String calcularMatriz()
        {
            String smatriz = "";
            matriz_resultado = new int[matriz_1.GetLength(0),matriz_1.GetLength(0)];
            for (int i = 0; i < matriz_1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz_1.GetLength(0); j++)
                {
                    for (int k = 0; k < matriz_1.GetLength(0); k++)
                    {
                        matriz_resultado[i,j] += matriz_1[i,k] * matriz_2[k,j];
                    }
                }
            }

            for (int i = 0; i < matriz_resultado.GetLength(0); i++)
            {
                for (int j = 0; j < matriz_resultado.GetLength(0); j++)
                {
                    smatriz += matriz_resultado[i,j] + "\t";
                }
                smatriz = smatriz + "\n";
            }
            return smatriz;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
            int tamanho = Int32.Parse(textBox1.Text);
            matriz_1=  new int[tamanho, tamanho];//matriz quadrada
            matriz_2 = new int[tamanho, tamanho];//matriz quadrada

            matriz_1 = iniciaMatriz(tamanho,matriz_1);
            matriz_2 = iniciaMatriz(tamanho, matriz_2);

            String smatriz1 = mostraMatriz(matriz_1);
            String smatriz2 = mostraMatriz(matriz_2);

            richTextBox1.AppendText(smatriz1);
            richTextBox2.AppendText(smatriz2);
            String smatrizResultado = calcularMatriz();
            richTextBox3.AppendText(smatrizResultado);
            textBox1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            richTextBox2.ResetText();
            richTextBox3.ResetText();
        }
    }
}
