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
    public partial class FormRelatorios : Form
    {

        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void ButtonFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where (c.Saldo>5000)
                            select new { c.Titular.Nome, c.Saldo };
            foreach (var res in resultado)
            {
                listaResultado.Items.Add(res);
            }
            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelMaiorTotal.Text = Convert.ToString(maiorSaldo);
        }

        private void ButtonAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where (c.Numero < 5)
                            orderby c.Titular.Nome
                            select new { c.Numero, c.Titular.Nome };

            //another way to do this
            var resultado2 = contas
                .Where(c => c.Numero < 5)
                .OrderBy(c => c.Titular.Nome)
                .ThenBy(c => c.Numero)
                .Select(c => new { c.Titular.Nome, c.Numero});
                

                            
            foreach (var res in resultado2)
            {
                listaResultado.Items.Add(res);
            }
        }
    }
}
