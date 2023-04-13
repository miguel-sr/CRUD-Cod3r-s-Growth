﻿using Cod3rsGrowth.Modelos;
using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            GridDePecas.DataSource = typeof(System.Collections.Generic.List<Peca>);
            GridDePecas.DataSource = Program.ListaDePecas;
        }

        private void GridDePecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
