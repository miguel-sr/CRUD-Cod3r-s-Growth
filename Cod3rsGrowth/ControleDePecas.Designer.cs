namespace Cod3rsGrowth
{
    partial class ControleDePecas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridDePecas = new System.Windows.Forms.DataGridView();
            this.ColunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDataDeFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aoClicarRemoverPecaSelecionada = new System.Windows.Forms.Button();
            this.aoClicarTrocarParaMenuDeCriarPeca = new System.Windows.Forms.Button();
            this.aoClicarAbrirMenuDeEdicaoDePeca = new System.Windows.Forms.Button();
            this.ControleDePagina = new System.Windows.Forms.TabControl();
            this.paginaListaDePecas = new System.Windows.Forms.TabPage();
            this.paginaCadastroDePeca = new System.Windows.Forms.TabPage();
            this.CampoDataDoFormularioCadastroDePecas = new System.Windows.Forms.DateTimePicker();
            this.CampoEstoqueDoFormularioCadastroDePecas = new System.Windows.Forms.TextBox();
            this.LabelCalendario = new System.Windows.Forms.Label();
            this.CampoDescricaoDoFormularioCadastroDePecas = new System.Windows.Forms.TextBox();
            this.LabelDescricao = new System.Windows.Forms.Label();
            this.LabelEstoque = new System.Windows.Forms.Label();
            this.CampoNomeDoFormularioCadastroDePecas = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.CampoCategoriaDoFormularioCadastroDePecas = new System.Windows.Forms.TextBox();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.aoClicarRetornarParaPaginaListaDePecas = new System.Windows.Forms.Button();
            this.aoClicarCriarNovaPeca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDePecas)).BeginInit();
            this.ControleDePagina.SuspendLayout();
            this.paginaListaDePecas.SuspendLayout();
            this.paginaCadastroDePeca.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDePecas
            // 
            this.GridDePecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDePecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaId,
            this.ColunaCategoria,
            this.ColunaNome,
            this.ColunaDescricao,
            this.ColunaDataDeFabricacao,
            this.ColunaEstoque});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDePecas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridDePecas.Location = new System.Drawing.Point(8, 6);
            this.GridDePecas.Name = "gridDePecas";
            this.GridDePecas.Size = new System.Drawing.Size(795, 347);
            this.GridDePecas.TabIndex = 0;
            // 
            // ColunaId
            // 
            this.ColunaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaId.DataPropertyName = "Id";
            this.ColunaId.FillWeight = 30F;
            this.ColunaId.HeaderText = "Código";
            this.ColunaId.Name = "ColunaId";
            this.ColunaId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColunaCategoria
            // 
            this.ColunaCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaCategoria.DataPropertyName = "Categoria";
            this.ColunaCategoria.FillWeight = 40F;
            this.ColunaCategoria.HeaderText = "Categoria";
            this.ColunaCategoria.Name = "ColunaCategoria";
            this.ColunaCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColunaNome
            // 
            this.ColunaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaNome.DataPropertyName = "Nome";
            this.ColunaNome.FillWeight = 80F;
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            // 
            // ColunaDescricao
            // 
            this.ColunaDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaDescricao.DataPropertyName = "Descricao";
            this.ColunaDescricao.HeaderText = "Descrição";
            this.ColunaDescricao.Name = "ColunaDescricao";
            // 
            // ColunaDataDeFabricacao
            // 
            this.ColunaDataDeFabricacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaDataDeFabricacao.DataPropertyName = "DataDeFabricacao";
            this.ColunaDataDeFabricacao.HeaderText = "Data de Fabricação";
            this.ColunaDataDeFabricacao.Name = "ColunaDataDeFabricacao";
            // 
            // ColunaEstoque
            // 
            this.ColunaEstoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaEstoque.DataPropertyName = "Estoque";
            this.ColunaEstoque.FillWeight = 30F;
            this.ColunaEstoque.HeaderText = "Estoque";
            this.ColunaEstoque.Name = "ColunaEstoque";
            this.ColunaEstoque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // aoClicarRemoverPecaSelecionada
            // 
            this.aoClicarRemoverPecaSelecionada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarRemoverPecaSelecionada.Location = new System.Drawing.Point(665, 359);
            this.aoClicarRemoverPecaSelecionada.Name = "aoClicarRemoverPecaSelecionada";
            this.aoClicarRemoverPecaSelecionada.Size = new System.Drawing.Size(138, 37);
            this.aoClicarRemoverPecaSelecionada.TabIndex = 3;
            this.aoClicarRemoverPecaSelecionada.Text = "Remover";
            this.aoClicarRemoverPecaSelecionada.UseVisualStyleBackColor = true;
            this.aoClicarRemoverPecaSelecionada.Click += new System.EventHandler(this.AoClicarRemoverPecaSelecionada_Click);
            // 
            // aoClicarTrocarParaMenuDeCriarPeca
            // 
            this.aoClicarTrocarParaMenuDeCriarPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarTrocarParaMenuDeCriarPeca.Location = new System.Drawing.Point(377, 359);
            this.aoClicarTrocarParaMenuDeCriarPeca.Name = "aoClicarTrocarParaMenuDeCriarPeca";
            this.aoClicarTrocarParaMenuDeCriarPeca.Size = new System.Drawing.Size(138, 37);
            this.aoClicarTrocarParaMenuDeCriarPeca.TabIndex = 4;
            this.aoClicarTrocarParaMenuDeCriarPeca.Text = "Adicionar";
            this.aoClicarTrocarParaMenuDeCriarPeca.UseVisualStyleBackColor = true;
            this.aoClicarTrocarParaMenuDeCriarPeca.Click += new System.EventHandler(this.AoClicarTrocarParaMenuDeCriarPeca_Click);
            // 
            // aoClicarAbrirMenuDeEdicaoDePeca
            // 
            this.aoClicarAbrirMenuDeEdicaoDePeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarAbrirMenuDeEdicaoDePeca.Location = new System.Drawing.Point(521, 359);
            this.aoClicarAbrirMenuDeEdicaoDePeca.Name = "aoClicarAbrirMenuDeEdicaoDePeca";
            this.aoClicarAbrirMenuDeEdicaoDePeca.Size = new System.Drawing.Size(138, 37);
            this.aoClicarAbrirMenuDeEdicaoDePeca.TabIndex = 5;
            this.aoClicarAbrirMenuDeEdicaoDePeca.Text = "Editar";
            this.aoClicarAbrirMenuDeEdicaoDePeca.UseVisualStyleBackColor = true;
            this.aoClicarAbrirMenuDeEdicaoDePeca.Click += new System.EventHandler(this.AoClicarAbrirMenuDeEdicaoDePeca_Click);
            // 
            // controleDePagina
            // 
            this.ControleDePagina.Controls.Add(this.paginaListaDePecas);
            this.ControleDePagina.Controls.Add(this.paginaCadastroDePeca);
            this.ControleDePagina.Location = new System.Drawing.Point(0, 0);
            this.ControleDePagina.Name = "controleDePagina";
            this.ControleDePagina.SelectedIndex = 0;
            this.ControleDePagina.Size = new System.Drawing.Size(817, 428);
            this.ControleDePagina.TabIndex = 6;
            // 
            // paginaListaDePecas
            // 
            this.paginaListaDePecas.Controls.Add(this.GridDePecas);
            this.paginaListaDePecas.Controls.Add(this.aoClicarRemoverPecaSelecionada);
            this.paginaListaDePecas.Controls.Add(this.aoClicarAbrirMenuDeEdicaoDePeca);
            this.paginaListaDePecas.Controls.Add(this.aoClicarTrocarParaMenuDeCriarPeca);
            this.paginaListaDePecas.Location = new System.Drawing.Point(4, 22);
            this.paginaListaDePecas.Name = "paginaListaDePecas";
            this.paginaListaDePecas.Padding = new System.Windows.Forms.Padding(3);
            this.paginaListaDePecas.Size = new System.Drawing.Size(809, 402);
            this.paginaListaDePecas.TabIndex = 0;
            this.paginaListaDePecas.Text = "Lista de Peças";
            this.paginaListaDePecas.UseVisualStyleBackColor = true;
            // 
            // paginaCadastroDePeca
            // 
            this.paginaCadastroDePeca.Controls.Add(this.CampoDataDoFormularioCadastroDePecas);
            this.paginaCadastroDePeca.Controls.Add(this.CampoEstoqueDoFormularioCadastroDePecas);
            this.paginaCadastroDePeca.Controls.Add(this.LabelCalendario);
            this.paginaCadastroDePeca.Controls.Add(this.CampoDescricaoDoFormularioCadastroDePecas);
            this.paginaCadastroDePeca.Controls.Add(this.LabelDescricao);
            this.paginaCadastroDePeca.Controls.Add(this.LabelEstoque);
            this.paginaCadastroDePeca.Controls.Add(this.CampoNomeDoFormularioCadastroDePecas);
            this.paginaCadastroDePeca.Controls.Add(this.LabelNome);
            this.paginaCadastroDePeca.Controls.Add(this.CampoCategoriaDoFormularioCadastroDePecas);
            this.paginaCadastroDePeca.Controls.Add(this.LabelCategoria);
            this.paginaCadastroDePeca.Controls.Add(this.aoClicarRetornarParaPaginaListaDePecas);
            this.paginaCadastroDePeca.Controls.Add(this.aoClicarCriarNovaPeca);
            this.paginaCadastroDePeca.Location = new System.Drawing.Point(4, 22);
            this.paginaCadastroDePeca.Name = "paginaCadastroDePeca";
            this.paginaCadastroDePeca.Padding = new System.Windows.Forms.Padding(3);
            this.paginaCadastroDePeca.Size = new System.Drawing.Size(809, 402);
            this.paginaCadastroDePeca.TabIndex = 1;
            this.paginaCadastroDePeca.Text = "Cadastro de Peças";
            this.paginaCadastroDePeca.UseVisualStyleBackColor = true;
            // 
            // CampoDataDoFormularioCadastroDePecas
            // 
            this.CampoDataDoFormularioCadastroDePecas.CustomFormat = "dd/MM/yyyy";
            this.CampoDataDoFormularioCadastroDePecas.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.CampoDataDoFormularioCadastroDePecas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CampoDataDoFormularioCadastroDePecas.Location = new System.Drawing.Point(242, 40);
            this.CampoDataDoFormularioCadastroDePecas.Name = "CampoDataDoFormularioCadastroDePecas";
            this.CampoDataDoFormularioCadastroDePecas.Size = new System.Drawing.Size(185, 20);
            this.CampoDataDoFormularioCadastroDePecas.TabIndex = 18;
            // 
            // CampoEstoqueDoFormularioCadastroDePecas
            // 
            this.CampoEstoqueDoFormularioCadastroDePecas.Location = new System.Drawing.Point(242, 95);
            this.CampoEstoqueDoFormularioCadastroDePecas.Name = "CampoEstoqueDoFormularioCadastroDePecas";
            this.CampoEstoqueDoFormularioCadastroDePecas.Size = new System.Drawing.Size(185, 20);
            this.CampoEstoqueDoFormularioCadastroDePecas.TabIndex = 17;
            // 
            // LabelCalendario
            // 
            this.LabelCalendario.AutoSize = true;
            this.LabelCalendario.Location = new System.Drawing.Point(239, 24);
            this.LabelCalendario.Name = "LabelCalendario";
            this.LabelCalendario.Size = new System.Drawing.Size(101, 13);
            this.LabelCalendario.TabIndex = 15;
            this.LabelCalendario.Text = "Data de Fabricação";
            // 
            // CampoDescricaoDoFormularioCadastroDePecas
            // 
            this.CampoDescricaoDoFormularioCadastroDePecas.Location = new System.Drawing.Point(36, 150);
            this.CampoDescricaoDoFormularioCadastroDePecas.Multiline = true;
            this.CampoDescricaoDoFormularioCadastroDePecas.Name = "CampoDescricaoDoFormularioCadastroDePecas";
            this.CampoDescricaoDoFormularioCadastroDePecas.Size = new System.Drawing.Size(185, 74);
            this.CampoDescricaoDoFormularioCadastroDePecas.TabIndex = 14;
            // 
            // LabelDescricao
            // 
            this.LabelDescricao.AutoSize = true;
            this.LabelDescricao.Location = new System.Drawing.Point(33, 134);
            this.LabelDescricao.Name = "LabelDescricao";
            this.LabelDescricao.Size = new System.Drawing.Size(55, 13);
            this.LabelDescricao.TabIndex = 13;
            this.LabelDescricao.Text = "Descrição";
            // 
            // LabelEstoque
            // 
            this.LabelEstoque.AutoSize = true;
            this.LabelEstoque.Location = new System.Drawing.Point(239, 79);
            this.LabelEstoque.Name = "LabelEstoque";
            this.LabelEstoque.Size = new System.Drawing.Size(46, 13);
            this.LabelEstoque.TabIndex = 11;
            this.LabelEstoque.Text = "Estoque";
            // 
            // CampoNomeDoFormularioCadastroDePecas
            // 
            this.CampoNomeDoFormularioCadastroDePecas.Location = new System.Drawing.Point(36, 95);
            this.CampoNomeDoFormularioCadastroDePecas.Name = "CampoNomeDoFormularioCadastroDePecas";
            this.CampoNomeDoFormularioCadastroDePecas.Size = new System.Drawing.Size(185, 20);
            this.CampoNomeDoFormularioCadastroDePecas.TabIndex = 10;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(33, 79);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(35, 13);
            this.LabelNome.TabIndex = 9;
            this.LabelNome.Text = "Nome";
            // 
            // CampoCategoriaDoFormularioCadastroDePecas
            // 
            this.CampoCategoriaDoFormularioCadastroDePecas.Location = new System.Drawing.Point(36, 40);
            this.CampoCategoriaDoFormularioCadastroDePecas.Name = "CampoCategoriaDoFormularioCadastroDePecas";
            this.CampoCategoriaDoFormularioCadastroDePecas.Size = new System.Drawing.Size(185, 20);
            this.CampoCategoriaDoFormularioCadastroDePecas.TabIndex = 8;
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Location = new System.Drawing.Point(33, 24);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(52, 13);
            this.LabelCategoria.TabIndex = 7;
            this.LabelCategoria.Text = "Categoria";
            // 
            // aoClicarRetornarParaPaginaListaDePecas
            // 
            this.aoClicarRetornarParaPaginaListaDePecas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarRetornarParaPaginaListaDePecas.Location = new System.Drawing.Point(625, 359);
            this.aoClicarRetornarParaPaginaListaDePecas.Name = "aoClicarRetornarParaPaginaListaDePecas";
            this.aoClicarRetornarParaPaginaListaDePecas.Size = new System.Drawing.Size(138, 37);
            this.aoClicarRetornarParaPaginaListaDePecas.TabIndex = 6;
            this.aoClicarRetornarParaPaginaListaDePecas.Text = "Cancelar";
            this.aoClicarRetornarParaPaginaListaDePecas.UseVisualStyleBackColor = true;
            this.aoClicarRetornarParaPaginaListaDePecas.Click += new System.EventHandler(this.AoClicarRetornarParaPaginaListaDePecas_Click);
            // 
            // aoClicarCriarNovaPeca
            // 
            this.aoClicarCriarNovaPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarCriarNovaPeca.Location = new System.Drawing.Point(481, 359);
            this.aoClicarCriarNovaPeca.Name = "aoClicarCriarNovaPeca";
            this.aoClicarCriarNovaPeca.Size = new System.Drawing.Size(138, 37);
            this.aoClicarCriarNovaPeca.TabIndex = 5;
            this.aoClicarCriarNovaPeca.Text = "Criar";
            this.aoClicarCriarNovaPeca.UseVisualStyleBackColor = true;
            this.aoClicarCriarNovaPeca.Click += new System.EventHandler(this.AoClicarCriarNovaPeca_Click);
            // 
            // ControleDePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 435);
            this.Controls.Add(this.ControleDePagina);
            this.Name = "ControleDePecas";
            this.Text = "Controle de Peças";
            this.Load += new System.EventHandler(this.ControleDePecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDePecas)).EndInit();
            this.ControleDePagina.ResumeLayout(false);
            this.paginaListaDePecas.ResumeLayout(false);
            this.paginaCadastroDePeca.ResumeLayout(false);
            this.paginaCadastroDePeca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDePecas;
        private System.Windows.Forms.Button aoClicarRemoverPecaSelecionada;
        private System.Windows.Forms.Button aoClicarTrocarParaMenuDeCriarPeca;
        private System.Windows.Forms.Button aoClicarAbrirMenuDeEdicaoDePeca;
        private System.Windows.Forms.TabControl ControleDePagina;
        private System.Windows.Forms.TabPage paginaListaDePecas;
        private System.Windows.Forms.TabPage paginaCadastroDePeca;
        private System.Windows.Forms.Button aoClicarRetornarParaPaginaListaDePecas;
        private System.Windows.Forms.Button aoClicarCriarNovaPeca;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.TextBox CampoDescricaoDoFormularioCadastroDePecas;
        private System.Windows.Forms.Label LabelDescricao;
        private System.Windows.Forms.Label LabelEstoque;
        private System.Windows.Forms.TextBox CampoNomeDoFormularioCadastroDePecas;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.TextBox CampoCategoriaDoFormularioCadastroDePecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDataDeFabricacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEstoque;
        private System.Windows.Forms.Label LabelCalendario;
        private System.Windows.Forms.TextBox CampoEstoqueDoFormularioCadastroDePecas;
        private System.Windows.Forms.DateTimePicker CampoDataDoFormularioCadastroDePecas;
    }
}

