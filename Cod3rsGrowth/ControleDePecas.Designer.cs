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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDataDeFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aoClicarRemoverPecaSelecionada = new System.Windows.Forms.Button();
            this.aoClicarTrocarParaMenuDeCriarPeca = new System.Windows.Forms.Button();
            this.aoClicarAbrirMenuDeEdicaoDePeca = new System.Windows.Forms.Button();
            this.controleDePagina = new System.Windows.Forms.TabControl();
            this.listaDePecas = new System.Windows.Forms.TabPage();
            this.criarPeca = new System.Windows.Forms.TabPage();
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
            this.NewPartScreenReturnButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controleDePagina.SuspendLayout();
            this.listaDePecas.SuspendLayout();
            this.criarPeca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 347);
            this.dataGridView1.TabIndex = 0;
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
            this.aoClicarTrocarParaMenuDeCriarPeca.Click += new System.EventHandler(this.ButtonToAddNewPart_Click);
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
            // 
            // controleDePagina
            // 
            this.controleDePagina.Controls.Add(this.listaDePecas);
            this.controleDePagina.Controls.Add(this.criarPeca);
            this.controleDePagina.Location = new System.Drawing.Point(0, 0);
            this.controleDePagina.Name = "controleDePagina";
            this.controleDePagina.SelectedIndex = 0;
            this.controleDePagina.Size = new System.Drawing.Size(817, 428);
            this.controleDePagina.TabIndex = 6;
            // 
            // listaDePecas
            // 
            this.listaDePecas.Controls.Add(this.dataGridView1);
            this.listaDePecas.Controls.Add(this.aoClicarRemoverPecaSelecionada);
            this.listaDePecas.Controls.Add(this.aoClicarAbrirMenuDeEdicaoDePeca);
            this.listaDePecas.Controls.Add(this.aoClicarTrocarParaMenuDeCriarPeca);
            this.listaDePecas.Location = new System.Drawing.Point(4, 22);
            this.listaDePecas.Name = "listaDePecas";
            this.listaDePecas.Padding = new System.Windows.Forms.Padding(3);
            this.listaDePecas.Size = new System.Drawing.Size(809, 402);
            this.listaDePecas.TabIndex = 0;
            this.listaDePecas.Text = "Lista de Peças";
            this.listaDePecas.UseVisualStyleBackColor = true;
            // 
            // criarPeca
            // 
            this.criarPeca.Controls.Add(this.CampoDataDoFormularioCadastroDePecas);
            this.criarPeca.Controls.Add(this.CampoEstoqueDoFormularioCadastroDePecas);
            this.criarPeca.Controls.Add(this.LabelCalendario);
            this.criarPeca.Controls.Add(this.CampoDescricaoDoFormularioCadastroDePecas);
            this.criarPeca.Controls.Add(this.LabelDescricao);
            this.criarPeca.Controls.Add(this.LabelEstoque);
            this.criarPeca.Controls.Add(this.CampoNomeDoFormularioCadastroDePecas);
            this.criarPeca.Controls.Add(this.LabelNome);
            this.criarPeca.Controls.Add(this.CampoCategoriaDoFormularioCadastroDePecas);
            this.criarPeca.Controls.Add(this.LabelCategoria);
            this.criarPeca.Controls.Add(this.NewPartScreenReturnButton);
            this.criarPeca.Controls.Add(this.button1);
            this.criarPeca.Location = new System.Drawing.Point(4, 22);
            this.criarPeca.Name = "criarPeca";
            this.criarPeca.Padding = new System.Windows.Forms.Padding(3);
            this.criarPeca.Size = new System.Drawing.Size(809, 402);
            this.criarPeca.TabIndex = 1;
            this.criarPeca.Text = "Cadastro de Peças";
            this.criarPeca.UseVisualStyleBackColor = true;
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
            // NewPartScreenReturnButton
            // 
            this.NewPartScreenReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewPartScreenReturnButton.Location = new System.Drawing.Point(625, 359);
            this.NewPartScreenReturnButton.Name = "NewPartScreenReturnButton";
            this.NewPartScreenReturnButton.Size = new System.Drawing.Size(138, 37);
            this.NewPartScreenReturnButton.TabIndex = 6;
            this.NewPartScreenReturnButton.Text = "Cancelar";
            this.NewPartScreenReturnButton.UseVisualStyleBackColor = true;
            this.NewPartScreenReturnButton.Click += new System.EventHandler(this.NewPartScreenReturnButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(481, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ControleDePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 435);
            this.Controls.Add(this.controleDePagina);
            this.Name = "ControleDePecas";
            this.Text = "Controle de Peças";
            this.Load += new System.EventHandler(this.PartsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controleDePagina.ResumeLayout(false);
            this.listaDePecas.ResumeLayout(false);
            this.criarPeca.ResumeLayout(false);
            this.criarPeca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button aoClicarRemoverPecaSelecionada;
        private System.Windows.Forms.Button aoClicarTrocarParaMenuDeCriarPeca;
        private System.Windows.Forms.Button aoClicarAbrirMenuDeEdicaoDePeca;
        private System.Windows.Forms.TabControl controleDePagina;
        private System.Windows.Forms.TabPage listaDePecas;
        private System.Windows.Forms.TabPage criarPeca;
        private System.Windows.Forms.Button NewPartScreenReturnButton;
        private System.Windows.Forms.Button button1;
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

