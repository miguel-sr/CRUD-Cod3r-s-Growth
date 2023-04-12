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
            List<Part> parts = new List<Part>
            {
                new Part("1", "Parafusos", "Parafuso Sextavado", "Espessura 6mm", 30),
                new Part("2", "Parafusos", "Parafuso Sextavado", "Espessura 8mm", 15),
                new Part("3", "Porcas", "Porca Autotravante", "Espessura 6mm", 30),
                new Part("4", "Porcas", "Porca Autotravante", "Espessura 8mm", 15)
            };

            categoriesDataGridView.DataSource = parts;

            categoriesDataGridView.Columns[0].HeaderText = "#";
            categoriesDataGridView.Columns[1].HeaderText = "Categoria";
            categoriesDataGridView.Columns[2].HeaderText = "Nome";
            categoriesDataGridView.Columns[3].HeaderText = "Descrição";
            categoriesDataGridView.Columns[4].HeaderText = "Estoque";

            for (int i = 0; i < 5; i++)
            {
                categoriesDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            categoriesDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
