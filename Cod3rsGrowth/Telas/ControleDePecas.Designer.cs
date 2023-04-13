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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            GridDePecas = new System.Windows.Forms.DataGridView();
            this.ColunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDataDeFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aoClicarRemoverPecaSelecionada = new System.Windows.Forms.Button();
            this.aoClicarTrocarParaMenuDeCriarPeca = new System.Windows.Forms.Button();
            this.aoClicarAbrirMenuDeEdicaoDePeca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(GridDePecas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDePecas
            // 
            GridDePecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDePecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaId,
            this.ColunaCategoria,
            this.ColunaNome,
            this.ColunaDescricao,
            this.ColunaDataDeFabricacao,
            this.ColunaEstoque});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            GridDePecas.DefaultCellStyle = dataGridViewCellStyle1;
            GridDePecas.Location = new System.Drawing.Point(12, 12);
            GridDePecas.Name = "GridDePecas";
            GridDePecas.Size = new System.Drawing.Size(796, 347);
            GridDePecas.TabIndex = 0;
            // 
            // ColunaId
            // 
            this.ColunaId.DataPropertyName = "Id";
            this.ColunaId.FillWeight = 30F;
            this.ColunaId.HeaderText = "Código";
            this.ColunaId.Name = "ColunaId";
            this.ColunaId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColunaId.Width = 60;
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
            this.aoClicarRemoverPecaSelecionada.Location = new System.Drawing.Point(670, 376);
            this.aoClicarRemoverPecaSelecionada.Name = "aoClicarRemoverPecaSelecionada";
            this.aoClicarRemoverPecaSelecionada.Size = new System.Drawing.Size(138, 37);
            this.aoClicarRemoverPecaSelecionada.TabIndex = 3;
            this.aoClicarRemoverPecaSelecionada.Text = "Remover";
            this.aoClicarRemoverPecaSelecionada.UseVisualStyleBackColor = true;
            // 
            // aoClicarTrocarParaMenuDeCriarPeca
            // 
            this.aoClicarTrocarParaMenuDeCriarPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarTrocarParaMenuDeCriarPeca.Location = new System.Drawing.Point(382, 376);
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
            this.aoClicarAbrirMenuDeEdicaoDePeca.Location = new System.Drawing.Point(526, 376);
            this.aoClicarAbrirMenuDeEdicaoDePeca.Name = "aoClicarAbrirMenuDeEdicaoDePeca";
            this.aoClicarAbrirMenuDeEdicaoDePeca.Size = new System.Drawing.Size(138, 37);
            this.aoClicarAbrirMenuDeEdicaoDePeca.TabIndex = 5;
            this.aoClicarAbrirMenuDeEdicaoDePeca.Text = "Editar";
            this.aoClicarAbrirMenuDeEdicaoDePeca.UseVisualStyleBackColor = true;
            // 
            // ControleDePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 435);
            this.Controls.Add(this.aoClicarRemoverPecaSelecionada);
            this.Controls.Add(this.aoClicarAbrirMenuDeEdicaoDePeca);
            this.Controls.Add(GridDePecas);
            this.Controls.Add(this.aoClicarTrocarParaMenuDeCriarPeca);
            this.Name = "ControleDePecas";
            this.Text = "Controle de Peças";
            this.Load += new System.EventHandler(this.ControleDePecas_Load);
            ((System.ComponentModel.ISupportInitialize)(GridDePecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.DataGridView GridDePecas;
        private System.Windows.Forms.Button aoClicarRemoverPecaSelecionada;
        private System.Windows.Forms.Button aoClicarTrocarParaMenuDeCriarPeca;
        private System.Windows.Forms.Button aoClicarAbrirMenuDeEdicaoDePeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDataDeFabricacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEstoque;
    }
}

