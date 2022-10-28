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

        private bool ValidarForm()
        {
            bool FormValido;

            if (txtCodFuncionario.Text == "" 
                || txtCargoFuncionario.Text == "" 
                || txtNomeFuncionario.Text == "" 
                || comboxDiaFuncionario.Text == "" 
                || comboxMesFuncionario.Text == "" 
                || comboxAnoFuncionario.Text == "")
                FormValido = false;
            else if (rdbtnMascFuncionario.Checked == false && rdbtnFemFuncionario.Checked == false)
                FormValido = false;
            else if (txtLogradouroFuncionario.Text == "" || txtNumLogradouroFuncionario.Text == "" 
                || maskCEPFuncionario.Text.Length != 9 || txtBairroFuncionario.Text == "" 
                || txtCidadeFuncionario.Text == "" || txtEstadoFuncionario.Text == "")
                FormValido = false;
            else if (maskTelefoneFuncionario.Text.Length != 13 || txtEmailFuncionario.Text == "")
                FormValido = false;
            else
                FormValido = true;

            return FormValido;
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

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            // Exigir preenchimento completo dos campos obrigatórios
            if (ValidarForm() == false)
            {
                MessageBox.Show("ATENÇÃO: Todos os campos precisam ser preenchidos!");
            }
            else if (maskCPFFuncionario.Text.Length != 14)
            {
                MessageBox.Show("CPF incompleto, digite todos os digítos!");
            }

            // Aplicando Classe para validação de RG e CPF
            else if (ClassValidacao.validarCpf(maskCPFFuncionario.Text) == false)
            {
                MessageBox.Show("CPF inválido!");
            }
            else if (ClassValidacao.validarRg(maskRGFuncionario.Text) == false)
            {
                MessageBox.Show("RG inválido!");
            }

            // Dados válidos -> Processo de Insert 
            else if (ValidarForm() && ClassValidacao.validarCpf(maskCPFFuncionario.Text) && ClassValidacao.validarRg(maskRGFuncionario.Text))
            {
                string year = dttimepickDataAdmissao.Value.Year.ToString();
                string month = dttimepickDataAdmissao.Value.Month.ToString();
                string day = dttimepickDataAdmissao.Value.Day.ToString();
                string data_matricula = year + "-" + month + "-" + day;

                // FAZER O INSERT DOS DADOS PARA A TABELA CLIENTE

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }

        }
    }
}
