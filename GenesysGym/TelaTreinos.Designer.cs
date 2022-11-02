namespace GenesysGym
{
    partial class TelaTreinos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNovoTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDivisoesTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.stripABC = new System.Windows.Forms.ToolStripMenuItem();
            this.stripABCD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlterarTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargoFuncionario = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btnAddTreinoA = new System.Windows.Forms.Button();
            this.btnAddTreinoB = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoTreino,
            this.menuAlterarTreino});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1778, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNovoTreino
            // 
            this.menuNovoTreino.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripDivisoesTreino});
            this.menuNovoTreino.Name = "menuNovoTreino";
            this.menuNovoTreino.Size = new System.Drawing.Size(124, 29);
            this.menuNovoTreino.Text = "Novo Treino";
            // 
            // stripDivisoesTreino
            // 
            this.stripDivisoesTreino.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripABC,
            this.stripABCD});
            this.stripDivisoesTreino.Name = "stripDivisoesTreino";
            this.stripDivisoesTreino.Size = new System.Drawing.Size(257, 34);
            this.stripDivisoesTreino.Text = "Divisões de Treino";
            // 
            // stripABC
            // 
            this.stripABC.Name = "stripABC";
            this.stripABC.Size = new System.Drawing.Size(160, 34);
            this.stripABC.Text = "ABC";
            // 
            // stripABCD
            // 
            this.stripABCD.Name = "stripABCD";
            this.stripABCD.Size = new System.Drawing.Size(160, 34);
            this.stripABCD.Text = "ABCD";
            // 
            // menuAlterarTreino
            // 
            this.menuAlterarTreino.Name = "menuAlterarTreino";
            this.menuAlterarTreino.Size = new System.Drawing.Size(132, 29);
            this.menuAlterarTreino.Text = "Alterar Treino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // maskCPFCliente
            // 
            this.maskCPFCliente.Location = new System.Drawing.Point(17, 72);
            this.maskCPFCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskCPFCliente.Mask = "000.000.000-00";
            this.maskCPFCliente.Name = "maskCPFCliente";
            this.maskCPFCliente.Size = new System.Drawing.Size(121, 26);
            this.maskCPFCliente.TabIndex = 4;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(166, 72);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(380, 26);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(553, 60);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(126, 51);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1119, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cod. Func.";
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Location = new System.Drawing.Point(1123, 72);
            this.txtCodFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(82, 26);
            this.txtCodFuncionario.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1237, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cargo";
            // 
            // txtCargoFuncionario
            // 
            this.txtCargoFuncionario.Location = new System.Drawing.Point(1242, 72);
            this.txtCargoFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCargoFuncionario.Name = "txtCargoFuncionario";
            this.txtCargoFuncionario.Size = new System.Drawing.Size(136, 26);
            this.txtCargoFuncionario.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1397, 47);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 20);
            this.label24.TabIndex = 19;
            this.label24.Text = "Nome";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(1401, 72);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(362, 26);
            this.txtNomeFuncionario.TabIndex = 18;
            // 
            // btnAddTreinoA
            // 
            this.btnAddTreinoA.Location = new System.Drawing.Point(17, 117);
            this.btnAddTreinoA.Name = "btnAddTreinoA";
            this.btnAddTreinoA.Size = new System.Drawing.Size(223, 57);
            this.btnAddTreinoA.TabIndex = 20;
            this.btnAddTreinoA.Text = "Adicionar Treino A";
            this.btnAddTreinoA.UseVisualStyleBackColor = true;
            this.btnAddTreinoA.Click += new System.EventHandler(this.btnAddTreinoA_Click);
            // 
            // btnAddTreinoB
            // 
            this.btnAddTreinoB.Location = new System.Drawing.Point(1123, 117);
            this.btnAddTreinoB.Name = "btnAddTreinoB";
            this.btnAddTreinoB.Size = new System.Drawing.Size(223, 57);
            this.btnAddTreinoB.TabIndex = 21;
            this.btnAddTreinoB.Text = "Adicionar Treino  B";
            this.btnAddTreinoB.UseVisualStyleBackColor = true;
            this.btnAddTreinoB.Click += new System.EventHandler(this.btnAddTreinoB_Click);
            // 
            // TelaTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 894);
            this.Controls.Add(this.btnAddTreinoB);
            this.Controls.Add(this.btnAddTreinoA);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCargoFuncionario);
            this.Controls.Add(this.txtCodFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.maskCPFCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1800, 950);
            this.Name = "TelaTreinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treinos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaTreinos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNovoTreino;
        private System.Windows.Forms.ToolStripMenuItem stripDivisoesTreino;
        private System.Windows.Forms.ToolStripMenuItem stripABC;
        private System.Windows.Forms.ToolStripMenuItem stripABCD;
        private System.Windows.Forms.ToolStripMenuItem menuAlterarTreino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskCPFCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargoFuncionario;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Button btnAddTreinoA;
        private System.Windows.Forms.Button btnAddTreinoB;
    }
}