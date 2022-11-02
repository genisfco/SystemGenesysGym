using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Markup.Localizer;

namespace GenesysGym
{
    public partial class TelaTreinos : Form
    {
        public TelaTreinos()
        {
            InitializeComponent();
        }



        // MÉTODO PARA ADICIONAR COMBOBOX COM LISTA 
        private void AddComboBoxList(ComboBox cbo, int locH, int locV, int sizeH, int sizeV, Array popular)
        {
            //Propriedades para construção da ComboBox
            cbo.Location = new System.Drawing.Point(locH, locV);
            cbo.Size = new System.Drawing.Size(sizeH, sizeV);
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;

            //Popular a ComboBox
            cbo.DataSource = popular;

            //Inserir o controle no forms
            this.Controls.Add(cbo);
            cbo.SelectedIndex = -1;
        }

        // MÉTODO PARA ADICIONAR COMBOBOX SEM LISTA 
        private void AddComboBox(ComboBox cbo, int locH, int locV, int sizeH, int sizeV)
        {
            //Propriedades para construção da ComboBox
            cbo.Location = new System.Drawing.Point(locH, locV);
            cbo.Size = new System.Drawing.Size(sizeH, sizeV);
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;


            //Inserir o controle no forms
            this.Controls.Add(cbo);
        }

        //MÉTODO PARA ADICIONAR BOTÃO
        private void AddBtnExercicio(Button btn, int locH, int locV, int sizeH, int sizeV)
        {
            Button btnAdd = new Button();

            //Propriedade do Button
            btnAdd.Location = new System.Drawing.Point(locH, locV);
            btnAdd.Size = new System.Drawing.Size(sizeH, sizeV);
            btnAdd.Text = "+";
            btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(btnAdd);
        }

        
        private void btnAddTreinoA_Click(object sender, EventArgs e)
        {
            for (int i = 116; i < 300 ; i+=30)
            {
                int locV = i;

                var cboGrupoMuscular = new ComboBox();
                string[] itensGrupoMuscular = { "PEITORAL", "DORSAIS", "OMBROS e TRAPÉZIOS", "TRÍCEPS", "BÍCEPS", "PERNAS", "PANTURRILHAS", "ABDOMEN" };

                var cboExercicio = new ComboBox();

                var cboSeries = new ComboBox();
                string[] itensSeries = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };

                var cboRepeticoes = new ComboBox();
                string[] itensRepeticoes = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };

                var btnAdd = new Button();

                AddComboBoxList(cboGrupoMuscular, 13, locV, 145, 28, itensGrupoMuscular);
                AddComboBox(cboExercicio, 168, locV, 160, 28);
                AddComboBoxList(cboSeries, 338, locV, 40, 28, itensSeries);
                AddComboBoxList(cboRepeticoes, 388, locV, 40, 28, itensRepeticoes);
                //AddBtnExercicio(btnAdd, 438, 115, 30, 23);

                btnAddTreinoA.Enabled = false;
                btnAddTreinoB.Enabled = true;

            }
        }

        private void TelaTreinos_Load(object sender, EventArgs e)
        {
            btnAddTreinoB.Enabled = false;
        }

        private void btnAddTreinoB_Click(object sender, EventArgs e)
        {
            for (int i = 116; i < 300; i += 30)
            {
                int locV = i;

                var cboGrupoMuscular = new ComboBox();
                string[] itensGrupoMuscular = { "PEITORAL", "DORSAIS", "OMBROS e TRAPÉZIOS", "TRÍCEPS", "BÍCEPS", "PERNAS", "PANTURRILHAS", "ABDOMEN" };

                var cboExercicio = new ComboBox();

                var cboSeries = new ComboBox();
                string[] itensSeries = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };

                var cboRepeticoes = new ComboBox();
                string[] itensRepeticoes = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };

                var btnAdd = new Button();

                AddComboBoxList(cboGrupoMuscular, 750, locV, 145, 28, itensGrupoMuscular);
                AddComboBox(cboExercicio, 905, locV, 160, 28);
                AddComboBoxList(cboSeries, 1075, locV, 40, 28, itensSeries);
                AddComboBoxList(cboRepeticoes, 1125, locV, 40, 28, itensRepeticoes);
                //AddBtnExercicio(btnAdd, 438, 115, 30, 23);

                btnAddTreinoB.Enabled = false;

            }
        }
    }
}
