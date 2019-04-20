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

namespace FrontEnd.Formularios.EstadoActivos
{
    public partial class FormEstadoActivoInserta : Form
    {
        IEstadoActivosDAL estadoActivosDAL = new EstadoActivosDALImpl();

        public FormEstadoActivoInserta()
        {
            InitializeComponent();
        }







        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion del Estado")
            {
                txtDescripcion.Text = "";

                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion del Estado";

                txtDescripcion.ForeColor = Color.Silver;
            }
        }

        private void FormEstadoActivoInserta_Load(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDescripcion.Text == "Descripcion del Estado")
                {

                    MessageBox.Show("Campo estado del Activo vacío \n Intentelo nuevamente", "Aviso");

                }
                else
                {
                    try
                    {
                        Backend.Entities.EstadoActivos estadoActivos = new Backend.Entities.EstadoActivos();
                        estadoActivos.NombreEstado = txtDescripcion.Text;
                        estadoActivosDAL.addEstadoActivos(estadoActivos);
                        MessageBox.Show("Estado agregado con exito","Aviso");
                        this.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error \n Intentelo nuevamente","Error");

                        return;
                    }




                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error ", "Error");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDescripcion.Text == "Descripcion del Estado")
                {

                    MessageBox.Show("Campo estado del Activo vacío \n Intentelo nuevamente", "Aviso");

                }
                else
                {
                    try
                    {
                        Backend.Entities.EstadoActivos estadoActivos = new Backend.Entities.EstadoActivos();
                        estadoActivos.NombreEstado = txtDescripcion.Text;
                        estadoActivosDAL.addEstadoActivos(estadoActivos);
                        MessageBox.Show("Estado agregado con exito", "Aviso");
                        this.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un error \n Intentelo nuevamente", "Error");

                        return;
                    }




                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error ", "Error");
            }
        }
    }
}
