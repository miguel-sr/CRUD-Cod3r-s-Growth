﻿using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class CadastroDePeca : Form
    {
        readonly BindingList<Peca> ListaDePecas;
        readonly int Index;
        public CadastroDePeca(BindingList<Peca> listaDePecas, int index = -1)
        {
            InitializeComponent();
            ListaDePecas = listaDePecas;
            Index = index;

            if (Index != -1)
            {
                Text = "Editar Peça";
                var peca = ListaDePecas[Index] as Peca;

                CampoCategoriaDoFormularioCadastroDePecas.Text = peca.Categoria;
                CampoNomeDoFormularioCadastroDePecas.Text = peca.Nome;
                CampoDescricaoDoFormularioCadastroDePecas.Text = peca.Descricao;
                CampoEstoqueDoFormularioCadastroDePecas.Text = peca.Estoque.ToString();
                CampoDataDoFormularioCadastroDePecas.Value = peca.DataDeFabricacao;
            }

            CampoDataDoFormularioCadastroDePecas.MaxDate = DateTime.Today;
        }

        private void AoClicarSalvarPeca_Click(object sender, EventArgs e)
        {

            List<Validacao.Campo> CamposParaValidar = new List<Validacao.Campo>
            {
                new Validacao.Campo("nome", CampoNomeDoFormularioCadastroDePecas.Text, true, false),
                new Validacao.Campo("estoque", CampoEstoqueDoFormularioCadastroDePecas.Text, true, true)
            };

            String erros = Validacao.CampoDeTexto(CamposParaValidar);

            if (erros != null)
            {
                MessageBox.Show(erros, "Aviso!");
                return;
            }

            if (Index == -1)
            {
                ListaDePecas.Add(new Peca(
                    GerarIdParaPeca(),
                    CampoCategoriaDoFormularioCadastroDePecas.Text,
                    CampoNomeDoFormularioCadastroDePecas.Text,
                    CampoDescricaoDoFormularioCadastroDePecas.Text,
                    Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                    CampoDataDoFormularioCadastroDePecas.Value.Date
                ));
            }
            else
            {
                ListaDePecas[Index] = new Peca(
                    ListaDePecas[Index].Id,
                    CampoCategoriaDoFormularioCadastroDePecas.Text,
                    CampoNomeDoFormularioCadastroDePecas.Text,
                    CampoDescricaoDoFormularioCadastroDePecas.Text,
                    Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                    CampoDataDoFormularioCadastroDePecas.Value.Date
                );
            }

            this.Close();
        }

        private void AoClicarFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static int contadorDeId = 0;
        public static int GerarIdParaPeca()
        {
            return ++contadorDeId;
        }
    }
}
