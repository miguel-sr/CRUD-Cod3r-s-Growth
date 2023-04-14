using Cod3rsGrowth.Modelos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class CadastroDePeca : Form
    {
        readonly BindingList<Peca> ListaDePecas;
        public CadastroDePeca(BindingList<Peca> ListaDePecas)
        {
            InitializeComponent();
            this.ListaDePecas = ListaDePecas;
        }

        private void AoClicarCriarNovaPeca_Click(object sender, EventArgs e)
        {
            ListaDePecas.Add(new Peca(
                GerarIdParaPeca(),
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
        }

        private void AoClicarFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static int contadorDeId = 0;
        public static int GerarIdParaPeca()
        {
            return contadorDeId++;
        }
    }
}
