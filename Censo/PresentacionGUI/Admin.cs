using Datos;
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
    public partial class Admin : Form
    {
        
        ServicioPersona persona = new ServicioPersona(configConnnection.ConnectionString);
        public Admin()
        {
            InitializeComponent();
            MostrarCuentasRegistradas();
        }

        public void MostrarCuentasRegistradas() 
        {
            Lbl_CuentasRegistradas.Text = "Cuentas Registradas: " + persona.Cuentas_Registradas().ToString();            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_ListaCuentas listaC = new Frm_ListaCuentas();
            listaC.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_FiltroPersonas listaP = new frm_FiltroPersonas();
            listaP.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Graficas fg = new Frm_Graficas();
            fg.Show();
        }
    }
}
