using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
            txtDolarDia.Text = "5,25";

            btnConverter.Enabled = false;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var DolarDia = decimal.Parse(txtDolarDia.Text);
            var DesejaConverter = decimal.Parse((string)txtValorConversao.Text);

            var resultado = DolarDia * DesejaConverter;

            string mensagem = resultado.ToString();
            string titulo = "Valor Convertido";
            MessageBox.Show(mensagem, titulo);
            
            
        
        }

        private void frmCotacaoDolar_Load(object sender, EventArgs e)
        {


        }

        private void txtValorConversao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorConversao.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("digite um valor númerico");
                txtValorConversao.Focus();

                throw;
            }
        }
    }
}
