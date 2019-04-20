using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Backend.Entities;
using Frontend;
using Backend.DAL;

namespace FrontEnd
{
    public partial class FrmLogin2 : Form
    {
        BDContext context;
        public FrmLogin2()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public IUsuariosDAL usuariosDal = new UsuariosImplDAL();
        CryptoEngine cryptoEngine = new CryptoEngine();
        public Usuarios user;
        int contadorIntentos = 0;

        private void showInfo(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        private void tbxUserId_Enter(object sender, EventArgs e)
        {
            if (tbxUserId.Text == "USUARIO")
            {
                tbxUserId.Text = "";
                tbxUserId.ForeColor = Color.LightGray;
            }
        }

        private void tbxUserId_Leave(object sender, EventArgs e)
        {
            if (tbxUserId.Text == "")
            {
                tbxUserId.Text = "USUARIO";
                tbxUserId.ForeColor = Color.DimGray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "CONTRASEÑA")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = Color.LightGray;
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxPassword.Text = "CONTRASEÑA";
                tbxPassword.ForeColor = Color.DimGray;
                tbxPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin2_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIng_Click_1(object sender, EventArgs e)
        {
            contadorIntentos = contadorIntentos + 1;
            int i = 0;
            int id = -1;
            string pass;
            if ((!string.IsNullOrEmpty(tbxUserId.Text) && !int.TryParse(tbxUserId.Text, out i)) || string.IsNullOrEmpty(tbxUserId.Text) || string.IsNullOrWhiteSpace(tbxUserId.Text))
            {
                showInfo("El campo de Id usuario vacio o con formato equivocado! \nPor favor ingrese unicamente numeros!");
                tbxUserId.Clear();
                if (contadorIntentos > 5)
                {
                    showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                    Close();
                }
            }
            else
            {
                id = int.Parse(tbxUserId.Text);

                if (string.IsNullOrWhiteSpace(tbxPassword.Text) || string.IsNullOrEmpty(tbxPassword.Text))
                {
                    showInfo("El campo de Password se encuentra vacio! \nPor favor ingrese su Password!");
                    if (contadorIntentos > 5)
                    {
                        showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                        Close();
                    }
                }
                else
                {
                    pass = cryptoEngine.Encrypt(tbxPassword.Text);

                    /*user = usuariosDal.GetUsuario(id);*/
                    //showInfo("Password: " + tbxPassword.Text + " Encryptada: " + pass);
                    /*Validanado usuario*/
                    if (usuariosDal.isRealUser(id))
                    {

                        if (usuariosDal.isValidPassword(pass, id))
                        {
                            try
                            {
                                int? id2 = Convert.ToInt32(tbxUserId.Text);
                                string password2 = tbxPassword.Text;

                                using (context = new BDContext())
                                {
                                    int? rol = context.sp_RetornaRolUsuario(id2, password2).FirstOrDefault() ?? -1;


                                    if (rol == 1)
                                    {

                                        //CARGA EL FORM PRINCIPAL DE USUARIO ADMINISTRADOR
                                        this.Hide();
                                        Inicio form = new Inicio();
                                        form.ShowDialog();
                                        form.Dispose();
                                        this.Show();


                                    }
                                    else
                                    {

                                        //CARGA EL FORM PRINCIPAL DE UN USUARIO NORMAL
                                        this.Hide();
                                        InicioNoAdmin form = new InicioNoAdmin();
                                        form.ShowDialog();
                                        form.Dispose();
                                        this.Show();
                                    }
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("" + ex);
                            }

                        }
                        else
                        {
                            tbxUserId.Clear();
                            tbxPassword.Clear();
                            MessageBox.Show("Los datos ingresados no son correctos! \nPor favor ingrese sus datos!", "Error");
                            tbxUserId.Text = "";
                            tbxPassword.Text = "";
                            
                            if (contadorIntentos > 5)
                            {
                                showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                                Close();
                            }
                        }
                    }
                    else
                    {
                        tbxUserId.Clear();
                        tbxPassword.Clear();
                        showInfo("Los datos ingresados no son correctos! \nPor favor ingrese sus datos!");
                        if (contadorIntentos > 5)
                        {
                            showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                            Close();
                        }
                    }
                }
            }
        }
    }
}
