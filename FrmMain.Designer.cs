
namespace SitemaBancario
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAbrirConta = new System.Windows.Forms.Button();
            this.txtTipoConta = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.iblSaldo = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.txtNumeroOP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAbrirConta);
            this.groupBox1.Controls.Add(this.txtTipoConta);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtNumeroC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes e Contas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CPF do Proprietário";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAbrirConta
            // 
            this.btnAbrirConta.Location = new System.Drawing.Point(31, 275);
            this.btnAbrirConta.Name = "btnAbrirConta";
            this.btnAbrirConta.Size = new System.Drawing.Size(100, 23);
            this.btnAbrirConta.TabIndex = 0;
            this.btnAbrirConta.Text = "Abri_Uma_Conta";
            this.btnAbrirConta.UseVisualStyleBackColor = true;
            this.btnAbrirConta.Click += new System.EventHandler(this.btnAbrirConta_Click);
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.FormattingEnabled = true;
            this.txtTipoConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupanca",
            "Conta Universitatia"});
            this.txtTipoConta.Location = new System.Drawing.Point(31, 231);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.Size = new System.Drawing.Size(121, 21);
            this.txtTipoConta.TabIndex = 0;
            this.txtTipoConta.SelectedIndexChanged += new System.EventHandler(this.txtTipoConta_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtNumeroC
            // 
            this.txtNumeroC.Location = new System.Drawing.Point(31, 44);
            this.txtNumeroC.Name = "txtNumeroC";
            this.txtNumeroC.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroC.TabIndex = 0;
            this.txtNumeroC.TextChanged += new System.EventHandler(this.txtNumeroC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Conta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proprietário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Conta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaldo);
            this.groupBox2.Controls.Add(this.btnDepositar);
            this.groupBox2.Controls.Add(this.iblSaldo);
            this.groupBox2.Controls.Add(this.btnSaque);
            this.groupBox2.Controls.Add(this.txtNumeroOP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(327, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caixa Eletronico";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(220, 190);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnSaldo.TabIndex = 7;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(110, 190);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 6;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // iblSaldo
            // 
            this.iblSaldo.Location = new System.Drawing.Point(6, 231);
            this.iblSaldo.Name = "iblSaldo";
            this.iblSaldo.Size = new System.Drawing.Size(195, 48);
            this.iblSaldo.TabIndex = 4;
            this.iblSaldo.Text = "0";
            this.iblSaldo.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(6, 190);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 5;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // txtNumeroOP
            // 
            this.txtNumeroOP.Location = new System.Drawing.Point(6, 140);
            this.txtNumeroOP.Name = "txtNumeroOP";
            this.txtNumeroOP.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroOP.TabIndex = 3;
            this.txtNumeroOP.TextChanged += new System.EventHandler(this.txtNumeroOP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Num.Conta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(6, 75);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(31, 177);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Sis Bancario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrirConta;
        private System.Windows.Forms.ComboBox txtTipoConta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroOP;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Label iblSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCPF;
    }
}

