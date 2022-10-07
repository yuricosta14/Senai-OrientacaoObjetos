namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmSendMail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSuporteContato = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(436, 23);
            this.txtEmail.TabIndex = 0;
            // 
            // lblSuporteContato
            // 
            this.lblSuporteContato.AutoSize = true;
            this.lblSuporteContato.Location = new System.Drawing.Point(188, 20);
            this.lblSuporteContato.Name = "lblSuporteContato";
            this.lblSuporteContato.Size = new System.Drawing.Size(119, 15);
            this.lblSuporteContato.TabIndex = 2;
            this.lblSuporteContato.Text = "SUPORTE E CONTATO";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(15, 199);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(436, 23);
            this.txtAssunto.TabIndex = 3;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(15, 100);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(436, 23);
            this.txtNomeCompleto.TabIndex = 4;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(15, 82);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(94, 15);
            this.lblNomeCompleto.TabIndex = 5;
            this.lblNomeCompleto.Text = "Nome completo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(15, 181);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(50, 15);
            this.lblAssunto.TabIndex = 7;
            this.lblAssunto.Text = "Assunto";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 260);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(439, 143);
            this.txtMensagem.TabIndex = 8;
            this.txtMensagem.Text = "";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 242);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(66, 15);
            this.lblMensagem.TabIndex = 9;
            this.lblMensagem.Text = "Mensagem";
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(34, 430);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(399, 28);
            this.btnEnviarMensagem.TabIndex = 10;
            this.btnEnviarMensagem.Text = "Enviar mensagem";
            this.btnEnviarMensagem.UseVisualStyleBackColor = false;
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(488, 476);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblSuporteContato);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmSendMail";
            this.Text = "frmSendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private Label lblSuporteContato;
        private TextBox txtAssunto;
        private TextBox txtNomeCompleto;
        private Label lblNomeCompleto;
        private Label lblEmail;
        private Label lblAssunto;
        private RichTextBox txtMensagem;
        private Label lblMensagem;
        private Button btnEnviarMensagem;
        private Label lblObrigatorio;
    }
}