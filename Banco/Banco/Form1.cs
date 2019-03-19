using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.conta = new Conta(); // normal class
            //this.conta = new ContaPoupanca(); // inheritance classs
            Cliente cliente = new Cliente("Victor");
            this.conta = new ContaCorrente()
            {
                Numero = 1,
                Titular = cliente
            };
            //this.conta.Numero = 1;
            //this.conta.Titular = cliente;

            textoTitular.Text = this.conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(this.conta.Numero);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void ButtonSoma_Click(object sender, EventArgs e)
        {
            
            Conta contaNormal = new Conta();
            Conta contaCorrente = new ContaCorrente();
            Conta contaPoupanca = new ContaPoupanca();
            Cliente victor = new Cliente("Victor");
            contaNormal.Titular = victor;
            contaPoupanca.Titular = victor;
            contaCorrente.Titular = victor;
            contaNormal.Deposita(10);
            contaPoupanca.Deposita(20);
            contaCorrente.Deposita(30);
            TotalizadorContas total = new TotalizadorContas();
            total.Adiciona(contaNormal);
            total.Adiciona(contaPoupanca);
            total.Adiciona(contaCorrente);
            MessageBox.Show("Saldo total de "+victor.Nome+" é de: "+total.SaldoTotal.ToString());
        }
    }
}
