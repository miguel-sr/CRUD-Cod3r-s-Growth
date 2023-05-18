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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleDePecas));
            GridDePecas = new DataGridView();
            ColunaId = new DataGridViewTextBoxColumn();
            ColunaCategoria = new DataGridViewTextBoxColumn();
            ColunaNome = new DataGridViewTextBoxColumn();
            ColunaDescricao = new DataGridViewTextBoxColumn();
            ColunaEstoque = new DataGridViewTextBoxColumn();
            ColunaDataDeFabricacao = new DataGridViewTextBoxColumn();
            pecaBindingSource = new BindingSource(components);
            AoClicarRemoverPecaSelecionada = new Button();
            AoClicarTrocarParaMenuDeCriarPeca = new Button();
            AoClicarAbrirMenuDeEdicaoDePeca = new Button();
            ((System.ComponentModel.ISupportInitialize)GridDePecas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pecaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GridDePecas
            // 
            GridDePecas.AllowUserToAddRows = false;
            GridDePecas.AllowUserToDeleteRows = false;
            GridDePecas.AllowUserToResizeColumns = false;
            GridDePecas.AllowUserToResizeRows = false;
            GridDePecas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridDePecas.AutoGenerateColumns = false;
            GridDePecas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridDePecas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridDePecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDePecas.Columns.AddRange(new DataGridViewColumn[] { ColunaId, ColunaCategoria, ColunaNome, ColunaDescricao, ColunaEstoque, ColunaDataDeFabricacao });
            GridDePecas.DataSource = pecaBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            GridDePecas.DefaultCellStyle = dataGridViewCellStyle8;
            GridDePecas.Location = new Point(14, 14);
            GridDePecas.Margin = new Padding(4, 3, 4, 3);
            GridDePecas.Name = "GridDePecas";
            GridDePecas.ReadOnly = true;
            GridDePecas.Size = new Size(929, 400);
            GridDePecas.TabIndex = 0;
            // 
            // ColunaId
            // 
            ColunaId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColunaId.DefaultCellStyle = dataGridViewCellStyle2;
            ColunaId.FillWeight = 30F;
            ColunaId.HeaderText = "Código";
            ColunaId.Name = "ColunaId";
            ColunaId.ReadOnly = true;
            // 
            // ColunaCategoria
            // 
            ColunaCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaCategoria.DataPropertyName = "Categoria";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColunaCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            ColunaCategoria.HeaderText = "Categoria";
            ColunaCategoria.Name = "ColunaCategoria";
            ColunaCategoria.ReadOnly = true;
            // 
            // ColunaNome
            // 
            ColunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaNome.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColunaNome.DefaultCellStyle = dataGridViewCellStyle4;
            ColunaNome.HeaderText = "Nome";
            ColunaNome.Name = "ColunaNome";
            ColunaNome.ReadOnly = true;
            // 
            // ColunaDescricao
            // 
            ColunaDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColunaDescricao.DefaultCellStyle = dataGridViewCellStyle5;
            ColunaDescricao.HeaderText = "Descrição";
            ColunaDescricao.Name = "ColunaDescricao";
            ColunaDescricao.ReadOnly = true;
            // 
            // ColunaEstoque
            // 
            ColunaEstoque.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColunaEstoque.DefaultCellStyle = dataGridViewCellStyle6;
            ColunaEstoque.FillWeight = 30F;
            ColunaEstoque.HeaderText = "Estoque";
            ColunaEstoque.Name = "ColunaEstoque";
            ColunaEstoque.ReadOnly = true;
            // 
            // ColunaDataDeFabricacao
            // 
            ColunaDataDeFabricacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColunaDataDeFabricacao.DataPropertyName = "DataDeFabricacao";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColunaDataDeFabricacao.DefaultCellStyle = dataGridViewCellStyle7;
            ColunaDataDeFabricacao.HeaderText = "Data de Fabricação";
            ColunaDataDeFabricacao.Name = "ColunaDataDeFabricacao";
            ColunaDataDeFabricacao.ReadOnly = true;
            // 
            // pecaBindingSource
            // 
            pecaBindingSource.DataSource = typeof(Modelos.Peca);
            // 
            // AoClicarRemoverPecaSelecionada
            // 
            AoClicarRemoverPecaSelecionada.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AoClicarRemoverPecaSelecionada.Cursor = Cursors.Hand;
            AoClicarRemoverPecaSelecionada.Location = new Point(782, 434);
            AoClicarRemoverPecaSelecionada.Margin = new Padding(4, 3, 4, 3);
            AoClicarRemoverPecaSelecionada.Name = "AoClicarRemoverPecaSelecionada";
            AoClicarRemoverPecaSelecionada.Size = new Size(161, 43);
            AoClicarRemoverPecaSelecionada.TabIndex = 3;
            AoClicarRemoverPecaSelecionada.Text = "Remover";
            AoClicarRemoverPecaSelecionada.UseVisualStyleBackColor = true;
            AoClicarRemoverPecaSelecionada.Click += AoClicarEmRemover;
            // 
            // AoClicarTrocarParaMenuDeCriarPeca
            // 
            AoClicarTrocarParaMenuDeCriarPeca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AoClicarTrocarParaMenuDeCriarPeca.Cursor = Cursors.Hand;
            AoClicarTrocarParaMenuDeCriarPeca.Location = new Point(446, 434);
            AoClicarTrocarParaMenuDeCriarPeca.Margin = new Padding(4, 3, 4, 3);
            AoClicarTrocarParaMenuDeCriarPeca.Name = "AoClicarTrocarParaMenuDeCriarPeca";
            AoClicarTrocarParaMenuDeCriarPeca.Size = new Size(161, 43);
            AoClicarTrocarParaMenuDeCriarPeca.TabIndex = 4;
            AoClicarTrocarParaMenuDeCriarPeca.Text = "Adicionar";
            AoClicarTrocarParaMenuDeCriarPeca.UseVisualStyleBackColor = true;
            AoClicarTrocarParaMenuDeCriarPeca.Click += AoClicarEmAdicionar;
            // 
            // AoClicarAbrirMenuDeEdicaoDePeca
            // 
            AoClicarAbrirMenuDeEdicaoDePeca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AoClicarAbrirMenuDeEdicaoDePeca.Cursor = Cursors.Hand;
            AoClicarAbrirMenuDeEdicaoDePeca.Location = new Point(614, 434);
            AoClicarAbrirMenuDeEdicaoDePeca.Margin = new Padding(4, 3, 4, 3);
            AoClicarAbrirMenuDeEdicaoDePeca.Name = "AoClicarAbrirMenuDeEdicaoDePeca";
            AoClicarAbrirMenuDeEdicaoDePeca.Size = new Size(161, 43);
            AoClicarAbrirMenuDeEdicaoDePeca.TabIndex = 5;
            AoClicarAbrirMenuDeEdicaoDePeca.Text = "Editar";
            AoClicarAbrirMenuDeEdicaoDePeca.UseVisualStyleBackColor = true;
            AoClicarAbrirMenuDeEdicaoDePeca.Click += AoClicarEmEditar;
            // 
            // ControleDePecas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(962, 502);
            Controls.Add(AoClicarRemoverPecaSelecionada);
            Controls.Add(AoClicarAbrirMenuDeEdicaoDePeca);
            Controls.Add(GridDePecas);
            Controls.Add(AoClicarTrocarParaMenuDeCriarPeca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ControleDePecas";
            Text = "Controle de Peças";
            ((System.ComponentModel.ISupportInitialize)GridDePecas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pecaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button AoClicarRemoverPecaSelecionada;
        private System.Windows.Forms.Button AoClicarTrocarParaMenuDeCriarPeca;
        private System.Windows.Forms.Button AoClicarAbrirMenuDeEdicaoDePeca;
        private System.Windows.Forms.DataGridView GridDePecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDataDeFabricacao;
        private System.Windows.Forms.BindingSource pecaBindingSource;
    }
}

