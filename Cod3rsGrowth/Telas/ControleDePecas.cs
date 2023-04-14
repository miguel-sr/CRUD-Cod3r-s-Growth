﻿using Cod3rsGrowth.Modelos;
using System;
using System.ComponentModel;
using System.Diagnostics;
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
            CadastroDePeca cadastroDePeca = new CadastroDePeca(ListaDePecas);
            cadastroDePeca.ShowDialog();
        }

        private void AoClicarAbrirMenuDeEdicaoDePeca_Click(object sender, EventArgs e)
        {
            if (GridDePecas.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas uma peça!");
                return;
            }

            CadastroDePeca cadastroDePeca = new CadastroDePeca(ListaDePecas, Convert.ToInt32(GridDePecas.SelectedRows[0].Index));
            cadastroDePeca.ShowDialog();
        }
    }
}