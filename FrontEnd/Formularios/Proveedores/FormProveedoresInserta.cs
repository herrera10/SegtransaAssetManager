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
    public partial class FormProveedoresInserta : Form
    {
        IProveedoresDAL proveedorDAL = new ProveedoresDALImpl();

        public FormProveedoresInserta()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "Nombre del Proveedor")
            {
                txtNombreProveedor.Text = "";

                txtNombreProveedor.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "")
            {
                txtNombreProveedor.Text = "Nombre del Proveedor";

                txtNombreProveedor.ForeColor = Color.Silver;
            }

        }

        private void txtCorreoProveedor_Leave(object sender, EventArgs e)
        {
            if (txtCorreoProveedor.Text == "")
            {
                txtCorreoProveedor.Text = "proveedor@mail.com";

                txtCorreoProveedor.ForeColor = Color.Silver;
            }

        }

        private void txtCorreoProveedor_Enter(object sender, EventArgs e)
        {
            if (txtCorreoProveedor.Text == "proveedor@mail.com")
            {
                txtCorreoProveedor.Text = "";

                txtCorreoProveedor.ForeColor = Color.Black;
            }
        }

        private void txttelefonoProveedor_Leave(object sender, EventArgs e)
        {
            if (txttelefonoProveedor.Text == "")
            {
                txttelefonoProveedor.Text = "xxxx-xxxx";

                txttelefonoProveedor.ForeColor = Color.Silver;
            }
        }

        private void txttelefonoProveedor_Enter(object sender, EventArgs e)
        {
            if (txttelefonoProveedor.Text == "xxxx-xxxx")
            {
                txttelefonoProveedor.Text = "";

                txttelefonoProveedor.ForeColor = Color.Black;
            }
        }

        private void txtDireccionProveedor_Leave(object sender, EventArgs e)
        {
            if (txtDireccionProveedor.Text == "")
            {
                txtDireccionProveedor.Text = "Direccion del Proveedor";

                txtDireccionProveedor.ForeColor = Color.Silver;
            }
        }

        private void txtDireccionProveedor_Enter(object sender, EventArgs e)
        {
            if (txtDireccionProveedor.Text == "Direccion del Proveedor")
            {
                txtDireccionProveedor.Text = "";

                txtDireccionProveedor.ForeColor = Color.Black;
            }
        }

        private void FormProveedoresInserta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNombreProveedor.Text) ||
                    string.IsNullOrEmpty(txtCorreoProveedor.Text) ||
                    string.IsNullOrEmpty(txttelefonoProveedor.Text) ||
                    string.IsNullOrEmpty(txtDireccionProveedor.Text))
                {
                    MessageBox.Show("Campos vacios \n Intentelo nuevamente","Aviso");

                }

                else
                {

                    if ((txtNombreProveedor.Text == "Nombre del Proveedor") ||
                        (txtCorreoProveedor.Text == "proveedor@mail.com") ||
                        (txttelefonoProveedor.Text == "xxxx-xxxx") ||
                        (txtDireccionProveedor.Text == "Direccion del Proveedor"))
                    {
                        MessageBox.Show("Campos vacios \n Intentelo nuevamente","Aviso");
                    }
                    else
                    {

                        try
                        {
                            Backend.Entities.Proveedores proveedores = new Backend.Entities.Proveedores();
                            proveedores.NombreProveedor = txtNombreProveedor.Text;
                            proveedores.Correo = txtCorreoProveedor.Text;
                            proveedores.Telefono = txttelefonoProveedor.Text;
                            proveedores.Direccion = txtDireccionProveedor.Text;
                            proveedorDAL.addProveedor(proveedores);
                            MessageBox.Show("Proveedor agregado con exito","Confirmacion");
                            this.Close();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hubo un error \n Intentelo nuevamente","Error");

                            return;
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void obtenerIDTabla(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
