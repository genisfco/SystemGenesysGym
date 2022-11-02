using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GenesysGym
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
                
        private bool ValidarForm()
        {
            bool FormValido;

            if (txtCodCliente.Text == "" 
                || txtNomeCliente.Text == "" 
                || comboxDia.Text == "" 
                || comboxMes.Text == "" 
                || comboxAno.Text == "")
                FormValido = false;
            else if (rdbtnMascCliente.Checked == false && rdbtnFemCliente.Checked == false)
                FormValido = false;
            else if (txtLogradouro.Text == "" || txtNumLogradouro.Text == "" || maskCEP.Text.Length != 9 
                || txtBairro.Text == "" || txtCidade.Text == "" || txtEstado.Text == "")
                FormValido = false;
            else if (maskTelefone.Text.Length != 13 || txtEmail.Text == "")
                FormValido = false;
            else
                FormValido = true;

            return FormValido;
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


        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            // Exigir preenchimento completo dos campos obrigatórios
            if (ValidarForm() == false)
            {
                MessageBox.Show("ATENÇÃO: Todos os campos precisam ser preenchidos!");
            }
            else if (maskCPFCliente.Text.Length != 14)
            {
                MessageBox.Show("CPF incompleto, digite todos os digítos!");
            }

            // Aplicando Classe para validação de RG e CPF
            else if (ClassValidacao.validarCpf(maskCPFCliente.Text) == false)
            {
                MessageBox.Show("CPF inválido!");
            }
            else if (ClassValidacao.validarRg(maskRGCliente.Text) == false)
            {
                MessageBox.Show("RG inválido!");
            }

            // Dados válidos -> Processo de Insert 
            else if (ValidarForm() && ClassValidacao.validarCpf(maskCPFCliente.Text) && ClassValidacao.validarRg(maskRGCliente.Text))
            {                
                string cpf = maskCPFCliente.Text;
                string rg = maskRGCliente.Text;
                cpf = cpf.Replace(",", "").Replace("-", "");
                rg = rg.Replace(",", "").Replace("-", "");

                bool sexo;
                if (rdbtnMascCliente.Checked == true)
                {
                    sexo = true;
                }
                else
                {
                    sexo = false;
                }

                string year = dttimepickDataMatricula.Value.Year.ToString();
                string month = dttimepickDataMatricula.Value.Month.ToString();
                string day = dttimepickDataMatricula.Value.Day.ToString();
                string data_matricula = year + "-" + month + "-" + day;

                string data_nasc = comboxAno.Text + "-" + comboxMes.Text + "-" + comboxDia.Text;


                // FAZER O INSERT DOS DADOS PARA A TABELA CLIENTE

                string connection_mysql = @"Server=localhost;Database=Academia;Uid=root;Pwd='1234'";

                MySqlConnection msConnection = new MySqlConnection();
                msConnection.ConnectionString = connection_mysql;
                msConnection.Open();
                MySqlCommand msCommand = new MySqlCommand();
                msCommand.CommandText = "insert into cliente values (" 
                           + txtCodCliente.Text +
                    ", '" + txtNomeCliente.Text +
                    "', '" + cpf +
                    "', '" + rg +
                    "', '" + sexo +
                    "', '" + data_matricula +
                    "', '" + data_nasc +
                    "', '" + txtLogradouro.Text +
                    "', '" + txtNumLogradouro.Text +
                    "', '" + txtBairro.Text +
                    "', '" + txtCidade.Text +
                    "', '" + txtEstado.Text +
                    "', '" + maskCEP.Text +
                    "');";
                
                msCommand.Connection = msConnection;
                msCommand.ExecuteNonQuery();
                msConnection.Close();

                MessageBox.Show("Cliente cadastrado com sucesso!"); 
            }
        }
    }
}
