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
using BancoArray.Busca; // to use GeradorDeDevedores class

namespace BancoArray
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores; //creating debtors's collection

        private Form1 formPrincipal;
               
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            string[] tipoDeConta = new string[] { "Conta Poupanca", "Conta Corrente", "Conta Investimento" };
            
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores(); // creating variable for debtors's generation
            this.devedores = gerador.GeraList(); // Debtors's list created with collection properties

            textoNumero.Enabled = false; // user not allowed to change this field

            ComboTipoConta.Items.AddRange(tipoDeConta);

            textoNumero.Text = Convert.ToString(Conta.ProximaConta());
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            
            bool ehDevedor = this.devedores.Contains(titular);// checking if user of a new Conta is in Debtors's list

            if (!ehDevedor) // if is not a debtor, create Conta
            {
                int indice = ComboTipoConta.SelectedIndex;

                if (indice == 0)
                {
                    /*Conta novaConta = new Conta { Titular = new Cliente(textoTitular.Text), Numero = Convert.ToInt32(textoNumero.Text) };
                    this.formPrincipal.AdicionaConta(novaConta);
                    MessageBox.Show("Sucesso"); */ //used before Conta is an abstract class
                    Conta novaConta = new ContaPoupanca { Titular = new Cliente(textoTitular.Text)/*, Numero = Convert.ToInt32(textoNumero.Text)*/ };
                    this.formPrincipal.AdicionaConta(novaConta);
                    MessageBox.Show("Sucesso");
                }
                else if (indice == 1)
                {
                    Conta novaConta = new ContaCorrente { Titular = new Cliente(textoTitular.Text)/*, Numero = Convert.ToInt32(textoNumero.Text)*/ };
                    this.formPrincipal.AdicionaConta(novaConta);
                    MessageBox.Show("Sucesso");
                }
                else
                {
                    /*Conta novaConta = new ContaCorrente { Titular = new Cliente(textoTitular.Text), Numero = Convert.ToInt32(textoNumero.Text) };
                    this.formPrincipal.AdicionaConta(novaConta);
                    MessageBox.Show("Sucesso");*/
                    Conta novaConta = new ContaInvestimento { Titular = new Cliente(textoTitular.Text) };
                    this.formPrincipal.AdicionaConta(novaConta);
                    MessageBox.Show("Sucesso");
                }
            }
            else
            {
                MessageBox.Show("Devedor");
            }

            textoNumero.Text = Convert.ToString(Conta.ProximaConta()); //refresh field after register

            textoTitular.Text = ""; //refresh field after register
            
            ComboTipoConta.SelectedItem = null; //refresh field after register
        }        
        
        private void ComboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
