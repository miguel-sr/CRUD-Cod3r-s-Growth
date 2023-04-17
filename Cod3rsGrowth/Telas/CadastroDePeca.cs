﻿using Cod3rsGrowth.Modelos;
using Cod3rsGrowth.Servicos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cod3rsGrowth
{
    public partial class CadastroDePeca : Form
    {
        readonly int _index;
        public CadastroDePeca(int index = -1)
        {
            InitializeComponent();
            _index = index;

            if (_index != -1)
            {
                Text = "Editar Peça";
                var peca = BancoDeDados.Instance().ListaDePecas[_index] as Peca;

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

            if (_index == -1)
            {
                var pecaParaAdicionar = new Peca(
                    BancoDeDados.GerarIdParaPeca(),
                    CampoCategoriaDoFormularioCadastroDePecas.Text,
                    CampoNomeDoFormularioCadastroDePecas.Text,
                    CampoDescricaoDoFormularioCadastroDePecas.Text,
                    Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                    CampoDataDoFormularioCadastroDePecas.Value.Date
                );

                BancoDeDados.Instance().ListaDePecas.Add(pecaParaAdicionar);
                this.Close();
                return;
            }

            BancoDeDados.Instance().ListaDePecas[_index] = new Peca(
                BancoDeDados.Instance().ListaDePecas[_index].Id,
                CampoCategoriaDoFormularioCadastroDePecas.Text,
                CampoNomeDoFormularioCadastroDePecas.Text,
                CampoDescricaoDoFormularioCadastroDePecas.Text,
                Convert.ToInt32(CampoEstoqueDoFormularioCadastroDePecas.Text),
                CampoDataDoFormularioCadastroDePecas.Value.Date
            );

            this.Close();
        }

        private void AoClicarFecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
