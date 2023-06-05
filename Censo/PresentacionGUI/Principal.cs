using Datos;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class Principal : Form
    {
        ServicioLogin sl = new ServicioLogin(configConnnection.ConnectionString);
        Form_InicioSesion fi = new Form_InicioSesion();
        Form_Registrar fr = new Form_Registrar();
        Formulario_Encuestas fe = new Formulario_Encuestas();
        Frm_ListaCuentas lc = new Frm_ListaCuentas();
        Admin admin = new Admin();
        public Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            Btn_VentanaMin.Visible = false;
            Box_Login.Visible = false;
        }

        public void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void cerrarAnterior()
        {
            this.Hide();
        }

        public void Btn_VentanaMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Btn_VentanaMax.Visible = false;
            Btn_VentanaMin.Visible = true;
        }

        public void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Btn_VentanaMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btn_VentanaMax.Visible = true;
            Btn_VentanaMin.Visible = false;
        }

        public void Barra_Lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Btn_Login_Click(object sender, EventArgs e)
        {
            Box_Login.Visible = true;
        }

        public void Abrir_Forms(object formhija)
        {
            
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        public void Inicio()
        {
            this.Panel_Contenedor.Controls.Clear();
        }

        public void Btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            Box_Login.Visible = false;
            Abrir_Forms(new Form_InicioSesion());
        }

        public void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            Box_Login.Visible = false;
            Abrir_Forms(new Form_Registrar());
        }

        public void Box_Principal_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        public void Btn_QueesCenso_Click(object sender, EventArgs e)
        {
            Abrir_Forms(new Que_Es_Censo());
        }

        private void Btn_Login_Admin_Click(object sender, EventArgs e)
        {
            bool Ver_Admin=false;
            var login = new Login();
            login.Numero_Documento = Txt_Admin.Text; 
            login.Contraseña = Txt_ContraAdmin.Text;
            if (sl.Buscar_Cuenta(login) == true)
            {
                foreach (Login personaLog in sl.Obtener_Informacion(login))
                {
                    Ver_Admin = personaLog.Admin;
                }
                if (Ver_Admin == true)
                {
                    Picture_Error1.Visible = false;
                    Picture_Error2.Visible = false;
                    Picture_Error3.Visible = false;
                    Picture_Error4.Visible = false;
                    Txt_Admin.Text = "";
                    Txt_ContraAdmin.Text = "";
                    Abrir_Forms(new Admin());
                }
                else
                {
                    Picture_Error1.Visible = false;
                    Picture_Error2.Visible = false;
                    Picture_Error3.Visible = true;
                    Picture_Error4.Visible = true;
                }
            }
            else if(Txt_Admin.Text=="" || Txt_ContraAdmin.Text =="")
            {
                Picture_Error1.Visible = true;
                Picture_Error2.Visible = true;
                Picture_Error3.Visible = false;
                Picture_Error4.Visible = false;
            }
            else
            {
                Picture_Error1.Visible = false;
                Picture_Error2.Visible = false;
                Picture_Error3.Visible = true;
                Picture_Error4.Visible = true;
            }
        }
        private void Btn_Administrador_Click(object sender, EventArgs e)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Panel_Contenedor.Controls.Add(panel_Login_Admin);
            panel_Login_Admin.Visible = true;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            panel_Login_Admin.Visible = false;
        }

        private void Txt_ContraAdmin_TextChanged(object sender, EventArgs e)
        {
            Txt_ContraAdmin.UseSystemPasswordChar = true;
            Txt_ContraAdmin.PasswordChar = '*';
        }
    }
}
