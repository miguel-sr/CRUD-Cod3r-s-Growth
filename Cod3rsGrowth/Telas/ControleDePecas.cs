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
            CadastroDePeca cadastroDePeca = new CadastroDePeca(null);
            cadastroDePeca.ShowDialog();

            var novaPeca = cadastroDePeca.peca;

            repositorio.Criar(novaPeca);

            if (cadastroDePeca.DialogResult == DialogResult.Cancel) return;

        }

        private void AoClicarEmEditar(object sender, EventArgs e)
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

        private void AoClicarEmRemover(object sender, EventArgs e)
        {
            try
            {
                if (GridDePecas.SelectedRows.Count != 1)
                {
                    AvisoAoUsuario.ModalAviso("Selecione apenas uma peça!");
                    return;
                }

                var resultado = MessageBox.Show("Você tem certeza de que quer apagar esse registro?", "Aviso!", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    var indexDaLinhaSelecionada = GridDePecas.CurrentCell.RowIndex;
                    var pecaParaAtualizar = GridDePecas.Rows[indexDaLinhaSelecionada].DataBoundItem as Peca;

                    repositorio.Remover(pecaParaAtualizar.Id);
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao tentar remover peça.");
            }
        }

        private void AtualizarLista()
        {
            GridDePecas.DataSource = repositorio.ObterTodas();
        }
    }
}
