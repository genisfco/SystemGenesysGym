﻿using System;
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
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void TelaFuncionario_Load(object sender, EventArgs e)
        {   
            pnlCadastrarFuncionario.Visible = false;
            pnlConsultarFuncionario.Visible = true;

        }


    }
}
