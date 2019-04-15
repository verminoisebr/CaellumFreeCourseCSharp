namespace EditorDeTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.ButtonGrava = new System.Windows.Forms.Button();
            this.ButtonBusca = new System.Windows.Forms.Button();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSubstitui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textoSubstitui = new System.Windows.Forms.TextBox();
            this.ButtonMinuscula = new System.Windows.Forms.Button();
            this.ButtonMaiuscula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(62, 25);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(199, 160);
            this.textoConteudo.TabIndex = 0;
            // 
            // ButtonGrava
            // 
            this.ButtonGrava.Location = new System.Drawing.Point(62, 295);
            this.ButtonGrava.Name = "ButtonGrava";
            this.ButtonGrava.Size = new System.Drawing.Size(75, 23);
            this.ButtonGrava.TabIndex = 1;
            this.ButtonGrava.Text = "Gravar";
            this.ButtonGrava.UseVisualStyleBackColor = true;
            this.ButtonGrava.Click += new System.EventHandler(this.ButtonGrava_Click);
            // 
            // ButtonBusca
            // 
            this.ButtonBusca.Location = new System.Drawing.Point(186, 217);
            this.ButtonBusca.Name = "ButtonBusca";
            this.ButtonBusca.Size = new System.Drawing.Size(75, 23);
            this.ButtonBusca.TabIndex = 2;
            this.ButtonBusca.Text = "Buscar";
            this.ButtonBusca.UseVisualStyleBackColor = true;
            this.ButtonBusca.Click += new System.EventHandler(this.ButtonBusca_Click);
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(161, 191);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(100, 20);
            this.textoBusca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Localizar";
            // 
            // ButtonSubstitui
            // 
            this.ButtonSubstitui.Location = new System.Drawing.Point(186, 278);
            this.ButtonSubstitui.Name = "ButtonSubstitui";
            this.ButtonSubstitui.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubstitui.TabIndex = 5;
            this.ButtonSubstitui.Text = "Substituir";
            this.ButtonSubstitui.UseVisualStyleBackColor = true;
            this.ButtonSubstitui.Click += new System.EventHandler(this.ButtonSubstitui_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Substituir";
            // 
            // textoSubstitui
            // 
            this.textoSubstitui.Location = new System.Drawing.Point(161, 252);
            this.textoSubstitui.Name = "textoSubstitui";
            this.textoSubstitui.Size = new System.Drawing.Size(100, 20);
            this.textoSubstitui.TabIndex = 7;
            // 
            // ButtonMinuscula
            // 
            this.ButtonMinuscula.Location = new System.Drawing.Point(185, 364);
            this.ButtonMinuscula.Name = "ButtonMinuscula";
            this.ButtonMinuscula.Size = new System.Drawing.Size(75, 23);
            this.ButtonMinuscula.TabIndex = 8;
            this.ButtonMinuscula.Text = "Minuscula";
            this.ButtonMinuscula.UseVisualStyleBackColor = true;
            this.ButtonMinuscula.Click += new System.EventHandler(this.ButtonMinuscula_Click);
            // 
            // ButtonMaiuscula
            // 
            this.ButtonMaiuscula.Location = new System.Drawing.Point(62, 364);
            this.ButtonMaiuscula.Name = "ButtonMaiuscula";
            this.ButtonMaiuscula.Size = new System.Drawing.Size(75, 23);
            this.ButtonMaiuscula.TabIndex = 9;
            this.ButtonMaiuscula.Text = "Maiuscula";
            this.ButtonMaiuscula.UseVisualStyleBackColor = true;
            this.ButtonMaiuscula.Click += new System.EventHandler(this.ButtonMaiuscula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.ButtonMaiuscula);
            this.Controls.Add(this.ButtonMinuscula);
            this.Controls.Add(this.textoSubstitui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSubstitui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoBusca);
            this.Controls.Add(this.ButtonBusca);
            this.Controls.Add(this.ButtonGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button ButtonGrava;
        private System.Windows.Forms.Button ButtonBusca;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSubstitui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoSubstitui;
        private System.Windows.Forms.Button ButtonMinuscula;
        private System.Windows.Forms.Button ButtonMaiuscula;
    }
}

