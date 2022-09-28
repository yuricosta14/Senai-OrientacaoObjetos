using AplicacaoPoo.Dominio.helpers;
using AplicacaoPoo.Dominio.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            txtValorEmDolar.Text = "1";

            var list = new List<string>();

            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libras);
            cboEscolherMoeda.DataSource = list;
            cboEscolherMoeda.SelectedIndex = 0;


        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
           
            if (txtValorEmDolar.Text == "")
            {
                cboEscolherMoeda.Enabled = false;
                return;

            }
            cboEscolherMoeda.Enabled = true;

            EfeturarConversaoMoeda();

        }
        private void cboEscolherMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfeturarConversaoMoeda();
        }

        private void EfeturarConversaoMoeda()
        {
            try
            {
                #region logica da conversão de acordo com o valor selecionado
                //atalho para comentar o código inteiro cntrl+k+c
                //atalho para descomentar todo o codigo cntrl+k+u
                //#region deixa o codigo mais organizado
                if (txtValorEmDolar.Text == "") return;


                var moedaService = new ConverterMoedaService();
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

                switch (cboEscolherMoeda.SelectedValue)
                {
                    case MoedaHelper.Dolar:
                        {
                            var valorConvertido = moedaService.ConverterDolarEmReal(decimal.Parse(txtValorEmDolar.Text));
                            lblSegundoValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar}";
                            lblPrimeiroValor.Text = $"{valorConvertido} {MoedaHelper.Real} igual a";

                            break;
                        }

                    case MoedaHelper.Euro:
                        {
                            var valorConvertido = moedaService.ConverterEuroEmReal(decimal.Parse(txtValorEmDolar.Text));
                            lblSegundoValor.Text = $"{valorEmDolar} {MoedaHelper.Euro}";
                            lblPrimeiroValor.Text = $"{valorConvertido} {MoedaHelper.Real} igual a";

                            break;
                        }

                    case MoedaHelper.Libras:
                        {
                            var valorConvertido = moedaService.ConverterLibrasEmReal(decimal.Parse(txtValorEmDolar.Text));
                            lblSegundoValor.Text = $"{valorEmDolar} {MoedaHelper.Libras}";
                            lblPrimeiroValor.Text = $"{valorConvertido} {MoedaHelper.Real} igual a";
                            break;

                        }
                    default:
                        break;

                        #endregion
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar o valor númerico");
                    throw;
            }



            }
            

                
            }
            
            
    }

