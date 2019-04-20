using Backend.DAL;
using Frontend;
using FrontEnd.Formularios;
using FrontEnd.Formularios.Proveedores;
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
    public partial class FormProveedores : Form
    {
        Inicio inicio = new Inicio();
        IProveedoresDAL proveedorDAL = new ProveedoresDALImpl();

        public FormProveedores()
        {
            InitializeComponent();
        }


        public void cargarProveedores()
        {
            this.tablaProveedores.DataSource = null;
            this.tablaProveedores.DataSource = proveedorDAL.obtenerProveedores();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedoresDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.proveedoresDataSet.Proveedores);

        }

        private void cerrarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                tablaProveedores.CurrentCell = null;
                foreach (DataGridViewRow r in tablaProveedores.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in tablaProveedores.Rows)
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
                cargarProveedores();
            }
        }
        int idP;
        private void tablaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idP = Int32.Parse(tablaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                cargarProveedores();
            }
        }

        private void eliminarProveedorSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

            try
            {
                try
                {
                    if (MessageBox.Show("Desea eliminar el proveedor?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        proveedorDAL.deleteProveedor(this.idP);
                        MessageBox.Show("Proveedor eliminado","Confirmacion");
                        cargarProveedores();
                    }
                                           
                }
                catch (Exception)
                {

                    MessageBox.Show("No se puede borrar el proveedor seleccionado","Error");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error","Error");
            }
        }

        private void agregarNuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                 FormProveedoresInserta form = new FormProveedoresInserta();
                 form.ShowDialog(this);
                 cargarProveedores();
              
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error","Error" +ex);
            }
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormProveedoresModifica form = new FormProveedoresModifica();
                form.ShowDialog(this);
                cargarProveedores();
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
                FormProveedoresInserta form = new FormProveedoresInserta();
                form.ShowDialog(this);
                cargarProveedores();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error", "Error" + ex);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                FormProveedoresModifica form = new FormProveedoresModifica();
                form.ShowDialog(this);
                cargarProveedores();
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
                try
                {
                    if (MessageBox.Show("Desea eliminar el proveedor?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        proveedorDAL.deleteProveedor(this.idP);
                        MessageBox.Show("Proveedor eliminado", "Confirmacion");
                        cargarProveedores();
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("No se puede borrar el proveedor seleccionado", "Error");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error", "Error");
            }
        }
    }
}
