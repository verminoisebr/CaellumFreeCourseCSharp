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
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        textoConteudo.Text += linha;
                        linha = leitor.ReadLine();
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
    }
}
