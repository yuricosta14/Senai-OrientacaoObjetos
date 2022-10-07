using AplicacaoPoo.Dominio.helpers;
using System;
using System.Collections;
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
    public partial class frmComissionamento : Form
    {
        public frmComissionamento()
        {
            InitializeComponent();

            lblBemVindo.Select();

            var produtoservice = new ProdutoService();
            cboNomePecaVendida.DataSource = produtoservice.ListagemProdutosFake();
            cboNomePecaVendida.DisplayMember = "Nome";

            var funcionaservice = new FuncionarioService();
            cboRegistroFuncionario.DataSource = funcionaservice.ListagemFuncionarioFake();
            cboRegistroFuncionario.DisplayMember = "Id";

           




        }



        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecoUnitario.Text == "") return;
            {
                try
                {
                    var recebeNumero2 = decimal.Parse(txtPrecoUnitario.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Valor invalido");
                }
            }
        }

        private void txtQuantidadeVendida_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidadeVendida.Text == "") return;
            {
                try
                {
                    var recebeNumero2 = decimal.Parse(txtQuantidadeVendida.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Valor invalido");
                }
            }
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {

            var resultado = decimal.Parse(txtQuantidadeVendida.Text) * decimal.Parse(txtPrecoUnitario.Text);
            var comissao = resultado * 5 / 100;

            lblNomeRegistro.Text = resultado.ToString();
            lblNomeRegistro.Text = $" Sua venda ficou no total de R${resultado}\n e sua comissão foi de R${comissao} \n";

            btnLimpar.Visible = true;
            lblNomeRegistro.Visible = true;

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           
            txtRegistroPeça.Text = ("");
            txtPrecoUnitario.Text = ("");
            txtQuantidadeVendida.Text = ("");
            lblNomeRegistro.Text = ("");

            btnLimpar.Visible = false;

            
        }

        private void cboRegistroFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var funcionarioService = new ProdutoService();

            


        }
    }
}
    
