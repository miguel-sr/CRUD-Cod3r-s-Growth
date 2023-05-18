using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
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
                peca.Categoria = CampoCategoriaDoFormularioCadastroDePecas.Text;
                peca.Nome = CampoNomeDoFormularioCadastroDePecas.Text;
                peca.Descricao = CampoDescricaoDoFormularioCadastroDePecas.Text;
                peca.Estoque = CampoEstoqueDoFormularioCadastroDePecas.Text;
                peca.DataDeFabricacao = CampoDataDoFormularioCadastroDePecas.Value.Date;

                string erros = ValidarPeca(peca);

                if (!string.IsNullOrEmpty(erros))
                {
                    throw new Exception(erros);
                }

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
