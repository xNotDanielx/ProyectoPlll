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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            btn_VentanaMax.Visible = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_VentanaMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_VentanaMax.Visible = false;
            btn_VentanaMin.Visible = true;
        }

        private void btn_VentanaMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_VentanaMax.Visible = true;
            btn_VentanaMin.Visible = false;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
