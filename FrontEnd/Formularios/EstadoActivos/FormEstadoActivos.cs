using Backend.DAL;
using Backend.Entities;
using FrontEnd.Formularios.EstadoActivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Formularios
{
    public partial class FormEstadoActivos : Form
    {
        BDContext context;
        private IEstadoActivosDAL estadoActivosDAL = new EstadoActivosDALImpl();

        public FormEstadoActivos()
        {
            InitializeComponent();
        }


        public void cargarEstadoActivos()
        {
            this.tablaEstadoActivos.DataSource = null;
            this.tablaEstadoActivos.DataSource = estadoActivosDAL.obtenerEstadoActivos();
        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarCategoriaSeleccionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevoEstadoActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstadoActivoInserta form = new FormEstadoActivoInserta();                
                form.ShowDialog(this);
                cargarEstadoActivos();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error");
            }
        }

        private void FormEstadoActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estadoActivosDataSet.EstadoActivos' Puede moverla o quitarla según sea necesario.
            this.estadoActivosTableAdapter.Fill(this.estadoActivosDataSet.EstadoActivos);

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tablaEstadoActivos.CurrentCell = null;
                foreach (DataGridViewRow r in tablaEstadoActivos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tablaEstadoActivos.Rows)
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
                cargarEstadoActivos();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int idP;
        private void tablaEstadoActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idP = Int32.Parse(tablaEstadoActivos.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {

                cargarEstadoActivos();
            }
        }

        private void eliminarEstadoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar el estado seleccionado?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    estadoActivosDAL.deleteEstadoActivos(this.idP);
                    MessageBox.Show("Estado activo eliminado","Confirmacion");
                    cargarEstadoActivos();
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede borrar el estado seleccionado","Error");
            }
        }

        private void modificarEstadoActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstadoActivoModifica form = new FormEstadoActivoModifica();
                form.ShowDialog(this);
                cargarEstadoActivos();

            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error","Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstadoActivoInserta form = new FormEstadoActivoInserta();
                form.ShowDialog(this);
                cargarEstadoActivos();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                FormEstadoActivoModifica form = new FormEstadoActivoModifica();
                form.ShowDialog(this);
                cargarEstadoActivos();

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
                if (MessageBox.Show("Desea eliminar el estado seleccionado?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    estadoActivosDAL.deleteEstadoActivos(this.idP);
                    MessageBox.Show("Estado activo eliminado", "Confirmacion");
                    cargarEstadoActivos();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede borrar el estado seleccionado", "Error");
            }
        }
    }
}
