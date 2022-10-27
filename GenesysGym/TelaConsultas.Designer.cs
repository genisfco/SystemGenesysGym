
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
            this.pnlConsultarCliente = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlConsultarCliente
            // 
            this.pnlConsultarCliente.Location = new System.Drawing.Point(12, 12);
            this.pnlConsultarCliente.Name = "pnlConsultarCliente";
            this.pnlConsultarCliente.Size = new System.Drawing.Size(447, 548);
            this.pnlConsultarCliente.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(483, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(447, 548);
            this.pnl.TabIndex = 1;
            // 
            // TelaConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 881);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlConsultarCliente);
            this.Name = "TelaConsultas";
            this.Text = "TelaConsultas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsultarCliente;
        private System.Windows.Forms.Panel pnl;
    }
}