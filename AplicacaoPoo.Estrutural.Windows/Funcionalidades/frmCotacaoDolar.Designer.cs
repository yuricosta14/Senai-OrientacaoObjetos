namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmCotacaoDolar
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConversao = new System.Windows.Forms.Label();
            this.txtValorConversao = new System.Windows.Forms.TextBox();
            this.lblDolarDia = new System.Windows.Forms.Label();
            this.txtDolarDia = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(68, 18);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(356, 15);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "BEM VINDO AO NOSSO APLICATIVO DE CONVERSÃO DE VALORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Location = new System.Drawing.Point(164, 143);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(168, 15);
            this.lblConversao.TabIndex = 2;
            this.lblConversao.Text = "QUANTO DESEJA CONVERTER?";
            // 
            // txtValorConversao
            // 
            this.txtValorConversao.Location = new System.Drawing.Point(182, 171);
            this.txtValorConversao.Name = "txtValorConversao";
            this.txtValorConversao.Size = new System.Drawing.Size(117, 23);
            this.txtValorConversao.TabIndex = 3;
            // 
            // lblDolarDia
            // 
            this.lblDolarDia.AutoSize = true;
            this.lblDolarDia.Location = new System.Drawing.Point(198, 73);
            this.lblDolarDia.Name = "lblDolarDia";
            this.lblDolarDia.Size = new System.Drawing.Size(87, 15);
            this.lblDolarDia.TabIndex = 4;
            this.lblDolarDia.Text = "DOLAR DO DIA";
            // 
            // txtDolarDia
            // 
            this.txtDolarDia.Enabled = false;
            this.txtDolarDia.Location = new System.Drawing.Point(182, 91);
            this.txtDolarDia.Name = "txtDolarDia";
            this.txtDolarDia.Size = new System.Drawing.Size(117, 23);
            this.txtDolarDia.TabIndex = 5;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(318, 171);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(92, 23);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 306);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtDolarDia);
            this.Controls.Add(this.lblDolarDia);
            this.Controls.Add(this.txtValorConversao);
            this.Controls.Add(this.lblConversao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "frmCotacaoDolar";
            this.Text = "Cotação dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBemVindo;
        private Label label2;
        private Label lblConversao;
        private TextBox txtValorConversao;
        private Label lblDolarDia;
        private TextBox txtDolarDia;
        private Button btnConverter;
    }
}