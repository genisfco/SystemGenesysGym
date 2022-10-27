using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenesysGym
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        /*private bool ValidarForm()
        {
            bool FormValido;

            if (txtCodFuncionario.Text == "" || txtNomeFuncionario.Text == "" || txtCargoFuncionario.Text == "" || txtTelefoneFuncionario.Text == "" || txtEmailFuncionario.Text == "")
                FormValido = false;
            else
                FormValido = true;

            return FormValido;
        }
        */

        private void TelaFuncionario_Load(object sender, EventArgs e)
        {   
            pnlCadastrarFuncionario.Visible = false;
            pnlConsultarFuncionario.Visible = false;

        }

        private void menuCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            pnlCadastrarFuncionario.Visible = true;
            pnlConsultarFuncionario.Visible = false;
        }

        private void menuConsultarFuncionario_Click(object sender, EventArgs e)
        {
            pnlConsultarFuncionario.Visible = true;
            pnlCadastrarFuncionario.Visible = false;
        }

        private void btnSairCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSairPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskCEPFuncionario_Leave(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(maskCEPFuncionario.Text.Trim());
                    txtEstadoFuncionario.Text = endereco.uf;
                    txtCidadeFuncionario.Text = endereco.cidade;
                    txtBairroFuncionario.Text = endereco.bairro;
                    txtLogradouroFuncionario.Text = endereco.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
