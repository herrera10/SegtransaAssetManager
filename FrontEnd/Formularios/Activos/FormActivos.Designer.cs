namespace FrontEnd.Formularios.Activos
{
    partial class FormActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivos));
            this.label1 = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablaActivos = new System.Windows.Forms.DataGridView();
            this.activosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosDataSet = new FrontEnd.ActivosDataSet();
            this.activosTableAdapter = new FrontEnd.ActivosDataSetTableAdapters.ActivosTableAdapter();
            this.idActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(279, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = " Activos";
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtBusqueda);
            this.grpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBuscar.Location = new System.Drawing.Point(12, 82);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(290, 68);
            this.grpBuscar.TabIndex = 19;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBusqueda.Location = new System.Drawing.Point(17, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(267, 26);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(355, 356);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(467, 356);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // tablaActivos
            // 
            this.tablaActivos.AllowUserToAddRows = false;
            this.tablaActivos.AllowUserToDeleteRows = false;
            this.tablaActivos.AllowUserToResizeColumns = false;
            this.tablaActivos.AllowUserToResizeRows = false;
            this.tablaActivos.AutoGenerateColumns = false;
            this.tablaActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaActivos.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.tablaActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActivoDataGridViewTextBoxColumn,
            this.codActivoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioInicialDataGridViewTextBoxColumn,
            this.precioActualDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.garantiaDataGridViewTextBoxColumn});
            this.tablaActivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaActivos.DataSource = this.activosBindingSource;
            this.tablaActivos.Location = new System.Drawing.Point(2, 177);
            this.tablaActivos.Name = "tablaActivos";
            this.tablaActivos.ReadOnly = true;
            this.tablaActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaActivos.RowHeadersVisible = false;
            this.tablaActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaActivos.ShowCellErrors = false;
            this.tablaActivos.ShowCellToolTips = false;
            this.tablaActivos.ShowEditingIcon = false;
            this.tablaActivos.ShowRowErrors = false;
            this.tablaActivos.Size = new System.Drawing.Size(777, 151);
            this.tablaActivos.TabIndex = 33;
            this.tablaActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaActivos_CellContentClick);
            // 
            // activosBindingSource
            // 
            this.activosBindingSource.DataMember = "Activos";
            this.activosBindingSource.DataSource = this.activosDataSet;
            // 
            // activosDataSet
            // 
            this.activosDataSet.DataSetName = "ActivosDataSet";
            this.activosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activosTableAdapter
            // 
            this.activosTableAdapter.ClearBeforeFill = true;
            // 
            // idActivoDataGridViewTextBoxColumn
            // 
            this.idActivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idActivoDataGridViewTextBoxColumn.DataPropertyName = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.FillWeight = 266.4975F;
            this.idActivoDataGridViewTextBoxColumn.HeaderText = "IdActivo";
            this.idActivoDataGridViewTextBoxColumn.Name = "idActivoDataGridViewTextBoxColumn";
            this.idActivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActivoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idActivoDataGridViewTextBoxColumn.Width = 71;
            // 
            // codActivoDataGridViewTextBoxColumn
            // 
            this.codActivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codActivoDataGridViewTextBoxColumn.DataPropertyName = "CodActivo";
            this.codActivoDataGridViewTextBoxColumn.FillWeight = 72.25043F;
            this.codActivoDataGridViewTextBoxColumn.HeaderText = "CodActivo";
            this.codActivoDataGridViewTextBoxColumn.Name = "codActivoDataGridViewTextBoxColumn";
            this.codActivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codActivoDataGridViewTextBoxColumn.Width = 81;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.FillWeight = 72.25043F;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // precioInicialDataGridViewTextBoxColumn
            // 
            this.precioInicialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioInicialDataGridViewTextBoxColumn.DataPropertyName = "PrecioInicial";
            this.precioInicialDataGridViewTextBoxColumn.FillWeight = 72.25043F;
            this.precioInicialDataGridViewTextBoxColumn.HeaderText = "PrecioInicial";
            this.precioInicialDataGridViewTextBoxColumn.Name = "precioInicialDataGridViewTextBoxColumn";
            this.precioInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioInicialDataGridViewTextBoxColumn.Width = 89;
            // 
            // precioActualDataGridViewTextBoxColumn
            // 
            this.precioActualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioActualDataGridViewTextBoxColumn.DataPropertyName = "PrecioActual";
            this.precioActualDataGridViewTextBoxColumn.FillWeight = 72.25043F;
            this.precioActualDataGridViewTextBoxColumn.HeaderText = "PrecioActual";
            this.precioActualDataGridViewTextBoxColumn.Name = "precioActualDataGridViewTextBoxColumn";
            this.precioActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioActualDataGridViewTextBoxColumn.Width = 92;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.FillWeight = 72.25043F;
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCompraDataGridViewTextBoxColumn.Width = 98;
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            this.garantiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.FillWeight = 72.25043F;
            this.garantiaDataGridViewTextBoxColumn.HeaderText = "Garantia";
            this.garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            this.garantiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.garantiaDataGridViewTextBoxColumn.Width = 72;
            // 
            // FormActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(771, 432);
            this.Controls.Add(this.tablaActivos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormActivos";
            this.Load += new System.EventHandler(this.FormActivos_Load);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tablaActivos;
        private ActivosDataSet activosDataSet;
        private System.Windows.Forms.BindingSource activosBindingSource;
        private ActivosDataSetTableAdapters.ActivosTableAdapter activosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
    }
}