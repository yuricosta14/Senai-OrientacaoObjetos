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
            this.txtRespostaRegistroVendedor = new System.Windows.Forms.TextBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxHomem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureboxHomem
            // 
            this.pictureboxHomem.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxHomem.Image")));
            this.pictureboxHomem.Location = new System.Drawing.Point(12, 73);
            this.pictureboxHomem.Name = "pictureboxHomem";
            this.pictureboxHomem.Size = new System.Drawing.Size(132, 126);
            this.pictureboxHomem.TabIndex = 0;
            this.pictureboxHomem.TabStop = false;
            this.pictureboxHomem.Tag = "1";
            // 
            // txtRespostaRegistroVendedor
            // 
            this.txtRespostaRegistroVendedor.Location = new System.Drawing.Point(6, 22);
            this.txtRespostaRegistroVendedor.Name = "txtRespostaRegistroVendedor";
            this.txtRespostaRegistroVendedor.PlaceholderText = "REGISTRO DO VENDEDOR";
            this.txtRespostaRegistroVendedor.Size = new System.Drawing.Size(172, 23);
            this.txtRespostaRegistroVendedor.TabIndex = 2;
            this.txtRespostaRegistroVendedor.Tag = "";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "NOME DA PEÇA VENDIDA";
            this.textBox1.Size = new System.Drawing.Size(172, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "CODIGO DA PEÇA";
            this.textBox2.Size = new System.Drawing.Size(172, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "PREÇO UNITARIO";
            this.textBox3.Size = new System.Drawing.Size(172, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 327);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "QUANTIDADE VENDIDA";
            this.textBox4.Size = new System.Drawing.Size(173, 23);
            this.textBox4.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRespostaRegistroVendedor);
            this.groupBox1.Location = new System.Drawing.Point(150, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 55);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DO VENDEDOR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(339, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pictureboxHomem);
            this.Name = "frmComissionamento";
            this.Text = "frmComissionamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxHomem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureboxHomem;
        private TextBox txtRespostaRegistroVendedor;
        private Label lblBemVindo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
    }
}