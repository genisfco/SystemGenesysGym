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

        private void cboGrup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrup1.SelectedIndex == 0)
            {
                string[] itensExercPeitoral = { " Supino Reto ",
                                            " Supino Inclinado ",
                                            " Supino Declinado ",
                                            " Crucifixo Reto ",
                                            " Crucifixo Inclinado ",
                                            " Fly Reto ",
                                            " Fly Inclinado ",
                                            " Peck Deck ",
                                            " Cross-Over ",
                                            " Flexão de braços ",
                                            " Pull-Over " };
                cboExerc1.Items.Add (itensExercPeitoral);
                cboExerc1.SelectedIndex = 0;
            }
        }
    }
}
