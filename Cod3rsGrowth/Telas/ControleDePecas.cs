using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class ControleDePecas : Form
    {
        public ControleDePecas()
        {
            InitializeComponent();
            AtualizarListaPecas();
        }

        private void AoClicarTrocarParaMenuDeCriarPeca_Click(object sender, EventArgs e)
        {
            CadastroDePeca cadastroDePeca = new CadastroDePeca(null);
            cadastroDePeca.ShowDialog();

            var novaPeca = cadastroDePeca.peca;

            if (cadastroDePeca.DialogResult == DialogResult.Cancel) return;

            BancoDeDados.Instance().ListaDePecas.Add(novaPeca);
        }

        private void AoClicarAbrirMenuDeEdicaoDePeca_Click(object sender, EventArgs e)
        {
            if (GridDePecas.SelectedRows.Count != 1)
            {
                AvisoAoUsuario.MostrarAviso("Selecione apenas uma peça!");
                return;
            }
            
            var indexDaLinhaSelecionada = GridDePecas.CurrentCell.RowIndex;
            var pecaParaAtualizar = GridDePecas.Rows[indexDaLinhaSelecionada].DataBoundItem as Peca;

            CadastroDePeca cadastroDePeca = new CadastroDePeca(pecaParaAtualizar);
            cadastroDePeca.ShowDialog();

            pecaParaAtualizar = cadastroDePeca.peca;
            
            BancoDeDados.Instance().ListaDePecas[indexDaLinhaSelecionada] = pecaParaAtualizar;
        }

        private void AoClicarRemoverPecaSelecionada_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridDePecas.SelectedRows.Count != 1)
                {
                    AvisoAoUsuario.MostrarAviso("Selecione apenas uma peça!");
                    return;
                }

                var resultado = MessageBox.Show("Você tem certeza de que quer apagar esse registro?", "Aviso!", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    var indexDaLinhaSelecionada = GridDePecas.CurrentCell.RowIndex;

                    BancoDeDados.Instance().ListaDePecas.RemoveAt(indexDaLinhaSelecionada);
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao tentar remover peça.");
            }
        }

        private void AtualizarListaPecas()
        {
            GridDePecas.DataSource = BancoDeDados.Instance().ListaDePecas;
        }
    }
}
