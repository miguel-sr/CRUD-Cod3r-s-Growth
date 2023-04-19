using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class ControleDePecas : Form
    {
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

            if (cadastroDePeca.DialogResult == DialogResult.Cancel) return;

            BancoDeDados.Instancia().ListaDePecas.Add(novaPeca);
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

            pecaParaAtualizar = cadastroDePeca.peca;
            
            BancoDeDados.Instancia().ListaDePecas[indexDaLinhaSelecionada] = pecaParaAtualizar;
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
                    var pecaParaRemover = GridDePecas.Rows[indexDaLinhaSelecionada].DataBoundItem as Peca;

                    BancoDeDados.Instancia().ListaDePecas.Remove(pecaParaRemover);
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao tentar remover peça.");
            }
        }

        private void AtualizarLista()
        {
            GridDePecas.DataSource = BancoDeDados.Instancia().ListaDePecas;
        }
    }
}
