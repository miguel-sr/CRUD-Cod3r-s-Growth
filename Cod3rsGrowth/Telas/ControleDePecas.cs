using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Repositorio;
using Cod3rsGrowth.Servicos;
using System;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class ControleDePecas : Form
    {
        readonly RepositorioListaSingleton repositorio = new RepositorioListaSingleton();
        public ControleDePecas()
        {
            InitializeComponent();
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
                    repositorio.Criar(novaPeca);
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

                repositorio.Atualizar(pecaParaAtualizar.Id, cadastroDePeca.peca);
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
                    var pecaParaAtualizar = GridDePecas.Rows[indexDaLinhaSelecionada].DataBoundItem as Peca;

                    repositorio.Remover(pecaParaAtualizar.Id);
                }
            }
            catch (Exception erro)
            {
                throw new Exception($"Erro ao remover peça. {erro}");
            }
        }

        private void AtualizarLista()
        {
            GridDePecas.DataSource = repositorio.ObterTodas();
        }
    }
}
