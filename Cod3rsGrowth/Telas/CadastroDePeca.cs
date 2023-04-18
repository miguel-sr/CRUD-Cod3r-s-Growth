using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class CadastroDePeca : Form
    {
        public readonly Peca peca;
        public CadastroDePeca(Peca peca)
        {
            InitializeComponent();
            this.peca = peca;

            if (!string.IsNullOrEmpty(peca.Nome))
            {
                Text = "Editar Peça";

                CampoCategoriaDoFormularioCadastroDePecas.Text = peca.Categoria;
                CampoNomeDoFormularioCadastroDePecas.Text = peca.Nome;
                CampoDescricaoDoFormularioCadastroDePecas.Text = peca.Descricao;
                CampoEstoqueDoFormularioCadastroDePecas.Text = peca.Estoque.ToString();
                CampoDataDoFormularioCadastroDePecas.Value = peca.DataDeFabricacao;
            }

            CampoDataDoFormularioCadastroDePecas.MaxDate = DateTime.Today;
        }

        private void AoClicarSalvarPeca_Click(object sender, EventArgs e)
        {

            List<Validacao.Campo> CamposParaValidar = new List<Validacao.Campo>
            {
                new Validacao.Campo("nome", CampoNomeDoFormularioCadastroDePecas.Text, true, false),
                new Validacao.Campo("estoque", CampoEstoqueDoFormularioCadastroDePecas.Text, true, true)
            };

            String erros = Validacao.CampoDeTexto(CamposParaValidar);

            if (erros != null)
            {
                MessageBox.Show(erros, "Aviso!");
                return;
            }

            peca.Id = string.IsNullOrEmpty(peca.Nome) ? BancoDeDados.GerarIdParaPeca() : this.peca.Id;
            peca.Categoria = CampoCategoriaDoFormularioCadastroDePecas.Text;
            peca.Nome = CampoNomeDoFormularioCadastroDePecas.Text;
            peca.Descricao = CampoDescricaoDoFormularioCadastroDePecas.Text;
            peca.Estoque = Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text);
            peca.DataDeFabricacao = CampoDataDoFormularioCadastroDePecas.Value.Date;

            Close();
        }

        private void AoClicarFecharJanela_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
