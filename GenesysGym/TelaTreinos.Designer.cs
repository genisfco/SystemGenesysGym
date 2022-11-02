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
            this.menuAlterarTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDivisoesTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.stripABC = new System.Windows.Forms.ToolStripMenuItem();
            this.stripABCD = new System.Windows.Forms.ToolStripMenuItem();
            this.stripABCDE = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTreinoAB = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoTreino,
            this.menuAlterarTreino});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNovoTreino
            // 
            this.menuNovoTreino.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripDivisoesTreino});
            this.menuNovoTreino.Name = "menuNovoTreino";
            this.menuNovoTreino.Size = new System.Drawing.Size(83, 20);
            this.menuNovoTreino.Text = "Novo Treino";
            // 
            // menuAlterarTreino
            // 
            this.menuAlterarTreino.Name = "menuAlterarTreino";
            this.menuAlterarTreino.Size = new System.Drawing.Size(89, 20);
            this.menuAlterarTreino.Text = "Alterar Treino";
            // 
            // stripDivisoesTreino
            // 
            this.stripDivisoesTreino.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripABC,
            this.stripABCD,
            this.stripABCDE});
            this.stripDivisoesTreino.Name = "stripDivisoesTreino";
            this.stripDivisoesTreino.Size = new System.Drawing.Size(180, 22);
            this.stripDivisoesTreino.Text = "Divisões de Treino";
            // 
            // stripABC
            // 
            this.stripABC.Name = "stripABC";
            this.stripABC.Size = new System.Drawing.Size(180, 22);
            this.stripABC.Text = "ABC";
            // 
            // stripABCD
            // 
            this.stripABCD.Name = "stripABCD";
            this.stripABCD.Size = new System.Drawing.Size(180, 22);
            this.stripABCD.Text = "ABCD";
            // 
            // stripABCDE
            // 
            this.stripABCDE.Name = "stripABCDE";
            this.stripABCDE.Size = new System.Drawing.Size(180, 22);
            this.stripABCDE.Text = "ABCDE";
            // 
            // panelTreinoAB
            // 
            this.panelTreinoAB.Location = new System.Drawing.Point(12, 79);
            this.panelTreinoAB.Name = "panelTreinoAB";
            this.panelTreinoAB.Size = new System.Drawing.Size(940, 490);
            this.panelTreinoAB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // maskCPFCliente
            // 
            this.maskCPFCliente.Location = new System.Drawing.Point(80, 40);
            this.maskCPFCliente.Mask = "000.000.000-00";
            this.maskCPFCliente.Name = "maskCPFCliente";
            this.maskCPFCliente.Size = new System.Drawing.Size(82, 20);
            this.maskCPFCliente.TabIndex = 4;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(226, 40);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(255, 20);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // TelaTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 581);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.maskCPFCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTreinoAB);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaTreinos";
            this.Text = "Treinos";
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
        private System.Windows.Forms.ToolStripMenuItem stripABCDE;
        private System.Windows.Forms.ToolStripMenuItem menuAlterarTreino;
        private System.Windows.Forms.Panel panelTreinoAB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskCPFCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
    }
}