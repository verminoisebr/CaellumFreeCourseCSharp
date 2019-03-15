using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente();
            Conta contaVictor = new Conta();
            contaVictor.titular = victor;
            contaVictor.titular.nome = "Victor";
            contaVictor.numero = 1;
            contaVictor.saldo = 300.0;
            contaVictor.idade = 15;
            bool sacou = contaVictor.Saca(250);
            if (sacou)
            {
                MessageBox.Show("Saque feito com sucesso no valor de R$" + contaVictor.saldo.ToString());
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }
               

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaMauricio = new Conta();
            Cliente mauricio = new Cliente();
            contaMauricio.numero = 1;
            contaMauricio.titular = mauricio;
            contaMauricio.titular.nome = "Mauricio";
            contaMauricio.saldo = 100.0;

            Conta contaMauricio2 = new Conta();
            Cliente mauricio2 = new Cliente();
            contaMauricio2.numero = 1;
            contaMauricio2.titular = mauricio2;
            contaMauricio2.titular.nome = "Mauricio";
            contaMauricio2.saldo = 100.0;
            //mauricio2 = mauricio; - dessa maneira seriam iguas

            if (mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("copia = " + copia.saldo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta contaJoao = new Conta();
            Cliente joao = new Cliente();
            contaJoao.saldo = 120;
            contaJoao.titular = joao;
            contaJoao.titular.nome = "Joao";
            contaJoao.numero = 1;

            Conta contaJose = new Conta();
            Cliente jose = new Cliente();
            contaJose.saldo = 70;
            contaJose.titular = jose;
            contaJose.titular.nome = "Jose";
            contaJose.numero = 2;

            bool transferiu = contaJoao.Transfere(130, contaJose);
            if (transferiu)
            {
                MessageBox.Show("Transferido com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.nome = "Guilherme Silveira";
            umaConta.titular = guilherme;

            MessageBox.Show(umaConta.titular.nome);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.rg = "12345678-9";

            umaConta.titular = guilherme;
            umaConta.titular.rg = "98765432-1";

            MessageBox.Show(guilherme.rg);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cliente jorge = new Cliente();
            jorge.idade = 17;
            if (jorge.EhMaiorDeIdade())
            {
                MessageBox.Show("É maior de idade");
            }
            else
            {
                MessageBox.Show("Não é maior de idade");
            }
        }
    }
}
