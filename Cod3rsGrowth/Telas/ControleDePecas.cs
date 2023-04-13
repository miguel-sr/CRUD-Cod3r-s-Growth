
using Cod3rsGrowth.Models;
using System;
using System.Collections.Generic;
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
            GridDePecas.DataSource = Program.ListaDePecas;
        }

        private void AoClicarTrocarParaMenuDeCriarPeca_Click(object sender, EventArgs e)
        {
            CadastroDePeca cadastroDePeca = new CadastroDePeca();
            cadastroDePeca.ShowDialog();
        }
    }
}
