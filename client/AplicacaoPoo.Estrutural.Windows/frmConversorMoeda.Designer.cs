namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorMoeda
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
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.btnConverterEmReal = new System.Windows.Forms.Button();
            this.cboEscolherMoeda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorEmDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorEmDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEmDolar.ForeColor = System.Drawing.Color.White;
            this.txtValorEmDolar.Location = new System.Drawing.Point(12, 104);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "Valor que deseja converter";
            this.txtValorEmDolar.Size = new System.Drawing.Size(193, 22);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(12, 30);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(173, 17);
            this.lblPrimeiroValor.TabIndex = 3;
            this.lblPrimeiroValor.Text = "120 Dólar americano igual a";
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(12, 57);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(218, 30);
            this.lblSegundoValor.TabIndex = 4;
            this.lblSegundoValor.Text = "614,11 real brasileiro";
            // 
            // btnConverterEmReal
            // 
            this.btnConverterEmReal.BackColor = System.Drawing.Color.DimGray;
            this.btnConverterEmReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterEmReal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConverterEmReal.Location = new System.Drawing.Point(119, 193);
            this.btnConverterEmReal.Name = "btnConverterEmReal";
            this.btnConverterEmReal.Size = new System.Drawing.Size(123, 26);
            this.btnConverterEmReal.TabIndex = 2;
            this.btnConverterEmReal.Text = "Converter em Reais";
            this.btnConverterEmReal.UseVisualStyleBackColor = false;
            this.btnConverterEmReal.Visible = false;
            this.btnConverterEmReal.Click += new System.EventHandler(this.btnConverterEmReal_Click);
            // 
            // cboEscolherMoeda
            // 
            this.cboEscolherMoeda.FormattingEnabled = true;
            this.cboEscolherMoeda.Items.AddRange(new object[] {
            "Dolar Americano ",
            "Euro",
            "Libra Esterlinas"});
            this.cboEscolherMoeda.Location = new System.Drawing.Point(222, 104);
            this.cboEscolherMoeda.Name = "cboEscolherMoeda";
            this.cboEscolherMoeda.Size = new System.Drawing.Size(92, 23);
            this.cboEscolherMoeda.TabIndex = 5;
            // 
            // frmConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(369, 231);
            this.Controls.Add(this.cboEscolherMoeda);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.btnConverterEmReal);
            this.Controls.Add(this.txtValorEmDolar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmConversorMoeda";
            this.Text = "frmConversorMoeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private Button btnConverterEmReal;
        private ComboBox cboEscolherMoeda;
    }
}