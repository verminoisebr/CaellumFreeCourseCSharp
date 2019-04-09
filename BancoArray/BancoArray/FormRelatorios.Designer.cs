namespace BancoArray
{
    partial class FormRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.ButtonFiltroSaldo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.labelMaiorTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAntigas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(101, 29);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(307, 199);
            this.listaResultado.TabIndex = 0;
            // 
            // ButtonFiltroSaldo
            // 
            this.ButtonFiltroSaldo.Location = new System.Drawing.Point(101, 362);
            this.ButtonFiltroSaldo.Name = "ButtonFiltroSaldo";
            this.ButtonFiltroSaldo.Size = new System.Drawing.Size(134, 23);
            this.ButtonFiltroSaldo.TabIndex = 1;
            this.ButtonFiltroSaldo.Text = "Saldo maior que 5000";
            this.ButtonFiltroSaldo.UseVisualStyleBackColor = true;
            this.ButtonFiltroSaldo.Click += new System.EventHandler(this.ButtonFiltroSaldo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSaldoTotal);
            this.groupBox1.Controls.Add(this.labelMaiorTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(101, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(201, 37);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(80, 13);
            this.labelSaldoTotal.TabIndex = 3;
            this.labelSaldoTotal.Text = "labelSaldoTotal";
            // 
            // labelMaiorTotal
            // 
            this.labelMaiorTotal.AutoSize = true;
            this.labelMaiorTotal.Location = new System.Drawing.Point(201, 65);
            this.labelMaiorTotal.Name = "labelMaiorTotal";
            this.labelMaiorTotal.Size = new System.Drawing.Size(82, 13);
            this.labelMaiorTotal.TabIndex = 2;
            this.labelMaiorTotal.Text = "labelMaiorSaldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maior Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Total";
            // 
            // ButtonAntigas
            // 
            this.ButtonAntigas.Location = new System.Drawing.Point(305, 361);
            this.ButtonAntigas.Name = "ButtonAntigas";
            this.ButtonAntigas.Size = new System.Drawing.Size(75, 23);
            this.ButtonAntigas.TabIndex = 3;
            this.ButtonAntigas.Text = "Antigas";
            this.ButtonAntigas.UseVisualStyleBackColor = true;
            this.ButtonAntigas.Click += new System.EventHandler(this.ButtonAntigas_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAntigas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button ButtonFiltroSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label labelMaiorTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAntigas;
    }
}