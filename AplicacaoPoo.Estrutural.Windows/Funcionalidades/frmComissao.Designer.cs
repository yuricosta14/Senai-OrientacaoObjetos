namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmComissao
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
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.pictureHomem = new System.Windows.Forms.PictureBox();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.lblPecaVendida = new System.Windows.Forms.Label();
            this.txtIdentifiacacaoVendedor = new System.Windows.Forms.TextBox();
            this.txtPeçaVendida = new System.Windows.Forms.TextBox();
            this.lblCodigoPeça = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblQuantidadePeça = new System.Windows.Forms.Label();
            this.lblPrecoPeça = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtUnidadeVendida = new System.Windows.Forms.TextBox();
            this.txtPreço = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHomem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Location = new System.Drawing.Point(123, 25);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(222, 15);
            this.lblBoasVindas.TabIndex = 0;
            this.lblBoasVindas.Text = "BEM VINDO AO SISTEMA DO VENDEDOR";
            // 
            // pictureHomem
            // 
            this.pictureHomem.Image = global::AplicacaoPoo.Estrutural.Windows.Properties.Resources.homem__2_;
            this.pictureHomem.Location = new System.Drawing.Point(23, 95);
            this.pictureHomem.Name = "pictureHomem";
            this.pictureHomem.Size = new System.Drawing.Size(135, 143);
            this.pictureHomem.TabIndex = 1;
            this.pictureHomem.TabStop = false;
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Location = new System.Drawing.Point(219, 110);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(175, 15);
            this.lblNomeVendedor.TabIndex = 2;
            this.lblNomeVendedor.Text = "IDENTIFICAÇÃO DO VENDEDOR";
            // 
            // lblPecaVendida
            // 
            this.lblPecaVendida.AutoSize = true;
            this.lblPecaVendida.Location = new System.Drawing.Point(257, 177);
            this.lblPecaVendida.Name = "lblPecaVendida";
            this.lblPecaVendida.Size = new System.Drawing.Size(88, 15);
            this.lblPecaVendida.TabIndex = 3;
            this.lblPecaVendida.Text = "PEÇA VENDIDA";
            // 
            // txtIdentifiacacaoVendedor
            // 
            this.txtIdentifiacacaoVendedor.Location = new System.Drawing.Point(243, 128);
            this.txtIdentifiacacaoVendedor.Name = "txtIdentifiacacaoVendedor";
            this.txtIdentifiacacaoVendedor.Size = new System.Drawing.Size(125, 23);
            this.txtIdentifiacacaoVendedor.TabIndex = 4;
            // 
            // txtPeçaVendida
            // 
            this.txtPeçaVendida.Location = new System.Drawing.Point(243, 195);
            this.txtPeçaVendida.Name = "txtPeçaVendida";
            this.txtPeçaVendida.Size = new System.Drawing.Size(125, 23);
            this.txtPeçaVendida.TabIndex = 5;
            // 
            // lblCodigoPeça
            // 
            this.lblCodigoPeça.AutoSize = true;
            this.lblCodigoPeça.Location = new System.Drawing.Point(257, 243);
            this.lblCodigoPeça.Name = "lblCodigoPeça";
            this.lblCodigoPeça.Size = new System.Drawing.Size(103, 15);
            this.lblCodigoPeça.TabIndex = 6;
            this.lblCodigoPeça.Text = "CODIGO DA PEÇA";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(243, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 23);
            this.textBox3.TabIndex = 7;
            // 
            // lblQuantidadePeça
            // 
            this.lblQuantidadePeça.AutoSize = true;
            this.lblQuantidadePeça.Location = new System.Drawing.Point(245, 305);
            this.lblQuantidadePeça.Name = "lblQuantidadePeça";
            this.lblQuantidadePeça.Size = new System.Drawing.Size(115, 15);
            this.lblQuantidadePeça.TabIndex = 8;
            this.lblQuantidadePeça.Text = "UNIDADES VENDIDA";
            // 
            // lblPrecoPeça
            // 
            this.lblPrecoPeça.AutoSize = true;
            this.lblPrecoPeça.Location = new System.Drawing.Point(282, 358);
            this.lblPrecoPeça.Name = "lblPrecoPeça";
            this.lblPrecoPeça.Size = new System.Drawing.Size(37, 15);
            this.lblPrecoPeça.TabIndex = 9;
            this.lblPrecoPeça.Text = "Preço";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(340, 421);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(111, 23);
            this.btnVender.TabIndex = 10;
            this.btnVender.Text = "EFETUAR VENDA";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtUnidadeVendida
            // 
            this.txtUnidadeVendida.Location = new System.Drawing.Point(245, 323);
            this.txtUnidadeVendida.Name = "txtUnidadeVendida";
            this.txtUnidadeVendida.Size = new System.Drawing.Size(123, 23);
            this.txtUnidadeVendida.TabIndex = 11;
            // 
            // txtPreço
            // 
            this.txtPreço.Location = new System.Drawing.Point(243, 380);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(125, 23);
            this.txtPreço.TabIndex = 12;
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 500);
            this.Controls.Add(this.txtPreço);
            this.Controls.Add(this.txtUnidadeVendida);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblPrecoPeça);
            this.Controls.Add(this.lblQuantidadePeça);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblCodigoPeça);
            this.Controls.Add(this.txtPeçaVendida);
            this.Controls.Add(this.txtIdentifiacacaoVendedor);
            this.Controls.Add(this.lblPecaVendida);
            this.Controls.Add(this.lblNomeVendedor);
            this.Controls.Add(this.pictureHomem);
            this.Controls.Add(this.lblBoasVindas);
            this.Name = "frmComissao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureHomem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private Label lblBoasVindas;
        private PictureBox pictureHomem;
        private Label lblNomeVendedor;
        private Label lblPecaVendida;
        private TextBox txtIdentifiacacaoVendedor;
        private TextBox txtPeçaVendida;
        private Label lblCodigoPeça;
        private TextBox textBox3;
        private Label lblQuantidadePeça;
        private Label lblPrecoPeça;
        private Button btnVender;
        private TextBox txtUnidadeVendida;
        private TextBox txtPreço;
    }
}