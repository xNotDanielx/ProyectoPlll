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
        Form_InicioSesion fi = new Form_InicioSesion();
        Form_Registrar fr = new Form_Registrar();
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
            String Usuario = "Admin";
            String Contraseña = "Admin";            
            if (Txt_Admin.Text == Usuario && Txt_ContraAdmin.Text == Contraseña)
            {
                Txt_Admin.Text = "";
                Txt_ContraAdmin.Text = "";
                Abrir_Forms(new Administrador());
                
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
    }
}
