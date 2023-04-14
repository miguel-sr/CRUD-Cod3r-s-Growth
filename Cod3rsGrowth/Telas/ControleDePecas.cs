using Cod3rsGrowth.Modelos;
using System;
using System.ComponentModel;
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
            GridDePecas.DataSource = ListaDePecas;
        }

        private void AoClicarTrocarParaMenuDeCriarPeca_Click(object sender, EventArgs e)
        {
            CadastroDePeca cadastroDePeca = new CadastroDePeca(ListaDePecas);
            cadastroDePeca.ShowDialog();
        }

        private readonly BindingList<Peca> ListaDePecas = new BindingList<Peca>();
    }
}
