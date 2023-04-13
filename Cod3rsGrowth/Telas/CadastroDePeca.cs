using Cod3rsGrowth.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class CadastroDePeca : Form
    {
        public CadastroDePeca()
        {
            InitializeComponent();
        }

        private void CadastroDePeca_Load(object sender, EventArgs e)
        {
            
        }

        private void AoClicarCriarNovaPeca_Click(object sender, EventArgs e)
        {
            Program.ListaDePecas.Add(new Peca(
                GerarIdParaPeca(),
                CampoCategoriaDoFormularioCadastroDePecas.Text,
                CampoNomeDoFormularioCadastroDePecas.Text,
                CampoDescricaoDoFormularioCadastroDePecas.Text,
                Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                CampoDataDoFormularioCadastroDePecas.Value.Date
            ));

            //CampoCategoriaDoFormularioCadastroDePecas.ResetText();
            //CampoNomeDoFormularioCadastroDePecas.ResetText();
            //CampoDescricaoDoFormularioCadastroDePecas.ResetText();
            //CampoEstoqueDoFormularioCadastroDePecas.ResetText();
            //CampoDataDoFormularioCadastroDePecas.ResetText();

        }

        int contadorDeId = 0;
        public int GerarIdParaPeca()
        {
            return contadorDeId++;
        }

        private void AoClicarFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
