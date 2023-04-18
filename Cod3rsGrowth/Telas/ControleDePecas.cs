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
        }

        private void ControleDePecas_Load(object sender, EventArgs e)
        {
            GridDePecas.DataSource = BancoDeDados.Instance().ListaDePecas;
        }

        private void AoClicarTrocarParaMenuDeCriarPeca_Click(object sender, EventArgs e)
        {
            var novaPeca = new Peca(0, null, null, null, DateTime.Now);

            CadastroDePeca cadastroDePeca = new CadastroDePeca(novaPeca);
            cadastroDePeca.ShowDialog();

            novaPeca = cadastroDePeca.peca;

            if (!string.IsNullOrEmpty(novaPeca.Nome))
            {
                BancoDeDados.Instance().ListaDePecas.Add(novaPeca);
            }
        }

        private void AoClicarAbrirMenuDeEdicaoDePeca_Click(object sender, EventArgs e)
        {
            if (GridDePecas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione apenas uma peça!");
                return;
            }

            int _id = Convert.ToInt32(GridDePecas.SelectedRows[default].Cells[0].Value);
            var _pecaParaSerAtualizada = BancoDeDados.Instance().ListaDePecas.ToList().Find(x => x.Id == _id);

            CadastroDePeca cadastroDePeca = new CadastroDePeca(_pecaParaSerAtualizada);
            cadastroDePeca.ShowDialog();

            _pecaParaSerAtualizada = cadastroDePeca.peca;
            BancoDeDados.Instance().ListaDePecas[GridDePecas.SelectedRows[default].Index] = _pecaParaSerAtualizada;
        }

        private void AoClicarRemoverPecaSelecionada_Click(object sender, EventArgs e)
        {
            if (GridDePecas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione apenas uma peça!");
                return;
            }

            var resultado = MessageBox.Show("Você tem certeza de que quer apagar esse registro?", "Aviso!", MessageBoxButtons.OKCancel);
            
            if (resultado == DialogResult.OK)
            {
                int _id = Convert.ToInt32(GridDePecas.SelectedRows[default].Cells[0].Value);
                var _pecaParaSerApagada = BancoDeDados.Instance().ListaDePecas.ToList().Find(x => x.Id == _id);

                BancoDeDados.Instance().ListaDePecas.Remove(_pecaParaSerApagada);
            }
        }
    }
}
