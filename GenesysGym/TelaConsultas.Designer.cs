﻿
namespace GenesysGym
{
    partial class TelaConsultas
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
            this.pnlConsultarFuncionario = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Panel();

            this.maskCPFFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.dtgridPesquisaFuncionario = new System.Windows.Forms.DataGridView();
            this.dtgridFuncionarios = new System.Windows.Forms.DataGridView();
            this.pnlConsultarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPesquisaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridFuncionarios)).BeginInit();

            this.maskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.dtgridPesquisaCliente = new System.Windows.Forms.DataGridView();
            this.dtgridClientes = new System.Windows.Forms.DataGridView();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPesquisaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridClientes)).BeginInit();

            this.SuspendLayout();
            // 
            // pnlConsultarFuncionario
            // 

            this.pnlConsultarFuncionario.Controls.Add(this.dtgridFuncionarios);
            this.pnlConsultarFuncionario.Controls.Add(this.dtgridPesquisaFuncionario);
            this.pnlConsultarFuncionario.Controls.Add(this.btnPesquisarFuncionario);
            this.pnlConsultarFuncionario.Controls.Add(this.maskCPFFuncionario);

            this.pnlConsultarFuncionario.Location = new System.Drawing.Point(12, 12);
            this.pnlConsultarFuncionario.Name = "pnlConsultarFuncionario";
            this.pnlConsultarFuncionario.Size = new System.Drawing.Size(447, 548);
            this.pnlConsultarFuncionario.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dtgridClientes);
            this.pnl.Controls.Add(this.dtgridPesquisaCliente);
            this.pnl.Controls.Add(this.btnPesquisarCliente);
            this.pnl.Controls.Add(this.maskCPFCliente);
            this.pnl.Location = new System.Drawing.Point(483, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(447, 548);
            this.pnl.TabIndex = 1;
            // 
<<<<<<< HEAD
            // maskCPFFuncionario
            // 
            this.maskCPFFuncionario.Location = new System.Drawing.Point(3, 49);
            this.maskCPFFuncionario.Name = "maskCPFFuncionario";
            this.maskCPFFuncionario.Size = new System.Drawing.Size(100, 20);
            this.maskCPFFuncionario.TabIndex = 0;
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(294, 47);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(123, 23);
            this.btnPesquisarFuncionario.TabIndex = 1;
            this.btnPesquisarFuncionario.Text = "Pesquisar Funcionário";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            // 
            // dtgridPesquisaFuncionario
            // 
            this.dtgridPesquisaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridPesquisaFuncionario.Location = new System.Drawing.Point(3, 76);
            this.dtgridPesquisaFuncionario.Name = "dtgridPesquisaFuncionario";
            this.dtgridPesquisaFuncionario.Size = new System.Drawing.Size(444, 59);
            this.dtgridPesquisaFuncionario.TabIndex = 2;
            // 
            // dtgridFuncionarios
            // 
            this.dtgridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridFuncionarios.Location = new System.Drawing.Point(0, 210);
            this.dtgridFuncionarios.Name = "dtgridFuncionarios";
            this.dtgridFuncionarios.Size = new System.Drawing.Size(444, 296);
            this.dtgridFuncionarios.TabIndex = 3;
=======
            // maskCPFCliente
            // 
            this.maskCPFCliente.Location = new System.Drawing.Point(3, 41);
            this.maskCPFCliente.Name = "maskCPFCliente";
            this.maskCPFCliente.Size = new System.Drawing.Size(100, 20);
            this.maskCPFCliente.TabIndex = 0;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(301, 41);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(113, 23);
            this.btnPesquisarCliente.TabIndex = 1;
            this.btnPesquisarCliente.Text = "Pesquisar Cliente";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // dtgridPesquisaCliente
            // 
            this.dtgridPesquisaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridPesquisaCliente.Location = new System.Drawing.Point(3, 70);
            this.dtgridPesquisaCliente.Name = "dtgridPesquisaCliente";
            this.dtgridPesquisaCliente.Size = new System.Drawing.Size(441, 74);
            this.dtgridPesquisaCliente.TabIndex = 2;
            // 
            // dtgridClientes
            // 
            this.dtgridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridClientes.Location = new System.Drawing.Point(3, 233);
            this.dtgridClientes.Name = "dtgridClientes";
            this.dtgridClientes.Size = new System.Drawing.Size(441, 278);
            this.dtgridClientes.TabIndex = 3;
>>>>>>> 8fc0b6558e9455e1779bbe68324bce5df6ce32af
            // 
            // TelaConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 881);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlConsultarFuncionario);
            this.Name = "TelaConsultas";
            this.Text = "TelaConsultas";
<<<<<<< HEAD
            this.pnlConsultarFuncionario.ResumeLayout(false);
            this.pnlConsultarFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPesquisaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridFuncionarios)).EndInit();
=======
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPesquisaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridClientes)).EndInit();
>>>>>>> 8fc0b6558e9455e1779bbe68324bce5df6ce32af
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsultarFuncionario;
        private System.Windows.Forms.Panel pnl;
<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dtgridFuncionarios;
        private System.Windows.Forms.DataGridView dtgridPesquisaFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.MaskedTextBox maskCPFFuncionario;
=======
        private System.Windows.Forms.DataGridView dtgridPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.MaskedTextBox maskCPFCliente;
        private System.Windows.Forms.DataGridView dtgridClientes;
>>>>>>> 8fc0b6558e9455e1779bbe68324bce5df6ce32af
    }
}