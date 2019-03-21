using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoArray
{    
    public partial class Form1 : Form
    {
        private Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[3];
            this.contas[0] = new Conta() { Titular = new Cliente("Victor"), Numero = 1  };
            this.contas[1] = new ContaCorrente() { Titular = new Cliente("Mauricio"), Numero = 2 };
            this.contas[2] = new ContaPoupanca() { Titular = new Cliente("Osni"), Numero = 3 };

            foreach (Conta conta in this.contas)
            {
                ComboContas.Items.Add(conta.Titular.Nome);
                ComboDestinoTransferencia.Items.Add(conta.Titular.Nome);
            }
        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void ButtonDeposito_Click(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            this.contas[indice].Deposita(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
            MessageBox.Show("Sucesso");
        }

        private void ButtonSaca_Click(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            this.contas[indice].Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
            MessageBox.Show("Sucesso");
        }

        private void ButtonTransferencia_Click(object sender, EventArgs e)
        {
            int indice1 = ComboContas.SelectedIndex;
            this.contas[indice1].Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.contas[indice1].Saldo);
            int indice2 = ComboDestinoTransferencia.SelectedIndex;
            this.contas[indice2].Deposita(Convert.ToDouble(textoValor.Text));
            MessageBox.Show("Sucesso");
        }
    }
}
