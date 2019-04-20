namespace FrontEnd.Formularios.EstadoActivos
{
    partial class FormEstadoActivoModifica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaCategorias = new System.Windows.Forms.DataGridView();
            this.idEstadoActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoActivosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoActivosDataSet = new FrontEnd.EstadoActivosDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdEstadoActivo = new System.Windows.Forms.ComboBox();
            this.estadoActivosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombreEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.estadoActivosTableAdapter = new FrontEnd.EstadoActivosDataSetTableAdapters.EstadoActivosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCategorias
            // 
            this.tablaCategorias.AllowUserToAddRows = false;
            this.tablaCategorias.AllowUserToDeleteRows = false;
            this.tablaCategorias.AllowUserToResizeColumns = false;
            this.tablaCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaCategorias.AutoGenerateColumns = false;
            this.tablaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCategorias.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.tablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstadoActivoDataGridViewTextBoxColumn,
            this.nombreEstadoDataGridViewTextBoxColumn});
            this.tablaCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablaCategorias.DataSource = this.estadoActivosBindingSource;
            this.tablaCategorias.EnableHeadersVisualStyles = false;
            this.tablaCategorias.Location = new System.Drawing.Point(128, 114);
            this.tablaCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablaCategorias.Name = "tablaCategorias";
            this.tablaCategorias.ReadOnly = true;
            this.tablaCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaCategorias.RowHeadersVisible = false;
            this.tablaCategorias.RowTemplate.Height = 24;
            this.tablaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCategorias.Size = new System.Drawing.Size(591, 207);
            this.tablaCategorias.TabIndex = 36;
            // 
            // idEstadoActivoDataGridViewTextBoxColumn
            // 
            this.idEstadoActivoDataGridViewTextBoxColumn.DataPropertyName = "IdEstadoActivo";
            this.idEstadoActivoDataGridViewTextBoxColumn.HeaderText = "Identificador Estado Activos";
            this.idEstadoActivoDataGridViewTextBoxColumn.Name = "idEstadoActivoDataGridViewTextBoxColumn";
            this.idEstadoActivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEstadoDataGridViewTextBoxColumn
            // 
            this.nombreEstadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEstado";
            this.nombreEstadoDataGridViewTextBoxColumn.HeaderText = "Nombre del Estado";
            this.nombreEstadoDataGridViewTextBoxColumn.Name = "nombreEstadoDataGridViewTextBoxColumn";
            this.nombreEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoActivosBindingSource
            // 
            this.estadoActivosBindingSource.DataMember = "EstadoActivos";
            this.estadoActivosBindingSource.DataSource = this.estadoActivosDataSetBindingSource;
            // 
            // estadoActivosDataSetBindingSource
            // 
            this.estadoActivosDataSetBindingSource.DataSource = this.estadoActivosDataSet;
            this.estadoActivosDataSetBindingSource.Position = 0;
            // 
            // estadoActivosDataSet
            // 
            this.estadoActivosDataSet.DataSetName = "EstadoActivosDataSet";
            this.estadoActivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(124, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Identificador Estado Activo";
            // 
            // cmbIdEstadoActivo
            // 
            this.cmbIdEstadoActivo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estadoActivosBindingSource, "IdEstadoActivo", true));
            this.cmbIdEstadoActivo.DataSource = this.estadoActivosBindingSource1;
            this.cmbIdEstadoActivo.DisplayMember = "IdEstadoActivo";
            this.cmbIdEstadoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdEstadoActivo.FormattingEnabled = true;
            this.cmbIdEstadoActivo.Location = new System.Drawing.Point(337, 67);
            this.cmbIdEstadoActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdEstadoActivo.Name = "cmbIdEstadoActivo";
            this.cmbIdEstadoActivo.Size = new System.Drawing.Size(59, 28);
            this.cmbIdEstadoActivo.TabIndex = 32;
            this.cmbIdEstadoActivo.ValueMember = "IdEstadoActivo";
            this.cmbIdEstadoActivo.SelectedIndexChanged += new System.EventHandler(this.cmbIdEstadoActivo_SelectedIndexChanged);
            this.cmbIdEstadoActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIdEstadoActivo_KeyPress);
            // 
            // estadoActivosBindingSource1
            // 
            this.estadoActivosBindingSource1.DataMember = "EstadoActivos";
            this.estadoActivosBindingSource1.DataSource = this.estadoActivosDataSetBindingSource;
            // 
            // txtNombreEstado
            // 
            this.txtNombreEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreEstado.Location = new System.Drawing.Point(482, 66);
            this.txtNombreEstado.Name = "txtNombreEstado";
            this.txtNombreEstado.Size = new System.Drawing.Size(238, 26);
            this.txtNombreEstado.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(400, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(299, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Modificar Estado de Activo";
            // 
            // estadoActivosTableAdapter
            // 
            this.estadoActivosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(386, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 47;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(258, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 46;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormEstadoActivoModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(861, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tablaCategorias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdEstadoActivo);
            this.Controls.Add(this.txtNombreEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEstadoActivoModifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEstadoActivoModifica";
            this.Load += new System.EventHandler(this.FormEstadoActivoModifica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoActivosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdEstadoActivo;
        private System.Windows.Forms.TextBox txtNombreEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource estadoActivosDataSetBindingSource;
        private EstadoActivosDataSet estadoActivosDataSet;
        private System.Windows.Forms.BindingSource estadoActivosBindingSource;
        private EstadoActivosDataSetTableAdapters.EstadoActivosTableAdapter estadoActivosTableAdapter;
        private System.Windows.Forms.BindingSource estadoActivosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}