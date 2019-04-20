﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FrontEnd;
using FrontEnd.Formularios.Proveedores;
using FrontEnd.Formularios;

namespace Frontend
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            inicializarComponentes();
        }

        private void inicializarComponentes()
        {
            this.menuVertical.Width = 250;
            this.meserosBtn.Width = 246;
            this.facturasBtn.Width = 246;
            this.mesasBtn.Width = 246;
            this.ordenBtn.Width = 246;
            this.productosBtn.Width = 246;
            this.categoriasBtn.Width = 246;
            this.btnAgregarProducto.Width = 246;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 250)
            {
                menuVertical.Width = 55;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        private void cerrarIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizarIcon_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                restaurarIcon.Visible = true;
                maximizarIcon.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void restaurarIcon_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Normal;
                restaurarIcon.Visible = false;
                maximizarIcon.Visible = true;

            }
            catch (Exception)
            {

                throw;
            };
        }

        private void colapsarMenuIcon_Click(object sender, EventArgs e)
        {
            try
            {
                menuVertical.Width = 55;
                menuIcon.Visible = true;
                colapsarMenuIcon.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            try
            {
                menuVertical.Width = 250;
                menuIcon.Visible = false;
                colapsarMenuIcon.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void abrirFormInPanel(object FormHijo)
        {
            try
            {
                if (this.contentPnl.Controls.Count > 0)
                {
                    this.contentPnl.Controls.RemoveAt(0);
                    Form fh = FormHijo as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.contentPnl.Controls.Add(fh);
                    this.contentPnl.Tag = fh;
                    fh.Show();
                }
                else
                {
                    Form fh = FormHijo as Form;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    this.contentPnl.Controls.Add(fh);
                    this.contentPnl.Tag = fh;
                    fh.Show();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Un error");
            }
        }

        private void meserosBtn_Click(object sender, EventArgs e)
        {
           // abrirFormInPanel(new Meseros());
        }

        private void productosBtn_Click(object sender, EventArgs e)
        {
          //  abrirFormInPanel(new Productos());
        }

        private void ordenBtn_Click(object sender, EventArgs e)
        {
           // abrirFormInPanel(new Ordenes());
        }

        private void facturasBtn_Click(object sender, EventArgs e)
        {
           // abrirFormInPanel(new Facturas());
        }

        private void mesasBtn_Click(object sender, EventArgs e)
        {
           // abrirFormInPanel(new Mesas());
        }

        private void categoriasBtn_Click(object sender, EventArgs e)
        {
           // abrirFormInPanel(new Categorias());
        }

        private void contentPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new FormProveedores());
        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //CERRAR SESSION

            this.Hide();
            FrmLogin2 login = new FrmLogin2();
            login.ShowDialog();
            login.Dispose();
            this.Show();

        }
    }
}
