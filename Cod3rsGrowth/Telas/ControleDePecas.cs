using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.Diagnostics;
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

            int _id = Convert.ToInt32(GridDePecas.SelectedRows[default].Cells[0].Value);
            var pecaParaSerAtualizada = BancoDeDados.Instance().ListaDePecas.ToList().Find(x => x.Id == _id);

            CadastroDePeca cadastroDePeca = new CadastroDePeca(pecaParaSerAtualizada);
            cadastroDePeca.ShowDialog();

            pecaParaSerAtualizada = cadastroDePeca.peca;
            BancoDeDados.Instance().ListaDePecas[GridDePecas.SelectedRows[default].Index] = pecaParaSerAtualizada;
        }

        private void AoClicarRemoverPecaSelecionada_Click(object sender, EventArgs e)
        {
            if (GridDePecas.SelectedRows.Count != 1)
            {
                AvisoAoUsuario.MostrarAviso("Selecione apenas uma peça!");
                return;
            }

            var resultado = MessageBox.Show("Você tem certeza de que quer apagar esse registro?", "Aviso!", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                int _id = Convert.ToInt32(GridDePecas.SelectedRows[default].Cells[0].Value);
                var pecaParaRemover = BancoDeDados.Instance().ListaDePecas.ToList().Find(x => x.Id == _id);

                BancoDeDados.Instance().ListaDePecas.Remove(pecaParaRemover);
            }
        }

        private void AtualizarListaPecas()
        {
            GridDePecas.DataSource = BancoDeDados.Instance().ListaDePecas;
        }
    }
}
