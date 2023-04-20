using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Cod3rsGrowth.Servicos.Validacao;

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

        private void AoClicarEmSalvar(object sender, EventArgs e)
        {
            try
            {
                List<Campo> CamposParaValidar = new List<Campo>
                {
                    new Campo("nome", CampoNomeDoFormularioCadastroDePecas.Text, true, false),
                    new Campo("estoque", CampoEstoqueDoFormularioCadastroDePecas.Text, true, true)
                };

                string erros = ValidarCampoDeTexto(CamposParaValidar);

                if (erros != null)
                {
                    AvisoAoUsuario.ModalAviso(erros);
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
            catch (Exception erro)
            {
                DialogResult = DialogResult.Cancel;
                throw new Exception($"Erro ao coletar dados do formulário. {erro}");
            }
        }

        private void AoClicarEmCancelar(object sender, EventArgs e)
        {
            Close();
        }
    }
}
