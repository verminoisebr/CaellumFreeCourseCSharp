using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using (Stream entrada = File.Open("texto.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    //using ReadLine()
                    string linha = "";
                    while (linha != null)
                    {
                        linha = leitor.ReadLine();
                        textoConteudo.Text += linha + "\n";
                    }
                }
                // using ReadToEnd() unless ReadLine()
                /*string linhaCompleta = leitor.ReadToEnd();
                if (linhaCompleta != null)
                {
                    textoConteudo.Text += linhaCompleta;
                }*/
                
                /*leitor.Close();
                entrada.Close();*/ // this case only when not using "using"
            }
        }

        private void ButtonGrava_Click(object sender, EventArgs e)
        {
            // in this case no using "using", so the stream and StreamWriter need to be closed
            Stream saida = File.Open("texto.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(textoConteudo.Text);
            escritor.Close();
            saida.Close();
        }

        private void ButtonBusca_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0)
            {
                MessageBox.Show("Texto encontrado: " + busca);
            }
            else
            {
                MessageBox.Show("Achou não.");
            }
        }

        private void ButtonSubstitui_Click(object sender, EventArgs e)
        {
            string textoSubstituir = textoSubstitui.Text;
            string busca = textoBusca.Text;
            textoConteudo.Text = textoConteudo.Text.Replace(busca, textoSubstituir);           
        }

        private void ButtonMaiuscula_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;
            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao);
            string antes = textoConteudo.Text.Substring(0, inicioSelecao);
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao);
            
            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois;
        }

        private void ButtonMinuscula_Click(object sender, EventArgs e)
        {
            textoConteudo.Text = textoConteudo.Text.ToLower();
        }
    }
}
