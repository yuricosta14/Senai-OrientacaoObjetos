using AplicacaoPoo.Dominio.helpers;
using AplicacaoPoo.Dominio.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmConversorMoeda : Form
    {
        private bool CotacaoEhValido;
        private bool ValorEmDolarEhValido;
        public frmConversorMoeda()
        {
            InitializeComponent();
            btnConverterEmReal.Enabled = true;

            lblSegundoValor.Text = $"5,12 {MoedaHelper.Dolar}";
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Real} igual a";


        }

        private void btnConverterEmReal_Click(object sender, EventArgs e)
        {
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            var moeda = new ConverterMoedaService();
            
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

            lblSegundoValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar}";
            lblPrimeiroValor.Text = $"{resultado} {MoedaHelper.Real} igual a";


        }


        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorEmDolar.Text == "") 
                {
                    btnConverterEmReal.Enabled = false;
                    return;
                };

                var resultado = decimal.Parse(txtValorEmDolar.Text);
                btnConverterEmReal.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtValorEmDolar.Focus();
                btnConverterEmReal.Enabled = false;
            }

            {
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var moeda = new ConverterMoedaService();

                var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

                lblSegundoValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar}";
                lblPrimeiroValor.Text = $"{resultado} {MoedaHelper.Real} igual a";
            }
        }


    }
}