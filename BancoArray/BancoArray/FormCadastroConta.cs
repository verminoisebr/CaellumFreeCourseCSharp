﻿using System;
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
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
               
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            string[] tipoDeConta = new string[] { "Conta Poupanca", "Conta Corrente" };
            
            InitializeComponent();

            ComboTipoConta.Items.AddRange(tipoDeConta);
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            int indice = ComboTipoConta.SelectedIndex;
            if(indice == 0)
            {
                /*Conta novaConta = new Conta { Titular = new Cliente(textoTitular.Text), Numero = Convert.ToInt32(textoNumero.Text) };
                this.formPrincipal.AdicionaConta(novaConta);
                MessageBox.Show("Sucesso"); */ //used before Conta is an abstract class
                Conta novaConta = new ContaPoupanca { Titular = new Cliente(textoTitular.Text)/*, Numero = Convert.ToInt32(textoNumero.Text)*/ };
                this.formPrincipal.AdicionaConta(novaConta);
                MessageBox.Show("Sucesso");
            }
            else if (indice ==1)
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
            }            
        }        
        
        private void ComboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
