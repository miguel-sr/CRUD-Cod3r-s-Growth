using Cod3rsGrowth.Modelos;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class CadastroDePeca : Form
    {
        readonly BindingList<Peca> ListaDePecas;
        Peca peca;
        readonly int Index;
        public CadastroDePeca(BindingList<Peca> ListaDePecas, int Index = -1)
        {
            InitializeComponent();
            this.ListaDePecas = ListaDePecas;
            this.Index = Index;

            if (Index != -1)
            {

                this.Text = "Editar Peça";
                this.peca = ListaDePecas[Index];

                CampoCategoriaDoFormularioCadastroDePecas.Text = peca.Categoria;
                CampoNomeDoFormularioCadastroDePecas.Text = peca.Nome;
                CampoDescricaoDoFormularioCadastroDePecas.Text = peca.Descricao;
                CampoEstoqueDoFormularioCadastroDePecas.Text = peca.Estoque.ToString();
                CampoDataDoFormularioCadastroDePecas.Value = peca.DataDeFabricacao;
            }
        }

        private void AoClicarSalvarPeca_Click(object sender, EventArgs e)
        {
            if (Index == -1)
            {
                ListaDePecas.Add(new Peca(
                    GerarIdParaPeca(),
                    CampoCategoriaDoFormularioCadastroDePecas.Text,
                    CampoNomeDoFormularioCadastroDePecas.Text,
                    CampoDescricaoDoFormularioCadastroDePecas.Text,
                    Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                    CampoDataDoFormularioCadastroDePecas.Value.Date
                ));
            } else
            {
                ListaDePecas[Index] = new Peca(
                    peca.Id,
                    CampoCategoriaDoFormularioCadastroDePecas.Text,
                    CampoNomeDoFormularioCadastroDePecas.Text,
                    CampoDescricaoDoFormularioCadastroDePecas.Text,
                    Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                    CampoDataDoFormularioCadastroDePecas.Value.Date
                );
            }

            this.Close();
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
