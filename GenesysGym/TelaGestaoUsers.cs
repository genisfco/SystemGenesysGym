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
    public partial class TelaGestaoUsers : Form
    {
        public TelaGestaoUsers()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaGestaoUsers_Load(object sender, EventArgs e)
        {
            dgv_Usuarios.DataSource = DataConnection.ObterUsuariosIdNome();
        }
    }
}
