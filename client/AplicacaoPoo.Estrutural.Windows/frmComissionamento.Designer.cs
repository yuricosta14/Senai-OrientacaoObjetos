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
            this.txtRegistroPeça = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.lblNomeRegistro = new System.Windows.Forms.Label();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cboNomePecaVendida = new System.Windows.Forms.ComboBox();
            this.lblRegistroFuncionario = new System.Windows.Forms.Label();
            this.cboRegistroFuncionario = new System.Windows.Forms.ComboBox();
            this.lblNomePecaVendida = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxHomem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxHomem
            // 
            this.pictureboxHomem.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxHomem.Image")));
            this.pictureboxHomem.Location = new System.Drawing.Point(12, 74);
            this.pictureboxHomem.Name = "pictureboxHomem";
            this.pictureboxHomem.Size = new System.Drawing.Size(125, 126);
            this.pictureboxHomem.TabIndex = 0;
            this.pictureboxHomem.TabStop = false;
            this.pictureboxHomem.Tag = "1";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(218, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(197, 15);
            this.lblBemVindo.TabIndex = 3;
            this.lblBemVindo.Text = "BEM VINDO AO SISTEMA DE VENDA";
            // 
            // txtRegistroPeça
            // 
            this.txtRegistroPeça.Location = new System.Drawing.Point(397, 146);
            this.txtRegistroPeça.Name = "txtRegistroPeça";
            this.txtRegistroPeça.PlaceholderText = "REGISTRO DA PEÇA VENDIDA";
            this.txtRegistroPeça.Size = new System.Drawing.Size(172, 23);
            this.txtRegistroPeça.TabIndex = 3;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(397, 207);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.PlaceholderText = "PREÇO UNITARIO";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(172, 23);
            this.txtPrecoUnitario.TabIndex = 5;
            this.txtPrecoUnitario.TextChanged += new System.EventHandler(this.txtPrecoUnitario_TextChanged);
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(396, 272);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.PlaceholderText = "QUANTIDADE VENDIDA";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(173, 23);
            this.txtQuantidadeVendida.TabIndex = 6;
            this.txtQuantidadeVendida.TextChanged += new System.EventHandler(this.txtQuantidadeVendida_TextChanged);
            // 
            // lblNomeRegistro
            // 
            this.lblNomeRegistro.AutoSize = true;
            this.lblNomeRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeRegistro.Location = new System.Drawing.Point(176, 335);
            this.lblNomeRegistro.Name = "lblNomeRegistro";
            this.lblNomeRegistro.Size = new System.Drawing.Size(13, 15);
            this.lblNomeRegistro.TabIndex = 8;
            this.lblNomeRegistro.Text = "0";
            this.lblNomeRegistro.Visible = false;
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Location = new System.Drawing.Point(451, 331);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(118, 23);
            this.btnConcluirVenda.TabIndex = 9;
            this.btnConcluirVenda.Text = "CONCLUIR VENDA";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(494, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cboNomePecaVendida
            // 
            this.cboNomePecaVendida.FormattingEnabled = true;
            this.cboNomePecaVendida.Location = new System.Drawing.Point(176, 272);
            this.cboNomePecaVendida.Name = "cboNomePecaVendida";
            this.cboNomePecaVendida.Size = new System.Drawing.Size(172, 23);
            this.cboNomePecaVendida.TabIndex = 11;
            // 
            // lblRegistroFuncionario
            // 
            this.lblRegistroFuncionario.AutoSize = true;
            this.lblRegistroFuncionario.Location = new System.Drawing.Point(176, 117);
            this.lblRegistroFuncionario.Name = "lblRegistroFuncionario";
            this.lblRegistroFuncionario.Size = new System.Drawing.Size(161, 15);
            this.lblRegistroFuncionario.TabIndex = 12;
            this.lblRegistroFuncionario.Text = "REGISTRO DO FUNCIONARIO";
            // 
            // cboRegistroFuncionario
            // 
            this.cboRegistroFuncionario.FormattingEnabled = true;
            this.cboRegistroFuncionario.Location = new System.Drawing.Point(176, 146);
            this.cboRegistroFuncionario.Name = "cboRegistroFuncionario";
            this.cboRegistroFuncionario.Size = new System.Drawing.Size(172, 23);
            this.cboRegistroFuncionario.TabIndex = 13;
            this.cboRegistroFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboRegistroFuncionario_SelectedIndexChanged);
            // 
            // lblNomePecaVendida
            // 
            this.lblNomePecaVendida.AutoSize = true;
            this.lblNomePecaVendida.Location = new System.Drawing.Point(176, 243);
            this.lblNomePecaVendida.Name = "lblNomePecaVendida";
            this.lblNomePecaVendida.Size = new System.Drawing.Size(145, 15);
            this.lblNomePecaVendida.TabIndex = 14;
            this.lblNomePecaVendida.Text = "NOME DA PEÇA VENDIDA";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(11, 226);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(38, 15);
            this.lblNomeFuncionario.TabIndex = 15;
            this.lblNomeFuncionario.Text = "label1";
            this.lblNomeFuncionario.Visible = false;
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(581, 403);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.lblNomePecaVendida);
            this.Controls.Add(this.cboRegistroFuncionario);
            this.Controls.Add(this.lblRegistroFuncionario);
            this.Controls.Add(this.cboNomePecaVendida);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.lblNomeRegistro);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtRegistroPeça);
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
        private TextBox txtRegistroPeça;
        private TextBox txtPrecoUnitario;
        private TextBox txtQuantidadeVendida;
        private ComboBox cboNomePecaVendida;
        private Label lblNomeRegistro;
        private Button btnConcluirVenda;
        private Button btnLimpar;
        private Label lblRegistroFuncionario;
        private ComboBox cboRegistroFuncionario;
        private Label lblNomePecaVendida;
        private Label lblNomeFuncionario;
    }
}