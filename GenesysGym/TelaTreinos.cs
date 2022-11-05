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
           
        }
    }
}
