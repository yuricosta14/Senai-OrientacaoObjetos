namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissionamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComissionamento));
            this.pictureboxHomem = new System.Windows.Forms.PictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.txtNomePeça = new System.Windows.Forms.TextBox();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.txtRespostaRegistroVendedor = new System.Windows.Forms.TextBox();
            this.lblNomeRegistro = new System.Windows.Forms.Label();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxHomem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxHomem
            // 
            this.pictureboxHomem.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxHomem.Image")));
            this.pictureboxHomem.Location = new System.Drawing.Point(12, 67);
            this.pictureboxHomem.Name = "pictureboxHomem";
            this.pictureboxHomem.Size = new System.Drawing.Size(132, 126);
            this.pictureboxHomem.TabIndex = 0;
            this.pictureboxHomem.TabStop = false;
            this.pictureboxHomem.Tag = "1";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(78, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(197, 15);
            this.lblBemVindo.TabIndex = 3;
            this.lblBemVindo.Text = "BEM VINDO AO SISTEMA DE VENDA";
            // 
            // txtNomePeça
            // 
            this.txtNomePeça.Location = new System.Drawing.Point(151, 148);
            this.txtNomePeça.Name = "txtNomePeça";
            this.txtNomePeça.PlaceholderText = "NOME DA PEÇA VENDIDA";
            this.txtNomePeça.Size = new System.Drawing.Size(172, 23);
            this.txtNomePeça.TabIndex = 3;
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(151, 201);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.PlaceholderText = "CODIGO DA PEÇA";
            this.txtCodigoPeca.Size = new System.Drawing.Size(172, 23);
            this.txtCodigoPeca.TabIndex = 4;
            this.txtCodigoPeca.TextChanged += new System.EventHandler(this.txtCodigoPeca_TextChanged);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(150, 256);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.PlaceholderText = "PREÇO UNITARIO";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(172, 23);
            this.txtPrecoUnitario.TabIndex = 5;
            this.txtPrecoUnitario.TextChanged += new System.EventHandler(this.txtPrecoUnitario_TextChanged);
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(150, 303);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.PlaceholderText = "QUANTIDADE VENDIDA";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(173, 23);
            this.txtQuantidadeVendida.TabIndex = 6;
            this.txtQuantidadeVendida.TextChanged += new System.EventHandler(this.txtQuantidadeVendida_TextChanged);
            // 
            // txtRespostaRegistroVendedor
            // 
            this.txtRespostaRegistroVendedor.Location = new System.Drawing.Point(150, 100);
            this.txtRespostaRegistroVendedor.Name = "txtRespostaRegistroVendedor";
            this.txtRespostaRegistroVendedor.PlaceholderText = "REGISTRO DO VENDEDOR";
            this.txtRespostaRegistroVendedor.Size = new System.Drawing.Size(172, 23);
            this.txtRespostaRegistroVendedor.TabIndex = 2;
            this.txtRespostaRegistroVendedor.Tag = "";
            this.txtRespostaRegistroVendedor.TextChanged += new System.EventHandler(this.txtRespostaRegistroVendedor_TextChanged);
            // 
            // lblNomeRegistro
            // 
            this.lblNomeRegistro.AutoSize = true;
            this.lblNomeRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeRegistro.Location = new System.Drawing.Point(22, 361);
            this.lblNomeRegistro.Name = "lblNomeRegistro";
            this.lblNomeRegistro.Size = new System.Drawing.Size(13, 15);
            this.lblNomeRegistro.TabIndex = 8;
            this.lblNomeRegistro.Text = "0";
            this.lblNomeRegistro.Visible = false;
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Location = new System.Drawing.Point(205, 341);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(118, 23);
            this.btnConcluirVenda.TabIndex = 9;
            this.btnConcluirVenda.Text = "CONCLUIR VENDA";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(247, 370);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(339, 421);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.lblNomeRegistro);
            this.Controls.Add(this.txtRespostaRegistroVendedor);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.txtNomePeça);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pictureboxHomem);
            this.Name = "frmComissionamento";
            this.Text = "frmComissionamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxHomem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureboxHomem;
        private Label lblBemVindo;
        private TextBox txtNomePeça;
        private TextBox txtCodigoPeca;
        private TextBox txtPrecoUnitario;
        private TextBox txtQuantidadeVendida;
        private TextBox txtRespostaRegistroVendedor;
        private ComboBox comboBox1;
        private Label lblNomeRegistro;
        private Button btnConcluirVenda;
        private Button btnLimpar;
    }
}