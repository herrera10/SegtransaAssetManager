using Backend.DAL;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Formularios.Activos
{
    public partial class FormActivos : Form
    {
        BDContext context;
        private IActivosDAL activosDAL = new ActivosDALImpl();

        public FormActivos()
        {
            InitializeComponent();
        }
        private void cargarActivos()
        {

            this.tablaActivos.DataSource = null;
            this.tablaActivos.DataSource = activosDAL.obtenerActivos();
        }

        private void FormActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'activosDataSet.Activos' Puede moverla o quitarla según sea necesario.
            this.activosTableAdapter.Fill(this.activosDataSet.Activos);

        }

        int idP;
        private void obtenerIDTabla(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idP = Int32.Parse(tablaActivos.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {

                cargarActivos();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tablaActivos.CurrentCell = null;
                foreach (DataGridViewRow r in tablaActivos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tablaActivos.Rows)
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
                cargarActivos();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar el activo seleccionado?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    activosDAL.eliminarActivo(this.idP);
                    MessageBox.Show("Activo eliminado", "Confirmacion");
                    cargarActivos();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede borrar el activo seleccionado", "Error");
            }
        }

        private void tablaActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
