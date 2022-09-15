using AplicacaoPOO.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Windows
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            var cliente = new Cliente();
            cliente.Nome = "Yuri Costa";
            txtNome.Text = cliente.Nome;
            txtCpf.Text = "127.420.310-09";
            lblSaldoInicialValor.Text = "1000";    
            

        
    }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var credito = new Credito();
            
        }
    }
}
