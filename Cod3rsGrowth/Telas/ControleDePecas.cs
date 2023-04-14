using Cod3rsGrowth.Modelos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class ControleDePecas : Form
    {
        private readonly BindingList<Peca> ListaDePecas = new BindingList<Peca>();
        public ControleDePecas()
        {
            InitializeComponent();
        }

        private void ControleDePecas_Load(object sender, EventArgs e)
        {
            GridDePecas.DataSource = ListaDePecas;
        }

        private void AoClicarTrocarParaMenuDeCriarPeca_Click(object sender, EventArgs e)
        {
            // Ao atualizar usuário?
            CadastroDePeca cadastroDePeca = new CadastroDePeca(ListaDePecas);
            cadastroDePeca.ShowDialog();
        }

    }
}
