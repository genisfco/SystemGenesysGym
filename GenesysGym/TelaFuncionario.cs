using MySql.Data.MySqlClient;
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

        private void LimparForm()
        {
            txtCodFuncionario.Text = string.Empty;
            txtCargoFuncionario.Text = string.Empty;
            txtNomeFuncionario.Text = string.Empty;
            maskCPFFuncionario.Text = string.Empty;
            maskRGFuncionario.Text = string.Empty;
            comboxDiaFuncionario.Text = string.Empty;
            comboxMesFuncionario.Text = string.Empty;
            comboxAnoFuncionario.Text = string.Empty;
            rdbtnMascFuncionario.Checked = false;
            rdbtnFemFuncionario.Checked = false;
            txtLogradouroFuncionario.Text = string.Empty;
            txtNumLogradouroFuncionario.Text = string.Empty;
            maskCEPFuncionario.Text = string.Empty;
            txtBairroFuncionario.Text = string.Empty;
            txtCidadeFuncionario.Text = string.Empty;
            txtEstadoFuncionario.Text = string.Empty;
            maskTelefoneFuncionario.Text = string.Empty;
            txtEmailFuncionario.Text = string.Empty;
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
                // TRATAMENTO DOS DADOS PARA O INSERT
                string cpf = maskCPFFuncionario.Text;
                string rg = maskRGFuncionario.Text;
                cpf = cpf.Replace(",", "").Replace("-", "");
                rg = rg.Replace(",", "").Replace("-", "");

                string sexo;
                if (rdbtnMascFuncionario.Checked == true)
                {
                    sexo = "M";
                }
                else
                {
                    sexo = "F";
                }

                string year = dttimepickDataAdmissao.Value.Year.ToString();
                string month = dttimepickDataAdmissao.Value.Month.ToString();
                string day = dttimepickDataAdmissao.Value.Day.ToString();
                string data_admissao = year + "-" + month + "-" + day;

                string data_nasc = comboxAnoFuncionario.Text + "-" + comboxMesFuncionario.Text + "-" + comboxDiaFuncionario.Text;


                // INSERT DOS DADOS PARA A TABELA CLIENTE
                string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

                MySqlConnection msConnection = new MySqlConnection();
                msConnection.ConnectionString = connection_mysql;
                msConnection.Open();
                MySqlCommand msCommand = new MySqlCommand();
                msCommand.CommandText = "insert into funcionario values ("
                          + txtCodFuncionario.Text +
                    ", '" + txtNomeFuncionario.Text +
                    "', '" + cpf +
                    "', '" + rg +
                    "', '" + sexo +
                    "', '" + data_admissao +
                    "', '" + data_nasc +
                    "', '" + txtLogradouroFuncionario.Text +
                    "', '" + txtNumLogradouroFuncionario.Text +
                    "', '" + txtBairroFuncionario.Text +
                    "', '" + txtCidadeFuncionario.Text +
                    "', '" + txtEstadoFuncionario.Text +
                    "', '" + maskCEPFuncionario.Text +
                    "', '" + txtCargoFuncionario.Text +
                    "');";

                msCommand.Connection = msConnection;
                msCommand.ExecuteNonQuery();
                msConnection.Close();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                LimparForm();
            }

        }

        private void btnLimparDadosFuncionario_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
