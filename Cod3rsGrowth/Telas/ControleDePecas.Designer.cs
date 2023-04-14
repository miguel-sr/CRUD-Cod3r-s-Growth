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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridDePecas = new System.Windows.Forms.DataGridView();
            this.ColunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDataDeFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pecaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AoClicarRemoverPecaSelecionada = new System.Windows.Forms.Button();
            this.AoClicarTrocarParaMenuDeCriarPeca = new System.Windows.Forms.Button();
            this.AoClicarAbrirMenuDeEdicaoDePeca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDePecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDePecas
            // 
            this.GridDePecas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDePecas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDePecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDePecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaId,
            this.ColunaCategoria,
            this.ColunaNome,
            this.ColunaDescricao,
            this.ColunaEstoque,
            this.ColunaDataDeFabricacao});
            this.GridDePecas.DataSource = this.pecaBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDePecas.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridDePecas.Location = new System.Drawing.Point(12, 12);
            this.GridDePecas.Name = "GridDePecas";
            this.GridDePecas.Size = new System.Drawing.Size(796, 347);
            this.GridDePecas.TabIndex = 0;
            // 
            // ColunaId
            // 
            this.ColunaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColunaId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColunaId.FillWeight = 30F;
            this.ColunaId.HeaderText = "Código";
            this.ColunaId.Name = "ColunaId";
            // 
            // ColunaCategoria
            // 
            this.ColunaCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaCategoria.DataPropertyName = "Categoria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColunaCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColunaCategoria.HeaderText = "Categoria";
            this.ColunaCategoria.Name = "ColunaCategoria";
            // 
            // ColunaNome
            // 
            this.ColunaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaNome.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColunaNome.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            // 
            // ColunaDescricao
            // 
            this.ColunaDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColunaDescricao.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColunaDescricao.HeaderText = "Descrição";
            this.ColunaDescricao.Name = "ColunaDescricao";
            // 
            // ColunaEstoque
            // 
            this.ColunaEstoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColunaEstoque.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColunaEstoque.FillWeight = 30F;
            this.ColunaEstoque.HeaderText = "Estoque";
            this.ColunaEstoque.Name = "ColunaEstoque";
            // 
            // ColunaDataDeFabricacao
            // 
            this.ColunaDataDeFabricacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaDataDeFabricacao.DataPropertyName = "DataDeFabricacao";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColunaDataDeFabricacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColunaDataDeFabricacao.HeaderText = "Data de Fabricação";
            this.ColunaDataDeFabricacao.Name = "ColunaDataDeFabricacao";
            // 
            // pecaBindingSource
            // 
            this.pecaBindingSource.DataSource = typeof(Cod3rsGrowth.Modelos.Peca);
            // 
            // AoClicarRemoverPecaSelecionada
            // 
            this.AoClicarRemoverPecaSelecionada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AoClicarRemoverPecaSelecionada.Location = new System.Drawing.Point(670, 376);
            this.AoClicarRemoverPecaSelecionada.Name = "AoClicarRemoverPecaSelecionada";
            this.AoClicarRemoverPecaSelecionada.Size = new System.Drawing.Size(138, 37);
            this.AoClicarRemoverPecaSelecionada.TabIndex = 3;
            this.AoClicarRemoverPecaSelecionada.Text = "Remover";
            this.AoClicarRemoverPecaSelecionada.UseVisualStyleBackColor = true;
            // 
            // AoClicarTrocarParaMenuDeCriarPeca
            // 
            this.AoClicarTrocarParaMenuDeCriarPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AoClicarTrocarParaMenuDeCriarPeca.Location = new System.Drawing.Point(382, 376);
            this.AoClicarTrocarParaMenuDeCriarPeca.Name = "AoClicarTrocarParaMenuDeCriarPeca";
            this.AoClicarTrocarParaMenuDeCriarPeca.Size = new System.Drawing.Size(138, 37);
            this.AoClicarTrocarParaMenuDeCriarPeca.TabIndex = 4;
            this.AoClicarTrocarParaMenuDeCriarPeca.Text = "Adicionar";
            this.AoClicarTrocarParaMenuDeCriarPeca.UseVisualStyleBackColor = true;
            this.AoClicarTrocarParaMenuDeCriarPeca.Click += new System.EventHandler(this.AoClicarTrocarParaMenuDeCriarPeca_Click);
            // 
            // AoClicarAbrirMenuDeEdicaoDePeca
            // 
            this.AoClicarAbrirMenuDeEdicaoDePeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AoClicarAbrirMenuDeEdicaoDePeca.Location = new System.Drawing.Point(526, 376);
            this.AoClicarAbrirMenuDeEdicaoDePeca.Name = "AoClicarAbrirMenuDeEdicaoDePeca";
            this.AoClicarAbrirMenuDeEdicaoDePeca.Size = new System.Drawing.Size(138, 37);
            this.AoClicarAbrirMenuDeEdicaoDePeca.TabIndex = 5;
            this.AoClicarAbrirMenuDeEdicaoDePeca.Text = "Editar";
            this.AoClicarAbrirMenuDeEdicaoDePeca.UseVisualStyleBackColor = true;
            // 
            // ControleDePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 435);
            this.Controls.Add(this.AoClicarRemoverPecaSelecionada);
            this.Controls.Add(this.AoClicarAbrirMenuDeEdicaoDePeca);
            this.Controls.Add(this.GridDePecas);
            this.Controls.Add(this.AoClicarTrocarParaMenuDeCriarPeca);
            this.Name = "ControleDePecas";
            this.Text = "Controle de Peças";
            this.Load += new System.EventHandler(this.ControleDePecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDePecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AoClicarRemoverPecaSelecionada;
        private System.Windows.Forms.Button AoClicarTrocarParaMenuDeCriarPeca;
        private System.Windows.Forms.Button AoClicarAbrirMenuDeEdicaoDePeca;
        private System.Windows.Forms.DataGridView GridDePecas;
        private System.Windows.Forms.BindingSource pecaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDataDeFabricacao;
    }
}

