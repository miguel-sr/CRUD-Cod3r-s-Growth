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
        private Panel buttonPanel = new Panel();
        private Button addNewPartButton = new Button();
        private Button updatePartButton = new Button();
        private Button deletePartButton = new Button();

        public Form1()
        {
            InitializeComponent();
            SetupLayout();
            PopulateCategoriesDataGridView();
        }

        private void SetupDataGridView() 
        {
            this.Controls.Add(categoriesDataGridView);
            categoriesDataGridView.Name = "Lista de Peças";
            categoriesDataGridView.Size = new Size(Width, Height - 100);
            categoriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            categoriesDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            categoriesDataGridView.AllowUserToAddRows = false;
        }

        private void SetupLayout()
        {
            this.Size = new Size(600, 400);
            addNewPartButton.Text = "Adicionar";
            addNewPartButton.Location = new Point(10, 10);

            updatePartButton.Text = "Editar";
            updatePartButton.Location = new Point(100, 10);

            deletePartButton.Text = "Remover";
            deletePartButton.Location = new Point(190, 10);

            buttonPanel.Controls.Add(addNewPartButton);
            buttonPanel.Controls.Add(updatePartButton);
            buttonPanel.Controls.Add(deletePartButton);
            buttonPanel.Height = 50;
            buttonPanel.Width = Width;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);

            SetupDataGridView();
        }

        private void PopulateCategoriesDataGridView()
        {
            List<Part> parts = new List<Part>
            {
                new Part("1", "Parafusos", "Parafuso Sextavado", "Espessura 8mm", 30),
                new Part("2", "Parafusos", "Parafuso Sextavado", "Espessura 6mm", 15),
                new Part("3", "Porcas", "Porca Autotravante", "Espessura 8mm", 30),
                new Part("4", "Porcas", "Porca Autotravante", "Espessura 6mm", 15),
                new Part("5", "Porcas", "Porca Autotravante", "Espessura 3mm", 0)
            };
            categoriesDataGridView.DataSource = parts;

            categoriesDataGridView.Columns[0].HeaderText = "Código";
            categoriesDataGridView.Columns[1].HeaderText = "Categoria";
            categoriesDataGridView.Columns[2].HeaderText = "Nome";
            categoriesDataGridView.Columns[3].HeaderText = "Descrição";
            categoriesDataGridView.Columns[4].HeaderText = "Estoque";

            for (int i = 0; i < 5; i++)
            {
                categoriesDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
