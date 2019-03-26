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

        private int numeroDeContas = 0;
                
        public Form1()
        {
            InitializeComponent();            
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            conta.Numero = this.numeroDeContas;
            this.numeroDeContas++;
            ComboContas.Items.Add(conta.Titular.Nome);
            ComboDestinoTransferencia.Items.Add(conta.Titular.Nome);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[10];
            /*Conta c1 = new Conta() { Titular = new Cliente("Victor"), Numero = 1  };
            this.AdicionaConta(c1);*/
            Conta c2 = new ContaCorrente() { Titular = new Cliente("Mauricio")};
            this.AdicionaConta(c2);
            Conta c3 = new ContaPoupanca() { Titular = new Cliente("Osni")};
            this.AdicionaConta(c3);           
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
        
        private void ButtonNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }
    }
}
