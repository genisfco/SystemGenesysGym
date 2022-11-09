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
            TelaLogin telaLogin = new TelaLogin(this);
            telaLogin.ShowDialog();      

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

        private void LimparForm()
        {
            txtCodCliente.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            maskCPFCliente.Text = string.Empty;
            maskRGCliente.Text = string.Empty;
            comboxDia.Text = string.Empty;
            comboxMes.Text = string.Empty;
            comboxAno.Text = string.Empty;
            rdbtnMascCliente.Checked = false;
            rdbtnFemCliente.Checked = false;
            txtLogradouro.Text = string.Empty;
            txtNumLogradouro.Text = string.Empty;
            maskCEP.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            maskTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
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
            pnlCadastrarCliente.Visible = false;
            pnlPesquisarCliente.Visible = false;
            
        }        

        private void stripCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= 2)
                {
                    ////PROCEDIMENTOS TELA
                    pnlCadastrarCliente.Visible = true;
                    pnlPesquisarCliente.Visible = false;
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }


           
        }

        private void stripPesquisarCliente_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= 2)
                {
                    ////PROCEDIMENTOS TELA
                    pnlPesquisarCliente.Visible = true;
                    pnlCadastrarCliente.Visible = false;
                    btnAlterDadosCliente.Enabled = false;
                    btnSalvarAlter.Enabled = false;

                    DataTable dt = new DataTable();

                    string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

                    MySqlConnection msConnection = new MySqlConnection();
                    msConnection.ConnectionString = connection_mysql;
                    msConnection.Open();
                    MySqlCommand msCommand = new MySqlCommand();
                    msCommand.CommandText = "SELECT codCliente as 'COD. Cliente', nmCliente as 'Nome Cliente', cpf as 'CPF', rg as 'RG', sexo as 'sexo', dtMatricula as 'Data Matrícula', dtNascimento as 'Data Nascimento', logradouro as 'Logradouro', numLogradouro as 'Nº', bairro as 'Bairro', cidade as 'Cidade', estado as 'UF', cep as 'CEP', telefone as 'Telefone', email as 'Email' FROM cliente WHERE 1=1";
                    msCommand.Connection = msConnection;
                    MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
                    msdAdapter.Fill(dt);

                    dtgridClientesCadastrados.DataSource = dt;
                    msConnection.Close();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }            
        }

        private void stripCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel == 3)
                {
                    ////PROCEDIMENTOS TELA
                    TelaFuncionario abrirTelaFuncionario = new TelaFuncionario();
                    abrirTelaFuncionario.Show();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }                             
                       
        }

        private void stripRegistrarAlterarTreino_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel == 1)
                {
                    ////PROCEDIMENTOS TELA
                    TelaTreinos abrirTelaTreinos = new TelaTreinos();
                    abrirTelaTreinos.Show();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }            
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
                // TRATAMENTO DOS DADOS PARA O INSERT
                string cpf = maskCPFCliente.Text;
                string rg = maskRGCliente.Text;
                string telefone = maskTelefone.Text;
                cpf = cpf.Replace(",", "").Replace("-", "");
                rg = rg.Replace(",", "").Replace("-", "");
                telefone = telefone.Replace("(", "").Replace(")", "");                

                string sexo;
                if (rdbtnMascCliente.Checked == true)
                {
                    sexo = "M";
                }
                else 
                {
                    sexo = "F";
                }

                string year = dttimepickDataMatricula.Value.Year.ToString();
                string month = dttimepickDataMatricula.Value.Month.ToString();
                string day = dttimepickDataMatricula.Value.Day.ToString();
                string data_matricula = year + "-" + month + "-" + day;

                string data_nasc = comboxAno.Text + "-" + comboxMes.Text + "-" + comboxDia.Text;


                // INSERT DOS DADOS PARA A TABELA CLIENTE
                string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

                MySqlConnection msConnection = new MySqlConnection();
                msConnection.ConnectionString = connection_mysql;
                msConnection.Open();
                MySqlCommand msCommand = new MySqlCommand();
                msCommand.CommandText = "INSERT INTO cliente VALUES (" 
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
                    "', '" + telefone +
                    "', '" + txtEmail.Text +
                    "');";
                
                msCommand.Connection = msConnection;
                msCommand.ExecuteNonQuery();
                msConnection.Close();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                LimparForm();
            }
        }

        private void btnLimparDadosCliente_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            btnAlterDadosCliente.Enabled = true;

            string cpf = maskPesquisarCPFCliente.Text;
            cpf = cpf.Replace(",", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                MessageBox.Show("Obrigatório preencher o CPF completo!");
            }
            
            else
            {
                DataTable dt = new DataTable();


                string connection_mysql = @"Server=localhost;Database=GenesysGym;Uid=root;Pwd='1234'";

                MySqlConnection msConnection = new MySqlConnection();
                msConnection.ConnectionString = connection_mysql;
                msConnection.Open();
                MySqlCommand msCommand = new MySqlCommand();
                string pesquisarCPF = " and cpf = '" + cpf + "'";
                string texto = "SELECT codCliente as 'COD. Cliente', nmCliente as 'Nome Cliente', cpf as 'CPF', rg as 'RG', sexo as 'sexo', dtMatricula as 'Data Matrícula', dtNascimento as 'Data Nascimento', logradouro as 'Logradouro', numLogradouro as 'Nº', bairro as 'Bairro', cidade as 'Cidade', estado as 'UF', cep as 'CEP', telefone as 'Telefone', email as 'Email' FROM cliente WHERE 1=1";
                //MessageBox.Show("Nome: "+(nome == "")+  "\nCPF: " + (cpf == "         ") + "\n REG: " + (registro == ""));
                if (cpf != "         ") texto += pesquisarCPF;

                msCommand.CommandText = texto;
                msCommand.Connection = msConnection;
                MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
                msdAdapter.Fill(dt);

                dtgridPesquisaCliente.DataSource = dt;
                msConnection.Close();
            }

        }

        private void btnAlterDadosCliente_Click(object sender, EventArgs e)
        {
            btnAlterDadosCliente.Enabled = false;
            btnSalvarAlter.Enabled = true;
           
        }

        private void strip_Logon_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin(this);
            telaLogin.ShowDialog();
            
        }

        private void strip_logoff_Click(object sender, EventArgs e)
        {
            lb_Acesso.Text = "0";
            lb_NomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.vermelho_led;

            Globais.nivel = 0;
            Globais.logado = false;

            pnlCadastrarCliente.Visible = false;
            pnlPesquisarCliente.Visible = false;
           
        }

        private void strip_BancoDados_Click(object sender, EventArgs e)
        {
            if(Globais.logado == true)
            {   
                if(Globais.nivel == 3)
                {
                    ////PROCEDIMENTOS TELA
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }
        }

        private void strip_NovoUser_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel == 3)
                {
                    TelaNovoUser abrirTelaNovoUser = new TelaNovoUser();
                    abrirTelaNovoUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }
        }

        private void strip_GestaoUser_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel == 3)
                {
                    TelaGestaoUsers abrirTelaGestaoUsers = new TelaGestaoUsers();
                    abrirTelaGestaoUsers.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }
        }

        private void stripExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel == 3)
                {
                    ////PROCEDIMENTOS TELA
                    
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }

        }

        private void stripExcluirCliente_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel == 3)
                {
                    ////PROCEDIMENTOS TELA
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("Necessário ter um Usuário logado!");
            }

        }
    }
}
