
namespace GenesysGym
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCadastrarCliente = new System.Windows.Forms.Panel();
            this.grpboxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTreinos = new System.Windows.Forms.ToolStripMenuItem();
            this.stripCadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.stripPesquisarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.stripExcluirCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.stripCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.stripPesquisarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.stripExcluirFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.stripRegistrarTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAlterarTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.mskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.maskRGCliente = new System.Windows.Forms.MaskedTextBox();
            this.dttimepickDataRegistro = new System.Windows.Forms.DateTimePicker();
            this.comboxDia = new System.Windows.Forms.ComboBox();
            this.comboxMes = new System.Windows.Forms.ComboBox();
            this.comboxAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grpboxEndereco = new System.Windows.Forms.GroupBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumLogradouro = new System.Windows.Forms.TextBox();
            this.maskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlCadastrarCliente.SuspendLayout();
            this.grpboxDadosPessoais.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpboxEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastrarCliente
            // 
            this.pnlCadastrarCliente.Controls.Add(this.grpboxEndereco);
            this.pnlCadastrarCliente.Controls.Add(this.label2);
            this.pnlCadastrarCliente.Controls.Add(this.label1);
            this.pnlCadastrarCliente.Controls.Add(this.dttimepickDataRegistro);
            this.pnlCadastrarCliente.Controls.Add(this.txtCodCliente);
            this.pnlCadastrarCliente.Controls.Add(this.grpboxDadosPessoais);
            this.pnlCadastrarCliente.Location = new System.Drawing.Point(12, 27);
            this.pnlCadastrarCliente.Name = "pnlCadastrarCliente";
            this.pnlCadastrarCliente.Size = new System.Drawing.Size(447, 548);
            this.pnlCadastrarCliente.TabIndex = 0;
            // 
            // grpboxDadosPessoais
            // 
            this.grpboxDadosPessoais.Controls.Add(this.radioButton2);
            this.grpboxDadosPessoais.Controls.Add(this.radioButton1);
            this.grpboxDadosPessoais.Controls.Add(this.label6);
            this.grpboxDadosPessoais.Controls.Add(this.label5);
            this.grpboxDadosPessoais.Controls.Add(this.label4);
            this.grpboxDadosPessoais.Controls.Add(this.label3);
            this.grpboxDadosPessoais.Controls.Add(this.comboxAno);
            this.grpboxDadosPessoais.Controls.Add(this.comboxMes);
            this.grpboxDadosPessoais.Controls.Add(this.comboxDia);
            this.grpboxDadosPessoais.Controls.Add(this.maskRGCliente);
            this.grpboxDadosPessoais.Controls.Add(this.mskCPFCliente);
            this.grpboxDadosPessoais.Controls.Add(this.txtNomeCliente);
            this.grpboxDadosPessoais.Location = new System.Drawing.Point(3, 59);
            this.grpboxDadosPessoais.Name = "grpboxDadosPessoais";
            this.grpboxDadosPessoais.Size = new System.Drawing.Size(439, 163);
            this.grpboxDadosPessoais.TabIndex = 0;
            this.grpboxDadosPessoais.TabStop = false;
            this.grpboxDadosPessoais.Text = "Dados Pessoais";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuFuncionarios,
            this.menuTreinos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripCadastrarCliente,
            this.stripPesquisarCliente,
            this.stripExcluirCliente});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(61, 20);
            this.menuClientes.Text = "Clientes";
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripCadastrarFuncionario,
            this.stripPesquisarFuncionario,
            this.stripExcluirFuncionario});
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(87, 20);
            this.menuFuncionarios.Text = "Funcionários";
            // 
            // menuTreinos
            // 
            this.menuTreinos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripRegistrarTreino,
            this.stripAlterarTreino});
            this.menuTreinos.Name = "menuTreinos";
            this.menuTreinos.Size = new System.Drawing.Size(56, 20);
            this.menuTreinos.Text = "Treinos";
            // 
            // stripCadastrarCliente
            // 
            this.stripCadastrarCliente.Name = "stripCadastrarCliente";
            this.stripCadastrarCliente.Size = new System.Drawing.Size(180, 22);
            this.stripCadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // stripPesquisarCliente
            // 
            this.stripPesquisarCliente.Name = "stripPesquisarCliente";
            this.stripPesquisarCliente.Size = new System.Drawing.Size(180, 22);
            this.stripPesquisarCliente.Text = "Pesquisar Cliente";
            // 
            // stripExcluirCliente
            // 
            this.stripExcluirCliente.Name = "stripExcluirCliente";
            this.stripExcluirCliente.Size = new System.Drawing.Size(180, 22);
            this.stripExcluirCliente.Text = "Excluir Cliente";
            // 
            // stripCadastrarFuncionario
            // 
            this.stripCadastrarFuncionario.Name = "stripCadastrarFuncionario";
            this.stripCadastrarFuncionario.Size = new System.Drawing.Size(190, 22);
            this.stripCadastrarFuncionario.Text = "Cadastrar Funcionário";
            // 
            // stripPesquisarFuncionario
            // 
            this.stripPesquisarFuncionario.Name = "stripPesquisarFuncionario";
            this.stripPesquisarFuncionario.Size = new System.Drawing.Size(190, 22);
            this.stripPesquisarFuncionario.Text = "Pesquisar Funcionário";
            // 
            // stripExcluirFuncionario
            // 
            this.stripExcluirFuncionario.Name = "stripExcluirFuncionario";
            this.stripExcluirFuncionario.Size = new System.Drawing.Size(190, 22);
            this.stripExcluirFuncionario.Text = "Excluir Funcionário";
            // 
            // stripRegistrarTreino
            // 
            this.stripRegistrarTreino.Name = "stripRegistrarTreino";
            this.stripRegistrarTreino.Size = new System.Drawing.Size(180, 22);
            this.stripRegistrarTreino.Text = "Registrar Treino";
            // 
            // stripAlterarTreino
            // 
            this.stripAlterarTreino.Name = "stripAlterarTreino";
            this.stripAlterarTreino.Size = new System.Drawing.Size(180, 22);
            this.stripAlterarTreino.Text = "Alterar Treino";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(4, 33);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodCliente.TabIndex = 0;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(7, 48);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(203, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // mskCPFCliente
            // 
            this.mskCPFCliente.Location = new System.Drawing.Point(216, 48);
            this.mskCPFCliente.Name = "mskCPFCliente";
            this.mskCPFCliente.Size = new System.Drawing.Size(100, 20);
            this.mskCPFCliente.TabIndex = 1;
            // 
            // maskRGCliente
            // 
            this.maskRGCliente.Location = new System.Drawing.Point(322, 48);
            this.maskRGCliente.Name = "maskRGCliente";
            this.maskRGCliente.Size = new System.Drawing.Size(100, 20);
            this.maskRGCliente.TabIndex = 2;
            // 
            // dttimepickDataRegistro
            // 
            this.dttimepickDataRegistro.Location = new System.Drawing.Point(239, 33);
            this.dttimepickDataRegistro.Name = "dttimepickDataRegistro";
            this.dttimepickDataRegistro.Size = new System.Drawing.Size(200, 20);
            this.dttimepickDataRegistro.TabIndex = 1;
            // 
            // comboxDia
            // 
            this.comboxDia.FormattingEnabled = true;
            this.comboxDia.Location = new System.Drawing.Point(7, 110);
            this.comboxDia.Name = "comboxDia";
            this.comboxDia.Size = new System.Drawing.Size(39, 21);
            this.comboxDia.TabIndex = 3;
            // 
            // comboxMes
            // 
            this.comboxMes.FormattingEnabled = true;
            this.comboxMes.Location = new System.Drawing.Point(52, 110);
            this.comboxMes.Name = "comboxMes";
            this.comboxMes.Size = new System.Drawing.Size(39, 21);
            this.comboxMes.TabIndex = 4;
            // 
            // comboxAno
            // 
            this.comboxAno.FormattingEnabled = true;
            this.comboxAno.Location = new System.Drawing.Point(97, 110);
            this.comboxAno.Name = "comboxAno";
            this.comboxAno.Size = new System.Drawing.Size(84, 21);
            this.comboxAno.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cod. Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Matrícula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Nascimento";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(258, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(337, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grpboxEndereco
            // 
            this.grpboxEndereco.Controls.Add(this.label12);
            this.grpboxEndereco.Controls.Add(this.label11);
            this.grpboxEndereco.Controls.Add(this.label10);
            this.grpboxEndereco.Controls.Add(this.label9);
            this.grpboxEndereco.Controls.Add(this.label8);
            this.grpboxEndereco.Controls.Add(this.label7);
            this.grpboxEndereco.Controls.Add(this.txtEstado);
            this.grpboxEndereco.Controls.Add(this.txtCidade);
            this.grpboxEndereco.Controls.Add(this.txtBairro);
            this.grpboxEndereco.Controls.Add(this.maskCEP);
            this.grpboxEndereco.Controls.Add(this.txtNumLogradouro);
            this.grpboxEndereco.Controls.Add(this.txtLogradouro);
            this.grpboxEndereco.Location = new System.Drawing.Point(3, 239);
            this.grpboxEndereco.Name = "grpboxEndereco";
            this.grpboxEndereco.Size = new System.Drawing.Size(436, 135);
            this.grpboxEndereco.TabIndex = 4;
            this.grpboxEndereco.TabStop = false;
            this.grpboxEndereco.Text = "Endereço";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(6, 40);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(256, 20);
            this.txtLogradouro.TabIndex = 0;
            // 
            // txtNumLogradouro
            // 
            this.txtNumLogradouro.Location = new System.Drawing.Point(268, 40);
            this.txtNumLogradouro.Name = "txtNumLogradouro";
            this.txtNumLogradouro.Size = new System.Drawing.Size(45, 20);
            this.txtNumLogradouro.TabIndex = 1;
            // 
            // maskCEP
            // 
            this.maskCEP.Location = new System.Drawing.Point(324, 40);
            this.maskCEP.Name = "maskCEP";
            this.maskCEP.Size = new System.Drawing.Size(100, 20);
            this.maskCEP.TabIndex = 2;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 97);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(182, 97);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(376, 97);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 20);
            this.txtEstado.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Logradouro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nº";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Estado";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 656);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCadastrarCliente);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "GenesysGym";
            this.pnlCadastrarCliente.ResumeLayout(false);
            this.pnlCadastrarCliente.PerformLayout();
            this.grpboxDadosPessoais.ResumeLayout(false);
            this.grpboxDadosPessoais.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpboxEndereco.ResumeLayout(false);
            this.grpboxEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastrarCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.GroupBox grpboxDadosPessoais;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem stripCadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem stripPesquisarCliente;
        private System.Windows.Forms.ToolStripMenuItem stripExcluirCliente;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem stripCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem stripPesquisarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem stripExcluirFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuTreinos;
        private System.Windows.Forms.ToolStripMenuItem stripRegistrarTreino;
        private System.Windows.Forms.ToolStripMenuItem stripAlterarTreino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dttimepickDataRegistro;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxAno;
        private System.Windows.Forms.ComboBox comboxMes;
        private System.Windows.Forms.ComboBox comboxDia;
        private System.Windows.Forms.MaskedTextBox maskRGCliente;
        private System.Windows.Forms.MaskedTextBox mskCPFCliente;
        private System.Windows.Forms.GroupBox grpboxEndereco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox maskCEP;
        private System.Windows.Forms.TextBox txtNumLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
    }
}

