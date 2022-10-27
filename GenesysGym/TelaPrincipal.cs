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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        /*
        private bool ValidarForm()
        {
            bool FormValido;

            if (txtCodFuncionario.Text == "" || maskboxCPFFuncionario.Text == "" || maskboxRGFuncionario.Text == "" || txtNomeFuncionario.Text == "" || txtDtAdmFuncionario.Text == "" || txtCargoFuncionario.Text == "" || txtTelefoneFuncionario.Text == "" || txtEmailFuncionario.Text == "")
                FormValido = false;
            else
                FormValido = true;

            return FormValido;
        }
        */


        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            pnlCadastrarCliente.Visible = true;
            pnlPesquisarCliente.Visible = false;
        }        

        private void stripCadastrarCliente_Click(object sender, EventArgs e)
        {
            pnlCadastrarCliente.Visible = true;
            pnlPesquisarCliente.Visible = false;
        }

        private void stripPesquisarCliente_Click(object sender, EventArgs e)
        {
            pnlPesquisarCliente.Visible = true;
            pnlCadastrarCliente.Visible=false;
        }

        private void stripCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            TelaFuncionario abrirTelaFuncionario = new TelaFuncionario();
            abrirTelaFuncionario.Show();                    
                       
        }

        private void stripRegistrarAlterarTreino_Click(object sender, EventArgs e)
        {
            TelaTreinos abrirTelaTreinos = new TelaTreinos();
            abrirTelaTreinos.Show();
        }

        private void btnSairCadastrarCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSairPesquisarCliente_Click(object sender, EventArgs e)
        {
            pnlPesquisarCliente.Visible = false;
            pnlCadastrarCliente.Visible = true;
        }



        private void maskCEP_Leave(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(maskCEP.Text.Trim());
                    txtEstado.Text = endereco.uf;
                    txtCidade.Text = endereco.cidade;
                    txtBairro.Text = endereco.bairro;
                    txtLogradouro.Text = endereco.end;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
