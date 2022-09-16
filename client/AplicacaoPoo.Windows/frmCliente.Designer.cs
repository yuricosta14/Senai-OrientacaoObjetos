namespace AplicacaoPoo.Windows
{
    partial class frmCliente
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
            this.txtValorDebito = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblValorCredito = new System.Windows.Forms.Label();
            this.lblValorDebito = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSaldoInicialValor = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(21, 119);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(100, 23);
            this.txtValorDebito.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(181, 51);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 23);
            this.txtCpf.TabIndex = 3;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(186, 33);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(28, 15);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF";
            // 
            // lblValorCredito
            // 
            this.lblValorCredito.AutoSize = true;
            this.lblValorCredito.Location = new System.Drawing.Point(181, 101);
            this.lblValorCredito.Name = "lblValorCredito";
            this.lblValorCredito.Size = new System.Drawing.Size(92, 15);
            this.lblValorCredito.TabIndex = 5;
            this.lblValorCredito.Text = "VALOR CREDITO";
            // 
            // lblValorDebito
            // 
            this.lblValorDebito.AutoSize = true;
            this.lblValorDebito.Location = new System.Drawing.Point(21, 101);
            this.lblValorDebito.Name = "lblValorDebito";
            this.lblValorDebito.Size = new System.Drawing.Size(84, 15);
            this.lblValorDebito.TabIndex = 6;
            this.lblValorDebito.Text = "VALOR DEBITO";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 15);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "NOME";
            // 
            // lblSaldoInicialValor
            // 
            this.lblSaldoInicialValor.AutoSize = true;
            this.lblSaldoInicialValor.Location = new System.Drawing.Point(373, 59);
            this.lblSaldoInicialValor.Name = "lblSaldoInicialValor";
            this.lblSaldoInicialValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoInicialValor.TabIndex = 8;
            this.lblSaldoInicialValor.Text = "0";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.Location = new System.Drawing.Point(373, 127);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoValor.TabIndex = 9;
            this.lblSaldoValor.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(21, 164);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(341, 33);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(87, 15);
            this.lblSaldoInicial.TabIndex = 11;
            this.lblSaldoInicial.Text = "SALDO INICIAL";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(359, 101);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 15);
            this.lblSaldo.TabIndex = 12;
            this.lblSaldo.Text = "SALDO";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(463, 196);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSaldoValor);
            this.Controls.Add(this.lblSaldoInicialValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValorDebito);
            this.Controls.Add(this.lblValorCredito);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtValorDebito);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.Text = "Cliente ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtValorDebito;
        private TextBox textBox2;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label lblCpf;
        private Label lblValorCredito;
        private Label lblValorDebito;
        private Label lblNome;
        private Label lblSaldoInicialValor;
        private Label lblSaldoValor;
        private Button btnCalcular;
        private Label lblSaldoInicial;
        private Label lblSaldo;
    }
}