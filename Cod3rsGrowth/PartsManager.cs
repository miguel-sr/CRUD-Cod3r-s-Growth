using Cod3rsGrowth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class PartsManager : Form
    {
        public PartsManager()
        {
            InitializeComponent();
        }
       
        private void PartsManager_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new List<Part>
            {
                new Part("1", "Parafusos", "Parafuso Sextavado", "Espessura 8mm", 30),
                new Part("2", "Parafusos", "Parafuso Sextavado", "Espessura 6mm", 15),
                new Part("3", "Porcas", "Porca Autotravante", "Espessura 8mm", 30),
                new Part("4", "Porcas", "Porca Autotravante", "Espessura 6mm", 15),
                new Part("5", "Porcas", "Porca Autotravante", "Espessura 3mm", 0)
            };
        }

        private void ButtonToAddNewPart_Click(object sender, EventArgs e)
        {
            pagesControl.SelectedTab = newPart;
        }

        private void NewPartScreenReturnButton_Click(object sender, EventArgs e)
        {
            pagesControl.SelectedTab = partsList;
        }
    }
}
