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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CodigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoCanalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDaPessoaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisualizacoesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoColumn,
            this.NomeDoCanalColumn,
            this.NomeDaPessoaColumn,
            this.IdadeColumn,
            this.VisualizacoesColumn});
            this.dataGridView1.Location = new System.Drawing.Point(100, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 394);
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
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(235, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(405, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(115, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 30);
            this.txtBuscar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("News706 BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vizualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CodigoColumn
            // 
            this.CodigoColumn.HeaderText = "Codigo";
            this.CodigoColumn.Name = "CodigoColumn";
            this.CodigoColumn.ReadOnly = true;
            // 
            // NomeDoCanalColumn
            // 
            this.NomeDoCanalColumn.HeaderText = "NomeDoCanal";
            this.NomeDoCanalColumn.Name = "NomeDoCanalColumn";
            this.NomeDoCanalColumn.ReadOnly = true;
            // 
            // NomeDaPessoaColumn
            // 
            this.NomeDaPessoaColumn.HeaderText = "NomeDaPessoa";
            this.NomeDaPessoaColumn.Name = "NomeDaPessoaColumn";
            this.NomeDaPessoaColumn.ReadOnly = true;
            // 
            // IdadeColumn
            // 
            this.IdadeColumn.HeaderText = "Idade";
            this.IdadeColumn.Name = "IdadeColumn";
            this.IdadeColumn.ReadOnly = true;
            // 
            // VisualizacoesColumn
            // 
            this.VisualizacoesColumn.HeaderText = "Vizualizacoes";
            this.VisualizacoesColumn.Name = "VisualizacoesColumn";
            this.VisualizacoesColumn.ReadOnly = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inicial";
            this.Text = "Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoCanalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDaPessoaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisualizacoesColumn;
    }
}