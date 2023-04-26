using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Infra.Repositorio;
using Cod3rsGrowth.Servicos;

namespace Cod3rsGrowth
{
    public partial class ControleDePecas : Form
    {
        private readonly IRepositorio _repositorio;
        public ControleDePecas(IRepositorio repositorio)
        {
            InitializeComponent();

            _repositorio = repositorio;

            AtualizarLista();
        }

        private void AoClicarEmAdicionar(object sender, EventArgs e)
        {
            try
            {
                CadastroDePeca cadastroDePeca = new CadastroDePeca(null);
                cadastroDePeca.ShowDialog();

                var novaPeca = cadastroDePeca.peca;

                if (cadastroDePeca.DialogResult == DialogResult.OK)
                {
                    _repositorio.Criar(novaPeca);
                    AtualizarLista();
                }
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao criar peça. {erro}");
            }
        }

        private void AoClicarEmEditar(object sender, EventArgs e)
        {
            try
            {
                if (GridDePecas.SelectedRows.Count != 1)
                {
                    AvisoAoUsuario.ModalAviso("Selecione apenas uma peça!");
                    return;
                }

                var indexDaLinhaSelecionada = GridDePecas.CurrentCell.RowIndex;
                var pecaParaAtualizar = GridDePecas.Rows[indexDaLinhaSelecionada].DataBoundItem as Peca;

                CadastroDePeca cadastroDePeca = new CadastroDePeca(pecaParaAtualizar);
                cadastroDePeca.ShowDialog();

                _repositorio.Atualizar(pecaParaAtualizar.Id, cadastroDePeca.peca);
                AtualizarLista();
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao atualizar peça. {erro}");
            }
        }

        private void AoClicarEmRemover(object sender, EventArgs e)
        {
            try
            {
                if (GridDePecas.SelectedRows.Count != 1)
                {
                    AvisoAoUsuario.ModalAviso("Selecione apenas uma peça!");
                    return;
                }

                var resultado = AvisoAoUsuario.ModalConfirmarAcao("Você tem certeza de que quer apagar esse registro?");

                if (resultado == DialogResult.OK)
                {
                    var indexDaLinhaSelecionada = GridDePecas.CurrentCell.RowIndex;
                    var pecaParaRemover = GridDePecas.Rows[indexDaLinhaSelecionada].DataBoundItem as Peca;

                    _repositorio.Remover(pecaParaRemover.Id);
                    AtualizarLista();
                }
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao remover peça. {erro}");
            }
        }

        private void AtualizarLista()
        {
            GridDePecas.DataSource = _repositorio.ObterTodas();
        }
    }
}
