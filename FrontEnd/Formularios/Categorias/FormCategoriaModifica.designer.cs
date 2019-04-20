namespace FrontEnd.Formularios.Categorias
{
    partial class FormModificaCategoria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdCategoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaDataset = new FrontEnd.CategoriasDataSet();
            this.txtDescripcion_ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.categoriasTableAdapter = new FrontEnd.CategoriasDataSetTableAdapters.CategoriasTableAdapter();
            this.tablaCategorias = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(158, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Identificador:";
            // 
            // cmbIdCategoria
            // 
            this.cmbIdCategoria.DataSource = this.categoriasBindingSource;
            this.cmbIdCategoria.DisplayMember = "IdCategoria";
            this.cmbIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdCategoria.FormattingEnabled = true;
            this.cmbIdCategoria.Location = new System.Drawing.Point(268, 54);
            this.cmbIdCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdCategoria.Name = "cmbIdCategoria";
            this.cmbIdCategoria.Size = new System.Drawing.Size(64, 28);
            this.cmbIdCategoria.TabIndex = 24;
            this.cmbIdCategoria.ValueMember = "IdCategoria";
            this.cmbIdCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbIdActivo_SelectedIndexChanged);
            this.cmbIdCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIdCategoria_KeyPress);
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.categoriaDataset;
            // 
            // categoriaDataset
            // 
            this.categoriaDataset.DataSetName = "CategoriaDataset";
            this.categoriaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescripcion_
            // 
            this.txtDescripcion_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescripcion_.Location = new System.Drawing.Point(453, 57);
            this.txtDescripcion_.Name = "txtDescripcion_";
            this.txtDescripcion_.Size = new System.Drawing.Size(238, 26);
            this.txtDescripcion_.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(352, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Descripcion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(296, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Modificar Categoria de Activo";
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tablaCategorias
            // 
            this.tablaCategorias.AllowUserToAddRows = false;
            this.tablaCategorias.AllowUserToDeleteRows = false;
            this.tablaCategorias.AllowUserToResizeColumns = false;
            this.tablaCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCategorias.AutoGenerateColumns = false;
            this.tablaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCategorias.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.tablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.tablaCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaCategorias.DataSource = this.categoriasBindingSource;
            this.tablaCategorias.EnableHeadersVisualStyles = false;
            this.tablaCategorias.Location = new System.Drawing.Point(161, 103);
            this.tablaCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablaCategorias.Name = "tablaCategorias";
            this.tablaCategorias.ReadOnly = true;
            this.tablaCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaCategorias.RowHeadersVisible = false;
            this.tablaCategorias.RowTemplate.Height = 24;
            this.tablaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCategorias.Size = new System.Drawing.Size(514, 207);
            this.tablaCategorias.TabIndex = 28;
            this.tablaCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.obtenerIDTabla);
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCategoriaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idCategoriaDataGridViewTextBoxColumn.FillWeight = 76.14214F;
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idCategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descripcionDataGridViewTextBoxColumn.FillWeight = 123.8579F;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion de la Categoría";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(440, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(312, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 44;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormModificaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(861, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tablaCategorias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdCategoria);
            this.Controls.Add(this.txtDescripcion_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormModificaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificaCategoria";
            this.Load += new System.EventHandler(this.FormModificaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdCategoria;
        private System.Windows.Forms.TextBox txtDescripcion_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private CategoriasDataSet categoriaDataset;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private CategoriasDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridView tablaCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}