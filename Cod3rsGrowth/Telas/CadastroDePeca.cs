using Cod3rsGrowth.Modelos;
using System;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class CadastroDePeca : Form
    {
        public CadastroDePeca()
        {
            InitializeComponent();
        }

        private void AoClicarCriarNovaPeca_Click(object sender, EventArgs e)
        {
            Program.ListaDePecas.Add(new Peca(
                Program.GerarIdParaPeca(),
                CampoCategoriaDoFormularioCadastroDePecas.Text,
                CampoNomeDoFormularioCadastroDePecas.Text,
                CampoDescricaoDoFormularioCadastroDePecas.Text,
                Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                CampoDataDoFormularioCadastroDePecas.Value.Date
            ));

            CampoCategoriaDoFormularioCadastroDePecas.ResetText();
            CampoNomeDoFormularioCadastroDePecas.ResetText();
            CampoDescricaoDoFormularioCadastroDePecas.ResetText();
            CampoEstoqueDoFormularioCadastroDePecas.ResetText();
            CampoDataDoFormularioCadastroDePecas.ResetText();

            Program.ControleDePecas.AtualizarGrid();

            this.Close();

        }

        private void AoClicarFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
