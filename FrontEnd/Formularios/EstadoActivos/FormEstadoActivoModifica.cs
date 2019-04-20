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
    public partial class FormEstadoActivoModifica : Form
    {

        IEstadoActivosDAL EstadoActivosDAL = new EstadoActivosDALImpl();
        Backend.Entities.EstadoActivos estadoActivos;


        public FormEstadoActivoModifica()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbIdEstadoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbIdEstadoActivo.Text;
            int id2 = Convert.ToInt32(id);
            estadoActivos = EstadoActivosDAL.obtenerEstadoActivosPorID(id2);
            txtNombreEstado.Text = estadoActivos.NombreEstado;
        }

        private void FormEstadoActivoModifica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estadoActivosDataSet.EstadoActivos' Puede moverla o quitarla según sea necesario.
            this.estadoActivosTableAdapter.Fill(this.estadoActivosDataSet.EstadoActivos);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNombreEstado.Text))
                {
                    MessageBox.Show("Nombre del estado vacío","Aviso");

                    return;
                }
                else
                {
                    try
                    {
                        estadoActivos.IdEstadoActivo = Convert.ToInt32(cmbIdEstadoActivo.SelectedValue);
                        estadoActivos.NombreEstado = txtNombreEstado.Text;
                        EstadoActivosDAL.updateEstadoActivos(estadoActivos);
                        MessageBox.Show("Estado activo modificado","Confirmacion");
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

        private void cmbIdEstadoActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void obtenerIDTabla(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNombreEstado.Text))
                {
                    MessageBox.Show("Nombre del estado vacío", "Aviso");

                    return;
                }
                else
                {
                    try
                    {
                        estadoActivos.IdEstadoActivo = Convert.ToInt32(cmbIdEstadoActivo.SelectedValue);
                        estadoActivos.NombreEstado = txtNombreEstado.Text;
                        EstadoActivosDAL.updateEstadoActivos(estadoActivos);
                        MessageBox.Show("Estado activo modificado", "Confirmacion");
                        this.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Hubo un error", "Error");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


