
using Cod3rsGrowth.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class ControleDePecas : Form
    {
        public ControleDePecas()
        {
            InitializeComponent();
        }
       
        private void ControleDePecas_Load(object sender, EventArgs e)
        {
            if (ListaDePecas == null) {
                ListaDePecas = new List<Peca>
                {
                    new Peca(GerarIdParaPeca(), "Parafusos", "Parafuso Sextavado", "Espessura 8mm", 30, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Parafusos", "Parafuso Sextavado", "Espessura 6mm", 15, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Porcas", "Porca Autotravante", "Espessura 8mm", 30, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Porcas", "Porca Autotravante", "Espessura 6mm", 15, DateTime.Now.Date),
                    new Peca(GerarIdParaPeca(), "Porcas", "Porca Autotravante", "Espessura 3mm", 0, DateTime.Now.Date)
                };
            }

            this.GridDePecas.DataSource = ListaDePecas;
        }

        private List<Peca> ListaDePecas { get; set; }

        private void AoClicarTrocarParaMenuDeCriarPeca_Click(object sender, EventArgs e)
        {
            ControleDePagina.SelectedTab = paginaCadastroDePeca;
        }

        private void AoClicarRetornarParaPaginaListaDePecas_Click(object sender, EventArgs e)
        {
            ControleDePagina.SelectedTab = paginaListaDePecas;
        }

        private void AoClicarCriarNovaPeca_Click(object sender, EventArgs e)
        {
            ListaDePecas.Add(new Peca(
                GerarIdParaPeca(),
                this.CampoCategoriaDoFormularioCadastroDePecas.Text,
                this.CampoNomeDoFormularioCadastroDePecas.Text,
                this.CampoDescricaoDoFormularioCadastroDePecas.Text, 
                Convert.ToInt32(this.CampoEstoqueDoFormularioCadastroDePecas.Text),
                this.CampoDataDoFormularioCadastroDePecas.Value.Date
            ));

            GridDePecas.DataSource = null;
            GridDePecas.DataSource = ListaDePecas;
        }

        int contadorDeId = 0;
        private int GerarIdParaPeca()
        {
            return contadorDeId++;
        }

        private void AoClicarAbrirMenuDeEdicaoDePeca_Click(object sender, EventArgs e)
        {

        }

        private void AoClicarRemoverPecaSelecionada_Click(object sender, EventArgs e)
        {

        }
    }
}
