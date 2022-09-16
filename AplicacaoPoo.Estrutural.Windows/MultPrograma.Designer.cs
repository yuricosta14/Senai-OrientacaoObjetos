namespace AplicacaoPoo.Estrutural.Windows
{
    partial class MultPrograma
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
            this.btnCotacaoDolar = new System.Windows.Forms.Button();
            this.btnComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCotacaoDolar
            // 
            this.btnCotacaoDolar.Location = new System.Drawing.Point(53, 67);
            this.btnCotacaoDolar.Name = "btnCotacaoDolar";
            this.btnCotacaoDolar.Size = new System.Drawing.Size(81, 68);
            this.btnCotacaoDolar.TabIndex = 0;
            this.btnCotacaoDolar.Text = "1";
            this.btnCotacaoDolar.UseVisualStyleBackColor = true;
            this.btnCotacaoDolar.Click += new System.EventHandler(this.btnCotacaoDolar_Click);
            // 
            // btnComissao
            // 
            this.btnComissao.Location = new System.Drawing.Point(275, 67);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(75, 68);
            this.btnComissao.TabIndex = 1;
            this.btnComissao.Text = "2";
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // MultPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 184);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btnCotacaoDolar);
            this.Name = "MultPrograma";
            this.Text = "MultPrograma";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCotacaoDolar;
        private Button btnComissao;
    }
}