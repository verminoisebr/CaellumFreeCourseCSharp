namespace BancoArray
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboContas = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonTransferencia = new System.Windows.Forms.Button();
            this.ComboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSaca = new System.Windows.Forms.Button();
            this.ButtonDeposito = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.ButtonNovaConta = new System.Windows.Forms.Button();
            this.ButtonImpostos = new System.Windows.Forms.Button();
            this.ButtonTotalizadorArray = new System.Windows.Forms.Button();
            this.ButtonTeste = new System.Windows.Forms.Button();
            this.ComboTeste = new System.Windows.Forms.ComboBox();
            this.ButtonBuscaDictionary = new System.Windows.Forms.Button();
            this.ComboBuscaDictionay = new System.Windows.Forms.ComboBox();
            this.textoBuscaDictionary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboContas);
            this.groupBox1.Location = new System.Drawing.Point(42, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de Conta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Titular";
            // 
            // ComboContas
            // 
            this.ComboContas.FormattingEnabled = true;
            this.ComboContas.Location = new System.Drawing.Point(107, 30);
            this.ComboContas.Name = "ComboContas";
            this.ComboContas.Size = new System.Drawing.Size(121, 21);
            this.ComboContas.TabIndex = 0;
            this.ComboContas.SelectedIndexChanged += new System.EventHandler(this.ComboContas_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ButtonTransferencia);
            this.groupBox2.Controls.Add(this.ComboDestinoTransferencia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ButtonSaca);
            this.groupBox2.Controls.Add(this.ButtonDeposito);
            this.groupBox2.Controls.Add(this.textoValor);
            this.groupBox2.Controls.Add(this.textoSaldo);
            this.groupBox2.Controls.Add(this.textoNumero);
            this.groupBox2.Controls.Add(this.textoTitular);
            this.groupBox2.Location = new System.Drawing.Point(42, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Conta destino";
            // 
            // ButtonTransferencia
            // 
            this.ButtonTransferencia.Location = new System.Drawing.Point(62, 246);
            this.ButtonTransferencia.Name = "ButtonTransferencia";
            this.ButtonTransferencia.Size = new System.Drawing.Size(89, 23);
            this.ButtonTransferencia.TabIndex = 11;
            this.ButtonTransferencia.Text = "Transferência";
            this.ButtonTransferencia.UseVisualStyleBackColor = true;
            this.ButtonTransferencia.Click += new System.EventHandler(this.ButtonTransferencia_Click);
            // 
            // ComboDestinoTransferencia
            // 
            this.ComboDestinoTransferencia.FormattingEnabled = true;
            this.ComboDestinoTransferencia.Location = new System.Drawing.Point(107, 209);
            this.ComboDestinoTransferencia.Name = "ComboDestinoTransferencia";
            this.ComboDestinoTransferencia.Size = new System.Drawing.Size(121, 21);
            this.ComboDestinoTransferencia.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // ButtonSaca
            // 
            this.ButtonSaca.Location = new System.Drawing.Point(153, 138);
            this.ButtonSaca.Name = "ButtonSaca";
            this.ButtonSaca.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaca.TabIndex = 5;
            this.ButtonSaca.Text = "Saque";
            this.ButtonSaca.UseVisualStyleBackColor = true;
            this.ButtonSaca.Click += new System.EventHandler(this.ButtonSaca_Click);
            // 
            // ButtonDeposito
            // 
            this.ButtonDeposito.Location = new System.Drawing.Point(62, 138);
            this.ButtonDeposito.Name = "ButtonDeposito";
            this.ButtonDeposito.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeposito.TabIndex = 4;
            this.ButtonDeposito.Text = "Deposito";
            this.ButtonDeposito.UseVisualStyleBackColor = true;
            this.ButtonDeposito.Click += new System.EventHandler(this.ButtonDeposito_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(128, 97);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 3;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(128, 71);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(128, 45);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(128, 19);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // ButtonNovaConta
            // 
            this.ButtonNovaConta.Location = new System.Drawing.Point(68, 444);
            this.ButtonNovaConta.Name = "ButtonNovaConta";
            this.ButtonNovaConta.Size = new System.Drawing.Size(75, 23);
            this.ButtonNovaConta.TabIndex = 2;
            this.ButtonNovaConta.Text = "Nova Conta";
            this.ButtonNovaConta.UseVisualStyleBackColor = true;
            this.ButtonNovaConta.Click += new System.EventHandler(this.ButtonNovaConta_Click);
            // 
            // ButtonImpostos
            // 
            this.ButtonImpostos.Location = new System.Drawing.Point(194, 444);
            this.ButtonImpostos.Name = "ButtonImpostos";
            this.ButtonImpostos.Size = new System.Drawing.Size(75, 23);
            this.ButtonImpostos.TabIndex = 3;
            this.ButtonImpostos.Text = "Impostos";
            this.ButtonImpostos.UseVisualStyleBackColor = true;
            this.ButtonImpostos.Click += new System.EventHandler(this.ButtonImpostos_Click);
            // 
            // ButtonTotalizadorArray
            // 
            this.ButtonTotalizadorArray.Location = new System.Drawing.Point(313, 407);
            this.ButtonTotalizadorArray.Name = "ButtonTotalizadorArray";
            this.ButtonTotalizadorArray.Size = new System.Drawing.Size(99, 23);
            this.ButtonTotalizadorArray.TabIndex = 4;
            this.ButtonTotalizadorArray.Text = "Totalizador Array";
            this.ButtonTotalizadorArray.UseVisualStyleBackColor = true;
            this.ButtonTotalizadorArray.Click += new System.EventHandler(this.ButtonTotalizadorArray_Click);
            // 
            // ButtonTeste
            // 
            this.ButtonTeste.Location = new System.Drawing.Point(313, 227);
            this.ButtonTeste.Name = "ButtonTeste";
            this.ButtonTeste.Size = new System.Drawing.Size(75, 23);
            this.ButtonTeste.TabIndex = 5;
            this.ButtonTeste.Text = "Teste";
            this.ButtonTeste.UseVisualStyleBackColor = true;
            this.ButtonTeste.Click += new System.EventHandler(this.ButtonTeste_Click);
            // 
            // ComboTeste
            // 
            this.ComboTeste.FormattingEnabled = true;
            this.ComboTeste.Location = new System.Drawing.Point(313, 190);
            this.ComboTeste.Name = "ComboTeste";
            this.ComboTeste.Size = new System.Drawing.Size(121, 21);
            this.ComboTeste.TabIndex = 6;
            // 
            // ButtonBuscaDictionary
            // 
            this.ButtonBuscaDictionary.Location = new System.Drawing.Point(204, 92);
            this.ButtonBuscaDictionary.Name = "ButtonBuscaDictionary";
            this.ButtonBuscaDictionary.Size = new System.Drawing.Size(75, 23);
            this.ButtonBuscaDictionary.TabIndex = 7;
            this.ButtonBuscaDictionary.Text = "Buscar";
            this.ButtonBuscaDictionary.UseVisualStyleBackColor = true;
            this.ButtonBuscaDictionary.Click += new System.EventHandler(this.ButtonBuscaDictionary_Click);
            // 
            // ComboBuscaDictionay
            // 
            this.ComboBuscaDictionay.FormattingEnabled = true;
            this.ComboBuscaDictionay.Location = new System.Drawing.Point(98, 44);
            this.ComboBuscaDictionay.Name = "ComboBuscaDictionay";
            this.ComboBuscaDictionay.Size = new System.Drawing.Size(181, 21);
            this.ComboBuscaDictionay.TabIndex = 8;
            // 
            // textoBuscaDictionary
            // 
            this.textoBuscaDictionary.Location = new System.Drawing.Point(97, 94);
            this.textoBuscaDictionary.Name = "textoBuscaDictionary";
            this.textoBuscaDictionary.Size = new System.Drawing.Size(100, 20);
            this.textoBuscaDictionary.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Escolha a Conta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Busca por titular";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboBuscaDictionay);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ButtonBuscaDictionary);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textoBuscaDictionary);
            this.groupBox3.Location = new System.Drawing.Point(458, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 169);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busca de Conta Dictionary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ComboTeste);
            this.Controls.Add(this.ButtonTeste);
            this.Controls.Add(this.ButtonTotalizadorArray);
            this.Controls.Add(this.ButtonImpostos);
            this.Controls.Add(this.ButtonNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboContas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonSaca;
        private System.Windows.Forms.Button ButtonDeposito;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonTransferencia;
        private System.Windows.Forms.ComboBox ComboDestinoTransferencia;
        private System.Windows.Forms.Button ButtonNovaConta;
        private System.Windows.Forms.Button ButtonImpostos;
        private System.Windows.Forms.Button ButtonTotalizadorArray;
        private System.Windows.Forms.Button ButtonTeste;
        private System.Windows.Forms.ComboBox ComboTeste;
        private System.Windows.Forms.Button ButtonBuscaDictionary;
        private System.Windows.Forms.ComboBox ComboBuscaDictionay;
        private System.Windows.Forms.TextBox textoBuscaDictionary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

