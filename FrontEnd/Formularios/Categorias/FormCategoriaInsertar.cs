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

namespace FrontEnd.Formularios.Categorias
{
    public partial class FormCategoriaInsertar : Form
    {

        private ICategoriasDAL categoriasDAL = new CategoriaDALImpl();
       
        public FormCategoriaInsertar()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtDescripcion.Text ==  "Descripcion de la Categoria")
                {

                    MessageBox.Show("Debe completar la descripcion de la categoria a ingresar","Aviso");

                    return;
                }
                else
                {
                    try
                    {
                        Backend.Entities.Categorias categorias = new Backend.Entities.Categorias();
                        categorias.Descripcion = txtDescripcion.Text;
                        categoriasDAL.addCategoria(categorias);
                        MessageBox.Show("Categoria agregada con exito","Aviso");
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

                MessageBox.Show("Hubo un error","Error");
            }



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

        private void txtDescripcion_Enter_1(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion de la Categoria")
            {
                txtDescripcion.Text = "";

                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave_1(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion de la Categoria";

                txtDescripcion.ForeColor = Color.Silver;
            }

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCategoriaInsertar_Enter(object sender, EventArgs e)
        {

        }

        private void FormCategoriaInsertar_Load(object sender, EventArgs e)
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
                if (txtDescripcion.Text == "Descripcion de la Categoria")
                {

                    MessageBox.Show("Debe completar la descripcion de la categoria a ingresar", "Aviso");

                    return;
                }
                else
                {
                    try
                    {
                        Backend.Entities.Categorias categorias = new Backend.Entities.Categorias();
                        categorias.Descripcion = txtDescripcion.Text;
                        categoriasDAL.addCategoria(categorias);
                        MessageBox.Show("Categoria agregada con exito", "Aviso");
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

                MessageBox.Show("Hubo un error", "Error");
            }


        }
    }
}
