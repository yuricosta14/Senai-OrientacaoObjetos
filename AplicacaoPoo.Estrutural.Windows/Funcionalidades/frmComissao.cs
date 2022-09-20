using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            var VendasUnidade = float.Parse(txtUnidadeVendida.Text);
            var Valor = float.Parse(txtPreço.Text);
            var resultado = VendasUnidade * Valor;

            

            

        }
    }
}
