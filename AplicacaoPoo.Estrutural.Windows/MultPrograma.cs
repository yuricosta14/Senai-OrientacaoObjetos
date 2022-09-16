using AplicacaoPoo.Estrutural.Windows.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class MultPrograma : Form
    {
        public MultPrograma()
        {
            InitializeComponent();
        }

        private void btnCotacaoDolar_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.Show();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.Show();
        }
    }
}
