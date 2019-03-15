using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contador = "";            
            for (int i =1; i<=1000; i++)
            {
                contador += i.ToString("0000") + " ";
            }
            MessageBox.Show(contador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contador = "";
            for (int i =1; i<=100; i++)
            {
                if (i%3 == 0)
                {
                    contador += i.ToString("000") + " ";
                }
            }
            MessageBox.Show(contador);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //soma todos que nã são multiplos de 3
            int contador = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    i++;
                }
                contador += i;
            }
            MessageBox.Show(contador.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string contador = "";
            for (int i = 1; i<31; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    contador += i.ToString("00") + " ";
                }
            }
            MessageBox.Show(contador);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            string texto = "";
            for(int i = 1; i<=10; i++)
            {
                fatorial *= i;
                texto += "O fatorial de " + i + " é: " + fatorial + "\n";
            }
            MessageBox.Show(texto);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string resultado = "000 001 ";
            int n1 = 1, n2 = 0, n=0;
            while(true)
                {                     
                        n = n1 + n2;
                        n2 = n1;
                        n1 = n;                        
                        if (n >= 100)
                        {
                            break;
                        }
                        resultado += n.ToString("000") + " ";
                }
            MessageBox.Show(resultado);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string linha, coluna;
            for (int i = 1; i <= 10; i++)
            {
                linha = i;
            }
        }
    }
}
