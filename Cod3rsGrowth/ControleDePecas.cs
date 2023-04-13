
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
       
        private void PartsManager_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new List<Peca>
            {
                new Peca("Parafusos", "Parafuso Sextavado", "Espessura 8mm", 30),
                new Peca("Parafusos", "Parafuso Sextavado", "Espessura 6mm", 15),
                new Peca("Porcas", "Porca Autotravante", "Espessura 8mm", 30),
                new Peca("Porcas", "Porca Autotravante", "Espessura 6mm", 15),
                new Peca("Porcas", "Porca Autotravante", "Espessura 3mm", 0)
            };
        }

        private void ButtonToAddNewPart_Click(object sender, EventArgs e)
        {
            controleDePagina.SelectedTab = criarPeca;
        }

        private void NewPartScreenReturnButton_Click(object sender, EventArgs e)
        {
            controleDePagina.SelectedTab = listaDePecas;
        }
    }
}
