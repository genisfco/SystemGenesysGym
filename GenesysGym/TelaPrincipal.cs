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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
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
            
        }
    }
}
