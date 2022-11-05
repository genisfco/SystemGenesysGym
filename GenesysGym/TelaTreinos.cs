using System;
using System.Windows.Forms;

namespace GenesysGym
{
    public partial class TelaTreinos : Form
    {
        public TelaTreinos()
        {
            InitializeComponent();
        }

        // LISTAS DE EXERCÍCIOS
        string[] exercPeitoral = {
            "Supino Reto",
            "Supino Inclinado",
            "Supino Declinado",
            "Crucifixo Reto",
            "Crucifixo Inclinado",
            "Fly Reto",
            "Fly Inclinado",
            "Peck Deck",
            "Cross-Over",
            "Flexão de braços",
            "Pull-Over"
        };

        string[] exercCostas = {
            "Barra fixa",
            "Pulley frontal",
            "Pulley frontal supinado",
            "Pulley frontal triângulo",
            "Remada Máquina",
            "Remada Baixa Sentado",
            "Remada Curvada",
            "Remada unilateral (serrote)",
            "Remada Cavalinho",
            "Pull-Down",
            "Extensão lombar"
        };

        string[] exercOmbros = {
            "Desenvolvimento halteres",
            "Desenvolvimento barra",
            "Desenvolvimento máquina",
            "Desenvolvimento Arnold",
            "Elevação lateral",
            "Elevação frontal",
            "Crucifixo inverso",
            "Remada alta",
            "Encolhimento halteres",
            "Encolhimento barra smith",
        };

        string[] exercTriceps = {
            "Pulley tríceps",
            "Pulley tríceps invertido",
            "Pulley corda",
            "Rosca francesa",
            "Tríceps testa",
            "Tríceps banco",
            "Tríceps coice",
            "Tríceps máquina",
            "Supino fechado",
            "Paralelas"
        };

        string[] exercBiceps = {
            "Rosca direta barra",
            "Rosca simultânea halteres",
            "Rosca alternada halteres",
            "Rosca scott",
            "Rosca scott unilateral",
            "Rosca concentrada",
            "Rosca inversa",
            "Rosca martelo",
        };

        string[] exercPernas = {
            "Leg press 45º",
            "Leg press horizontal",
            "Agachamento smith",
            "Agachamento hack",
            "Agachamento livre",
            "Cadeira extensora",
            "Cadeira flexora",
            "Mesa flexora",
            "Afundo",
            "Afundo búlgaro",
            "Avanço",
            "Passada",
            "Stiff",
            "Agachamento sumô",
            "Abdução",
            "Adução",
            "Elevação pélvica"
        };

        string[] exercPanturrilhas = {
            "Gêmeos sentado",
            "Elevação de gêmeos"
        };

        string[] exercAbdomen = {
            "Abdominal reto",
            "Elevação de pernas",
            "Abdominal máquina",
            "Prancha abdominal",
            "Prancha lateral",
            "Roda abdominal",
        };

        
        
        private void cboGrup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc1.Items.Clear();
            
            if (cboGrup1.SelectedIndex == 0)
            {
                cboExerc1.Items.AddRange(exercPeitoral);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 1)
            {
                cboExerc1.Items.AddRange(exercCostas);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 2)
            {
                cboExerc1.Items.AddRange(exercOmbros);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 3)
            {
                cboExerc1.Items.AddRange(exercTriceps);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 4)
            {
                cboExerc1.Items.AddRange(exercBiceps);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 5)
            {
                cboExerc1.Items.AddRange(exercPernas);
                cboExerc1.SelectedIndex = 0;
            }
            else if (cboGrup1.SelectedIndex == 6)
            {
                cboExerc1.Items.AddRange(exercPanturrilhas);
                cboExerc1.SelectedIndex = 0;
            }
            else if(cboGrup1.SelectedIndex == 7)
            {
                cboExerc1.Items.AddRange(exercAbdomen);
                cboExerc1.SelectedIndex=0;
            }

        }

        

        private void cboGrup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc2.Items.Clear();

            if (cboGrup2.SelectedIndex == 0)
            {
                cboExerc2.Items.AddRange(exercPeitoral);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 1)
            {
                cboExerc2.Items.AddRange(exercCostas);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 2)
            {
                cboExerc2.Items.AddRange(exercOmbros);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 3)
            {
                cboExerc2.Items.AddRange(exercTriceps);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 4)
            {
                cboExerc2.Items.AddRange(exercBiceps);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 5)
            {
                cboExerc2.Items.AddRange(exercPernas);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 6)
            {
                cboExerc2.Items.AddRange(exercPanturrilhas);
                cboExerc2.SelectedIndex = 0;
            }
            else if (cboGrup2.SelectedIndex == 7)
            {
                cboExerc2.Items.AddRange(exercAbdomen);
                cboExerc2.SelectedIndex = 0;
            }
        }

        private void cboGrup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc3.Items.Clear();

            if (cboGrup3.SelectedIndex == 0)
            {
                cboExerc3.Items.AddRange(exercPeitoral);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 1)
            {
                cboExerc3.Items.AddRange(exercCostas);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 2)
            {
                cboExerc3.Items.AddRange(exercOmbros);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 3)
            {
                cboExerc3.Items.AddRange(exercTriceps);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 4)
            {
                cboExerc3.Items.AddRange(exercBiceps);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 5)
            {
                cboExerc3.Items.AddRange(exercPernas);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 6)
            {
                cboExerc3.Items.AddRange(exercPanturrilhas);
                cboExerc3.SelectedIndex = 0;
            }
            else if (cboGrup3.SelectedIndex == 7)
            {
                cboExerc3.Items.AddRange(exercAbdomen);
                cboExerc3.SelectedIndex = 0;
            }
        }

        private void cboGrup4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc4.Items.Clear();

            if (cboGrup4.SelectedIndex == 0)
            {
                cboExerc4.Items.AddRange(exercPeitoral);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 1)
            {
                cboExerc4.Items.AddRange(exercCostas);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 2)
            {
                cboExerc4.Items.AddRange(exercOmbros);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 3)
            {
                cboExerc4.Items.AddRange(exercTriceps);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 4)
            {
                cboExerc4.Items.AddRange(exercBiceps);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 5)
            {
                cboExerc4.Items.AddRange(exercPernas);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 6)
            {
                cboExerc4.Items.AddRange(exercPanturrilhas);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup4.SelectedIndex == 7)
            {
                cboExerc4.Items.AddRange(exercAbdomen);
                cboExerc4.SelectedIndex = 0;
            }
        }

        private void cboGrup5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc5.Items.Clear();

            if (cboGrup5.SelectedIndex == 0)
            {
                cboExerc5.Items.AddRange(exercPeitoral);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 1)
            {
                cboExerc5.Items.AddRange(exercCostas);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 2)
            {
                cboExerc5.Items.AddRange(exercOmbros);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 3)
            {
                cboExerc5.Items.AddRange(exercTriceps);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 4)
            {
                cboExerc5.Items.AddRange(exercBiceps);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 5)
            {
                cboExerc5.Items.AddRange(exercPernas);
                cboExerc5.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 6)
            {
                cboExerc4.Items.AddRange(exercPanturrilhas);
                cboExerc4.SelectedIndex = 0;
            }
            else if (cboGrup5.SelectedIndex == 7)
            {
                cboExerc5.Items.AddRange(exercAbdomen);
                cboExerc5.SelectedIndex = 0;
            }
        }

        private void cboGrup6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc6.Items.Clear();

            if (cboGrup6.SelectedIndex == 0)
            {
                cboExerc6.Items.AddRange(exercPeitoral);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 1)
            {
                cboExerc6.Items.AddRange(exercCostas);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 2)
            {
                cboExerc6.Items.AddRange(exercOmbros);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 3)
            {
                cboExerc6.Items.AddRange(exercTriceps);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 4)
            {
                cboExerc6.Items.AddRange(exercBiceps);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 5)
            {
                cboExerc6.Items.AddRange(exercPernas);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 6)
            {
                cboExerc6.Items.AddRange(exercPanturrilhas);
                cboExerc6.SelectedIndex = 0;
            }
            else if (cboGrup6.SelectedIndex == 7)
            {
                cboExerc6.Items.AddRange(exercAbdomen);
                cboExerc6.SelectedIndex = 0;
            }
        }

        private void cboGrup7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc7.Items.Clear();

            if (cboGrup7.SelectedIndex == 0)
            {
                cboExerc7.Items.AddRange(exercPeitoral);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 1)
            {
                cboExerc7.Items.AddRange(exercCostas);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 2)
            {
                cboExerc7.Items.AddRange(exercOmbros);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 3)
            {
                cboExerc7.Items.AddRange(exercTriceps);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 4)
            {
                cboExerc7.Items.AddRange(exercBiceps);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 5)
            {
                cboExerc7.Items.AddRange(exercPernas);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 6)
            {
                cboExerc7.Items.AddRange(exercPanturrilhas);
                cboExerc7.SelectedIndex = 0;
            }
            else if (cboGrup7.SelectedIndex == 7)
            {
                cboExerc7.Items.AddRange(exercAbdomen);
                cboExerc7.SelectedIndex = 0;
            }
        }

        private void cboGrup8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExerc8.Items.Clear();

            if (cboGrup8.SelectedIndex == 0)
            {
                cboExerc8.Items.AddRange(exercPeitoral);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 1)
            {
                cboExerc8.Items.AddRange(exercCostas);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 2)
            {
                cboExerc8.Items.AddRange(exercOmbros);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 3)
            {
                cboExerc8.Items.AddRange(exercTriceps);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 4)
            {
                cboExerc8.Items.AddRange(exercBiceps);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 5)
            {
                cboExerc8.Items.AddRange(exercPernas);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 6)
            {
                cboExerc8.Items.AddRange(exercPanturrilhas);
                cboExerc8.SelectedIndex = 0;
            }
            else if (cboGrup8.SelectedIndex == 7)
            {
                cboExerc8.Items.AddRange(exercAbdomen);
                cboExerc8.SelectedIndex = 0;
            }
        }





        private void btnLimparTreinoA_Click(object sender, EventArgs e)
        {
            cboGrup1.Text = String.Empty; cboExerc1.Text = String.Empty; cboExerc1.Items.Clear(); cboSerie1.Text = String.Empty; cboRep1.Text = String.Empty;
            cboGrup2.Text = String.Empty; cboExerc2.Text = String.Empty; cboExerc2.Items.Clear(); cboSerie2.Text = String.Empty; cboRep2.Text = String.Empty;
            cboGrup3.Text = String.Empty; cboExerc3.Text = String.Empty; cboExerc3.Items.Clear(); cboSerie3.Text = String.Empty; cboRep3.Text = String.Empty;
            cboGrup4.Text = String.Empty; cboExerc4.Text = String.Empty; cboExerc4.Items.Clear(); cboSerie4.Text = String.Empty; cboRep4.Text = String.Empty;
            cboGrup5.Text = String.Empty; cboExerc5.Text = String.Empty; cboExerc5.Items.Clear(); cboSerie5.Text = String.Empty; cboRep5.Text = String.Empty;
            cboGrup6.Text = String.Empty; cboExerc6.Text = String.Empty; cboExerc6.Items.Clear(); cboSerie6.Text = String.Empty; cboRep6.Text = String.Empty;
            cboGrup7.Text = String.Empty; cboExerc7.Text = String.Empty; cboExerc7.Items.Clear(); cboSerie7.Text = String.Empty; cboRep7.Text = String.Empty;
            cboGrup8.Text = String.Empty; cboExerc8.Text = String.Empty; cboExerc8.Items.Clear(); cboSerie8.Text = String.Empty; cboRep8.Text = String.Empty;
        }

        private void btnLimparTreinoB_Click(object sender, EventArgs e)
        {
            cboGrup9.Text = String.Empty; cboExerc9.Text = String.Empty; cboExerc9.Items.Clear(); cboSerie9.Text = String.Empty; cboRep9.Text = String.Empty;
            cboGrup10.Text = String.Empty; cboExerc10.Text = String.Empty; cboExerc10.Items.Clear(); cboSerie10.Text = String.Empty; cboRep10.Text = String.Empty;
            cboGrup11.Text = String.Empty; cboExerc11.Text = String.Empty; cboExerc11.Items.Clear(); cboSerie11.Text = String.Empty; cboRep11.Text = String.Empty;
            cboGrup12.Text = String.Empty; cboExerc12.Text = String.Empty; cboExerc12.Items.Clear(); cboSerie12.Text = String.Empty; cboRep12.Text = String.Empty;
            cboGrup13.Text = String.Empty; cboExerc13.Text = String.Empty; cboExerc13.Items.Clear(); cboSerie13.Text = String.Empty; cboRep13.Text = String.Empty;
            cboGrup14.Text = String.Empty; cboExerc14.Text = String.Empty; cboExerc14.Items.Clear(); cboSerie14.Text = String.Empty; cboRep14.Text = String.Empty;
            cboGrup15.Text = String.Empty; cboExerc15.Text = String.Empty; cboExerc15.Items.Clear(); cboSerie15.Text = String.Empty; cboRep15.Text = String.Empty;
            cboGrup16.Text = String.Empty; cboExerc16.Text = String.Empty; cboExerc16.Items.Clear(); cboSerie16.Text = String.Empty; cboRep16.Text = String.Empty;
        }

        private void btnSairTreino_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
