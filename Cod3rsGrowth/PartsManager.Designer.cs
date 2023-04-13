﻿namespace Cod3rsGrowth
{
    partial class PartsManager
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonToRemovePart = new System.Windows.Forms.Button();
            this.ButtonToAddNewPart = new System.Windows.Forms.Button();
            this.ButtonToUpdatePart = new System.Windows.Forms.Button();
            this.pagesControl = new System.Windows.Forms.TabControl();
            this.partsList = new System.Windows.Forms.TabPage();
            this.newPart = new System.Windows.Forms.TabPage();
            this.NewPartScreenReturnButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pagesControl.SuspendLayout();
            this.partsList.SuspendLayout();
            this.newPart.SuspendLayout();
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
            // ButtonToRemovePart
            // 
            this.ButtonToRemovePart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToRemovePart.Location = new System.Drawing.Point(625, 359);
            this.ButtonToRemovePart.Name = "ButtonToRemovePart";
            this.ButtonToRemovePart.Size = new System.Drawing.Size(138, 37);
            this.ButtonToRemovePart.TabIndex = 3;
            this.ButtonToRemovePart.Text = "Remover";
            this.ButtonToRemovePart.UseVisualStyleBackColor = true;
            // 
            // ButtonToAddNewPart
            // 
            this.ButtonToAddNewPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToAddNewPart.Location = new System.Drawing.Point(337, 359);
            this.ButtonToAddNewPart.Name = "ButtonToAddNewPart";
            this.ButtonToAddNewPart.Size = new System.Drawing.Size(138, 37);
            this.ButtonToAddNewPart.TabIndex = 4;
            this.ButtonToAddNewPart.Text = "Adicionar";
            this.ButtonToAddNewPart.UseVisualStyleBackColor = true;
            this.ButtonToAddNewPart.Click += new System.EventHandler(this.ButtonToAddNewPart_Click);
            // 
            // ButtonToUpdatePart
            // 
            this.ButtonToUpdatePart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToUpdatePart.Location = new System.Drawing.Point(481, 359);
            this.ButtonToUpdatePart.Name = "ButtonToUpdatePart";
            this.ButtonToUpdatePart.Size = new System.Drawing.Size(138, 37);
            this.ButtonToUpdatePart.TabIndex = 5;
            this.ButtonToUpdatePart.Text = "Editar";
            this.ButtonToUpdatePart.UseVisualStyleBackColor = true;
            // 
            // pagesControl
            // 
            this.pagesControl.Controls.Add(this.partsList);
            this.pagesControl.Controls.Add(this.newPart);
            this.pagesControl.Location = new System.Drawing.Point(0, 0);
            this.pagesControl.Name = "pagesControl";
            this.pagesControl.SelectedIndex = 0;
            this.pagesControl.Size = new System.Drawing.Size(777, 428);
            this.pagesControl.TabIndex = 6;
            // 
            // partsList
            // 
            this.partsList.Controls.Add(this.dataGridView1);
            this.partsList.Controls.Add(this.ButtonToRemovePart);
            this.partsList.Controls.Add(this.ButtonToUpdatePart);
            this.partsList.Controls.Add(this.ButtonToAddNewPart);
            this.partsList.Location = new System.Drawing.Point(4, 22);
            this.partsList.Name = "partsList";
            this.partsList.Padding = new System.Windows.Forms.Padding(3);
            this.partsList.Size = new System.Drawing.Size(769, 402);
            this.partsList.TabIndex = 0;
            this.partsList.Text = "Lista de Peças";
            this.partsList.UseVisualStyleBackColor = true;
            // 
            // newPart
            // 
            this.newPart.Controls.Add(this.NewPartScreenReturnButton);
            this.newPart.Controls.Add(this.button1);
            this.newPart.Location = new System.Drawing.Point(4, 22);
            this.newPart.Name = "newPart";
            this.newPart.Padding = new System.Windows.Forms.Padding(3);
            this.newPart.Size = new System.Drawing.Size(769, 402);
            this.newPart.TabIndex = 1;
            this.newPart.Text = "Cadastro de Peças";
            this.newPart.UseVisualStyleBackColor = true;
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
            // PartsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 435);
            this.Controls.Add(this.pagesControl);
            this.Name = "PartsManager";
            this.Text = "Controle de Peças";
            this.Load += new System.EventHandler(this.PartsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pagesControl.ResumeLayout(false);
            this.partsList.ResumeLayout(false);
            this.newPart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonToRemovePart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button ButtonToAddNewPart;
        private System.Windows.Forms.Button ButtonToUpdatePart;
        private System.Windows.Forms.TabControl pagesControl;
        private System.Windows.Forms.TabPage partsList;
        private System.Windows.Forms.TabPage newPart;
        private System.Windows.Forms.Button NewPartScreenReturnButton;
        private System.Windows.Forms.Button button1;
    }
}
