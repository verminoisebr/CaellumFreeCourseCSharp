using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoArray.Contas;

namespace BancoArray
{    
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private Dictionary<string, Conta> dicionario; //variable type of dictionary for search exercise
        //private int numeroDeContas = 0; // is static now
                
        public Form1()
        {
            InitializeComponent();            
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[Conta.ProximaConta()-1] = conta;            
            //conta.Numero = this.numeroDeContas; // it's static now
            //this.numeroDeContas++;
            ComboContas.Items.Add(conta);
            ComboDestinoTransferencia.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);// filling in Dictionary for post search 
            ComboBuscaDictionay.Items.Add(conta);            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dicionario = new Dictionary<string, Conta>();// instantiating dictionary for search exercise

            this.contas = new Conta[10];
            /*Conta c1 = new Conta() { Titular = new Cliente("Victor"), Numero = 1  };
            this.AdicionaConta(c1);*/ // abstract class, not allowed
            Conta c2 = new ContaCorrente() { Titular = new Cliente("Mauricio")};
            this.AdicionaConta(c2);
            Conta c3 = new ContaPoupanca() { Titular = new Cliente("Osni")};
            this.AdicionaConta(c3);

            //testing comboBox without using custom ToString()
            Conta c = new ContaCorrente() { Numero = 1 };
            Conta c12 = new ContaCorrente() { Numero = 2 };
            /*ComboTeste.DisplayMember = Convert.ToString(c.Numero);
            ComboTeste.DisplayMember = Convert.ToString(c12.Numero);*/
            ComboTeste.Items.Add(Convert.ToString(c.Numero));
            ComboTeste.Items.Add(Convert.ToString(c12.Numero)); 
            ComboTeste.DisplayMember = "Numero";// i dont know if is working how it shoud be, the statement of exercise is confusing...
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
            try
            {
                /*int indice = ComboContas.SelectedIndex;
                this.contas[indice].Deposita(Convert.ToDouble(textoValor.Text));
                textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
                MessageBox.Show("Sucesso");*/ // before overriding ToString() method

                //using custom ToString()
                Conta selecionada = (Conta)ComboContas.SelectedItem;
                selecionada.Deposita(Convert.ToDouble(textoValor.Text));
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)// is the variable "ex" really necessary?
            {
                MessageBox.Show("Argumento inválido!");
            }
        }

        private void ButtonSaca_Click(object sender, EventArgs e)
        {
            try
            {
                /*int indice = ComboContas.SelectedIndex;
                this.contas[indice].Saca(Convert.ToDouble(textoValor.Text));
                textoSaldo.Text = Convert.ToString(this.contas[indice].Saldo);
                MessageBox.Show("Sucesso");*/ // using original ToString()

                //using custom ToString()
                Conta selecionada = (Conta)ComboContas.SelectedItem;
                selecionada.Saca(Convert.ToDouble(textoValor.Text));
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            
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

        private void ButtonImpostos_Click(object sender, EventArgs e)
        {
            /*ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            MessageBox.Show("imposto da conta corrente = " + conta.CalculaTributo());
            ITributavel t = conta;

            MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributo());

            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show("imposto do seguro = " + sv.CalculaTributo());

            t = sv;
            MessageBox.Show("imposto do seguro pela interface = " + t.CalculaTributo());*/ //example 1 of interface
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200);
            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorTributos totalizador = new TotalizadorTributos();
            totalizador.Adiciona(conta);
            MessageBox.Show("Tributos = "+totalizador.Total);
            totalizador.Adiciona(sv);
            MessageBox.Show("Tributos = "+totalizador.Total);
        }

        private void ButtonTotalizadorArray_Click(object sender, EventArgs e)
        {
            TotalizadorTributos totalizador = new TotalizadorTributos();
            for (int i =0; i<contas.Length; i++)
            {
                if (contas[i] is ContaCorrente con)
                {                    
                    totalizador.Adiciona(con);
                }                
            }
            MessageBox.Show("Tributos Todas Contas Correntes cadastradas é: R$" + totalizador.Total);
        }

            
        private void ButtonTeste_Click(object sender, EventArgs e)
        {
            
        }

        private void ComboBuscaDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboBuscaDictionay.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        //i dont lnow how to rename this button without crash. Yes, i discovered how. Rename button in action properties
        /*private void button1_Click(object sender, EventArgs e)
        {

        }*/

        // i dont konw how to remove this void without crash
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBuscaDictionary_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscaDictionary.Text;//saving typed name

            try
            {
                Conta conta = dicionario[nomeTitular];//searching using dictionary

                /* //refreshing fields with values
                 textoTitular.Text = conta.Titular.Nome;
                 textoNumero.Text = Convert.ToString(conta.Numero);
                 textoSaldo.Text = Convert.ToString(conta.Saldo);*/
                ComboContas.SelectedItem = conta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario não cadastrado");
            }
            
        }
    }
}
