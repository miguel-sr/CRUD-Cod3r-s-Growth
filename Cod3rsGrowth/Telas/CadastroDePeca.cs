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

            if (peca == null)
            {
                this.peca = new Peca();
            }
            else
            {
                this.peca = peca;

                Text = "Editar Peça";

                CampoCategoriaDoFormularioCadastroDePecas.Text = this.peca.Categoria;
                CampoNomeDoFormularioCadastroDePecas.Text = this.peca.Nome;
                CampoDescricaoDoFormularioCadastroDePecas.Text = this.peca.Descricao;
                CampoEstoqueDoFormularioCadastroDePecas.Text = this.peca.Estoque.ToString();
                CampoDataDoFormularioCadastroDePecas.Value = this.peca.DataDeFabricacao;
            }
   
            CampoDataDoFormularioCadastroDePecas.MaxDate = DateTime.Today;
        }

        private void AoClicarSalvarPeca_Click(object sender, EventArgs e)
        {
            try
            {
                List<Validacao.Campo> CamposParaValidar = new List<Validacao.Campo>
                {
                    new Validacao.Campo("nome", CampoNomeDoFormularioCadastroDePecas.Text, true, false),
                    new Validacao.Campo("estoque", CampoEstoqueDoFormularioCadastroDePecas.Text, true, true)
                };

                String erros = Validacao.CampoDeTexto(CamposParaValidar);

                if (erros != null)
                {
                    AvisoAoUsuario.MostrarAviso(erros);
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                peca.Id = peca.Id == 0 ? BancoDeDados.GerarIdParaPeca() : peca.Id;
                peca.Categoria = CampoCategoriaDoFormularioCadastroDePecas.Text;
                peca.Nome = CampoNomeDoFormularioCadastroDePecas.Text;
                peca.Descricao = CampoDescricaoDoFormularioCadastroDePecas.Text;
                peca.Estoque = Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text);
                peca.DataDeFabricacao = CampoDataDoFormularioCadastroDePecas.Value.Date;

                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
                throw new Exception("Erro ao tentar salvar peça.");
            }
        }

        private void AoClicarFecharJanela_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
