using Backend.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Formularios.Proveedores
{
    public partial class FormProveedoresModifica : Form
    {

        IProveedoresDAL proveedorDAL = new ProveedoresDALImpl();
        Backend.Entities.Proveedores proveedores;

        public FormProveedoresModifica()
        {
            InitializeComponent();
        }

        private void FormProveedoresModifica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedoresDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.proveedoresDataSet.Proveedores);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreProveedor.Text) ||
                    string.IsNullOrEmpty(txtCorreoProveedor.Text) ||
                    string.IsNullOrEmpty(txtTelefonoProveedor.Text) ||
                    string.IsNullOrEmpty(txtDireccionProveedor.Text))
                {
                    MessageBox.Show("Campos vacios","Aviso");

                    return;
                }
                else
                {
                    try
                    {
                        proveedores.IdProveedor = Convert.ToInt32(cmbIdProveedor.SelectedValue);
                        proveedores.NombreProveedor = txtNombreProveedor.Text;
                        proveedores.Correo = txtCorreoProveedor.Text;
                        proveedores.Telefono = txtTelefonoProveedor.Text;
                        proveedores.Direccion = txtDireccionProveedor.Text;
                        proveedorDAL.updateProveedor(proveedores);
                        MessageBox.Show("Proveedor modificado con éxito","Confirmacion");
                        this.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Hubo un error","Error");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbIdProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbIdProveedor.Text;
            int id2 = Convert.ToInt32(id);
            proveedores = proveedorDAL.obtenerProveedorPorID(id2);
            txtNombreProveedor.Text = proveedores.NombreProveedor;
            txtTelefonoProveedor.Text = proveedores.Telefono;
            txtCorreoProveedor.Text = proveedores.Correo;
            txtDireccionProveedor.Text = proveedores.Direccion;
        }

        private void cmbIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
