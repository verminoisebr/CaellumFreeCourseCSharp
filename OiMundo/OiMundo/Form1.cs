using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Mthfck!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade1 = 10;
            int idade2 = 20;
            int idade3 = 30;
            float media;
            media = (idade1 + idade2 + idade3) / 3;
            MessageBox.Show("A média das idades é: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("O valor de piQuebrado é: " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a=2, b=3, c=4;
            double delta, a1, a2;
            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(Math.Abs(delta))) / (2 * a);
            a2 = (-b - Math.Sqrt(Math.Abs(delta))) / (2 * a);
            MessageBox.Show("O valor de a1 e a2 respectivamente é: " + a1 + " e " + a2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;
            if (idade > 15 && brasileira)
            {
                MessageBox.Show("Está apto a votar.");
            }
            else
            {
                MessageBox.Show("Não está apto a votar.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 1001;
            if (valorDaNotaFiscal <= 999)
            {
                MessageBox.Show("O imposto é 2%");
            }
            else if (valorDaNotaFiscal <= 2999)
            {
                MessageBox.Show("O imposto é 2.5%");
            }
            else if (valorDaNotaFiscal <= 6999)
            {
                MessageBox.Show("O imposto é 2.8%");
            }
            else
            {
                MessageBox.Show("O imposto é 3%");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem;
            mensagem = (valor>10) ? "Maior que dez." : "menor que dez."; // operador ternario
            MessageBox.Show(mensagem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }
    }
}
