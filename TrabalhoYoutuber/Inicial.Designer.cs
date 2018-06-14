namespace TrabalhoYoutuber
{
    partial class Inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.NomeDaPessoaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrikesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisualizacoesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InscritosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApelidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDaPessoaColumn,
            this.StrikesColumn,
            this.VisualizacoesColumn,
            this.InscritosColumn,
            this.ApelidoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(58, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(640, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(58, 71);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(128, 55);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(235, 71);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(128, 55);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(405, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 55);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // NomeDaPessoaColumn
            // 
            this.NomeDaPessoaColumn.HeaderText = "NomeDaPessoa";
            this.NomeDaPessoaColumn.Name = "NomeDaPessoaColumn";
            this.NomeDaPessoaColumn.ReadOnly = true;
            // 
            // StrikesColumn
            // 
            this.StrikesColumn.HeaderText = "Strikes";
            this.StrikesColumn.Name = "StrikesColumn";
            this.StrikesColumn.ReadOnly = true;
            // 
            // VisualizacoesColumn
            // 
            this.VisualizacoesColumn.HeaderText = "Vizualizacoes";
            this.VisualizacoesColumn.Name = "VisualizacoesColumn";
            this.VisualizacoesColumn.ReadOnly = true;
            // 
            // InscritosColumn
            // 
            this.InscritosColumn.HeaderText = "Inscritos";
            this.InscritosColumn.Name = "InscritosColumn";
            this.InscritosColumn.ReadOnly = true;
            // 
            // ApelidoColumn
            // 
            this.ApelidoColumn.HeaderText = "Apelido";
            this.ApelidoColumn.Name = "ApelidoColumn";
            this.ApelidoColumn.ReadOnly = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 538);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.Activated += new System.EventHandler(this.Inicial_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDaPessoaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrikesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisualizacoesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InscritosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApelidoColumn;
    }
}