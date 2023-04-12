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
    public partial class Form1 : Form
    {
        private DataGridView categoriesDataGridView = new DataGridView();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView() 
        {
            this.Controls.Add(categoriesDataGridView);
            categoriesDataGridView.Name = "Lista de Peças";
            categoriesDataGridView.Size = new Size(600, 150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Part> parts = new List<Part>();
            parts.Add(new Part("1", "Parafusos", "Parafuso Sextavado", "Espessura 6mm", 30));
            parts.Add(new Part("2", "Parafusos", "Parafuso Sextavado", "Espessura 8mm", 15));
            parts.Add(new Part("3", "Porcas", "Porca Autotravante", "Espessura 6mm", 30));
            parts.Add(new Part("4", "Porcas", "Porca Autotravante", "Espessura 8mm", 15));
            categoriesDataGridView.DataSource = parts;



        }
    }
}
