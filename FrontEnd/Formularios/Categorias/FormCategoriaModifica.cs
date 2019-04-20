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

namespace FrontEnd.Formularios.Categorias
{
    public partial class FormModificaCategoria : Form
    {

        private ICategoriasDAL categoriasDAL = new CategoriaDALImpl();
  
        Backend.Entities.Categorias categorias;

        public FormModificaCategoria()
        {
            InitializeComponent();
        }

        private void FormModificaCategoria_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'categoriaDataset.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.categoriaDataset.Categorias);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbIdActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbIdCategoria.Text;
            int id2 = Convert.ToInt32(id);
            categorias = categoriasDAL.obtenerCategoriaPorID(id2);
            txtDescripcion_.Text = categorias.Descripcion;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtDescripcion_.Text))
                {
                    MessageBox.Show("Descripcion de la categoria vacío","Aviso");

                    return;
                }
                else
                {
                    try
                    {
                        categorias.IdCategoria = Convert.ToInt32(cmbIdCategoria.SelectedValue);
                        categorias.Descripcion = txtDescripcion_.Text;
                        categoriasDAL.updateCategoria(categorias);
                        MessageBox.Show("Categoria modificada","Aviso");
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

        private void cmbIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
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
                if (string.IsNullOrEmpty(txtDescripcion_.Text))
                {
                    MessageBox.Show("Descripcion de la categoria vacío", "Aviso");

                    return;
                }
                else
                {
                    try
                    {
                        categorias.IdCategoria = Convert.ToInt32(cmbIdCategoria.SelectedValue);
                        categorias.Descripcion = txtDescripcion_.Text;
                        categoriasDAL.updateCategoria(categorias);
                        MessageBox.Show("Categoria modificada", "Aviso");
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
