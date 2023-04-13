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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aoClicarRemoverPecaSelecionada = new System.Windows.Forms.Button();
            this.aoClicarTrocarParaMenuDeCriarPeca = new System.Windows.Forms.Button();
            this.aoClicarAbrirMenuDeEdicaoDePeca = new System.Windows.Forms.Button();
            this.controleDePagina = new System.Windows.Forms.TabControl();
            this.listaDePecas = new System.Windows.Forms.TabPage();
            this.criarPeca = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "category";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "name";
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "description";
            this.Column4.HeaderText = "Descrição";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "inventory";
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "Estoque";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // aoClicarRemoverPecaSelecionada
            // 
            this.aoClicarRemoverPecaSelecionada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarRemoverPecaSelecionada.Location = new System.Drawing.Point(625, 359);
            this.aoClicarRemoverPecaSelecionada.Name = "aoClicarRemoverPecaSelecionada";
            this.aoClicarRemoverPecaSelecionada.Size = new System.Drawing.Size(138, 37);
            this.aoClicarRemoverPecaSelecionada.TabIndex = 3;
            this.aoClicarRemoverPecaSelecionada.Text = "Remover";
            this.aoClicarRemoverPecaSelecionada.UseVisualStyleBackColor = true;
            // 
            // aoClicarTrocarParaMenuDeCriarPeca
            // 
            this.aoClicarTrocarParaMenuDeCriarPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aoClicarTrocarParaMenuDeCriarPeca.Location = new System.Drawing.Point(337, 359);
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
            this.aoClicarAbrirMenuDeEdicaoDePeca.Location = new System.Drawing.Point(481, 359);
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
            this.controleDePagina.Size = new System.Drawing.Size(777, 428);
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
            this.listaDePecas.Size = new System.Drawing.Size(769, 402);
            this.listaDePecas.TabIndex = 0;
            this.listaDePecas.Text = "Lista de Peças";
            this.listaDePecas.UseVisualStyleBackColor = true;
            // 
            // criarPeca
            // 
            this.criarPeca.Controls.Add(this.listBox1);
            this.criarPeca.Controls.Add(this.textBox4);
            this.criarPeca.Controls.Add(this.label4);
            this.criarPeca.Controls.Add(this.textBox3);
            this.criarPeca.Controls.Add(this.label3);
            this.criarPeca.Controls.Add(this.textBox2);
            this.criarPeca.Controls.Add(this.label2);
            this.criarPeca.Controls.Add(this.textBox1);
            this.criarPeca.Controls.Add(this.label1);
            this.criarPeca.Controls.Add(this.NewPartScreenReturnButton);
            this.criarPeca.Controls.Add(this.button1);
            this.criarPeca.Location = new System.Drawing.Point(4, 22);
            this.criarPeca.Name = "criarPeca";
            this.criarPeca.Padding = new System.Windows.Forms.Padding(3);
            this.criarPeca.Size = new System.Drawing.Size(769, 402);
            this.criarPeca.TabIndex = 1;
            this.criarPeca.Text = "Cadastro de Peças";
            this.criarPeca.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Teste1",
            "Teste2",
            "Teste3"});
            this.listBox1.Location = new System.Drawing.Point(227, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 17);
            this.listBox1.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(36, 145);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 20);
            this.textBox4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estoque";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categoria";
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
            this.ClientSize = new System.Drawing.Size(782, 435);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button aoClicarTrocarParaMenuDeCriarPeca;
        private System.Windows.Forms.Button aoClicarAbrirMenuDeEdicaoDePeca;
        private System.Windows.Forms.TabControl controleDePagina;
        private System.Windows.Forms.TabPage listaDePecas;
        private System.Windows.Forms.TabPage criarPeca;
        private System.Windows.Forms.Button NewPartScreenReturnButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

