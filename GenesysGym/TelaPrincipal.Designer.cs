
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
            this.pnlCadastrarCliente.SuspendLayout();
            this.grpboxDadosPessoais.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastrarCliente
            // 
            this.pnlCadastrarCliente.Controls.Add(this.txtCodCliente);
            this.pnlCadastrarCliente.Location = new System.Drawing.Point(12, 27);
            this.pnlCadastrarCliente.Name = "pnlCadastrarCliente";
            this.pnlCadastrarCliente.Size = new System.Drawing.Size(453, 351);
            this.pnlCadastrarCliente.TabIndex = 0;
            // 
            // grpboxDadosPessoais
            // 
            this.grpboxDadosPessoais.Controls.Add(this.txtNomeCliente);
            this.grpboxDadosPessoais.Location = new System.Drawing.Point(12, 175);
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
            this.txtCodCliente.Location = new System.Drawing.Point(4, 22);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodCliente.TabIndex = 0;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(7, 48);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 656);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpboxDadosPessoais);
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
    }
}

