using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Serviços;
using System;
using System.ComponentModel;
using System.Diagnostics;
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
            GridDePecas.DataSource = Singleton.Instance().ListaDePecas;
        }

        private void AoClicarTrocarParaMenuDeCriarPeca_Click(object sender, EventArgs e)
        {
            CadastroDePeca cadastroDePeca = new CadastroDePeca();
            cadastroDePeca.ShowDialog();
        }

        private void AoClicarAbrirMenuDeEdicaoDePeca_Click(object sender, EventArgs e)
        {
            if (GridDePecas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione apenas uma peça!");
                return;
            }

            CadastroDePeca cadastroDePeca = new CadastroDePeca(GridDePecas.SelectedRows[0].Index);
            cadastroDePeca.ShowDialog();
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
                Singleton.Instance().ListaDePecas.RemoveAt(GridDePecas.SelectedRows[default].Index);
                MessageBox.Show("Registro apagado com sucesso.");
            }
        }
    }
}
