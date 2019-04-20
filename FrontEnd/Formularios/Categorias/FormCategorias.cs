using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.DAL;
using Backend.Entities;
using FrontEnd.Formularios.Categorias;
using Microsoft.CSharp.RuntimeBinder;

namespace FrontEnd.Formularios
{
    public partial class FormCategorias : Form
    {
        BDContext context;
        private ICategoriasDAL categoriasDAL = new CategoriaDALImpl();

        public FormCategorias()
        {
            InitializeComponent();
        }

        public void cargarCategorias()
        {
            this.tablaCategorias.DataSource = null;
            this.tablaCategorias.DataSource = categoriasDAL.obtenerCategorias();
        }
        private void tablaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idP = Int32.Parse(tablaCategorias.Rows[e.RowIndex].Cells[0].Value.ToString());
        
            }
            catch (Exception)
            {
                cargarCategorias();
            }
        }

        private void agregarActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarActivoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormCategoriaInsertar form = new FormCategoriaInsertar();
                form.ShowDialog(this);
                cargarCategorias();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error","Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'categoriasDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.categoriasDataSet.Categorias);


        }

        int idP;
        private void obtenerIDTabla(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cerrarVentanaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tablaCategorias.CurrentCell = null;
                foreach (DataGridViewRow r in tablaCategorias.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tablaCategorias.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString()).ToUpper().IndexOf(txtBusqueda.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }

            }
            else
            {
                cargarCategorias();
            }
        }




        private void eliminarCategoriaSeleccionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar la categoría seleccionada?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    categoriasDAL.deleteCategoria(this.idP);
                    MessageBox.Show("Categoria eliminada","Confirmacion");
                    cargarCategorias();
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede borrar la categoría seleccionada","Error");
            }
        }

        private void modificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormModificaCategoria form = new FormModificaCategoria();
                form.ShowDialog(this);
                cargarCategorias();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error","Error");
            }
        }

        private void tablaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {
                FormCategoriaInsertar form = new FormCategoriaInsertar();
                form.ShowDialog(this);
                cargarCategorias();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error", "Error");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                FormModificaCategoria form = new FormModificaCategoria();
                form.ShowDialog(this);
                cargarCategorias();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error", "Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar la categoría seleccionada?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    categoriasDAL.deleteCategoria(this.idP);
                    MessageBox.Show("Categoria eliminada", "Confirmacion");
                    cargarCategorias();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede borrar la categoría seleccionada", "Error");
            }
        }
    }
}
