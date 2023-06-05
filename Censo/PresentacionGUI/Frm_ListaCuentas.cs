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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionGUI
{
    public partial class Frm_ListaCuentas : Form
    {

        Login PersonaLog = new Login();
        Persona persona = new Persona();
        Sector_Economico SE = new Sector_Economico();
        Sector_Hogar SH = new Sector_Hogar();
        Sector_Social SS = new Sector_Social();
        ServicioLogin sl = new ServicioLogin(configConnnection.ConnectionString);
        ServicioPersona sp = new ServicioPersona(configConnnection.ConnectionString);
        ServicioSE logicaSE = new ServicioSE(configConnnection.ConnectionString);
        ServicioSH logicaSH = new ServicioSH(configConnnection.ConnectionString);
        ServicioSS logicaSS = new ServicioSS(configConnnection.ConnectionString);
        int posx = 0;
        int posy = 0;
        public Frm_ListaCuentas()
        {
            InitializeComponent();
        }

        private void Frm_ListaCuentas_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ActualizarInfo_Click(object sender, EventArgs e)
        {
            if (CbAdmin.Checked == true)
            {
                PersonaLog.Admin = true;
            }
            else
            {
                PersonaLog.Admin = false;
            }
            PersonaLog.Numero_Documento = Txt_Documento.Text;
            PersonaLog.Contraseña = Txt_Contraseña.Text;
            PersonaLog.Tipo_Documento = Txt_TipoDocumento.Text;
            sl.Update(PersonaLog);
        }

        private void Txt_CuentasRegistradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void Frm_ListaCuentas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button!= MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void Txt_FiltroId_KeyUp(object sender, KeyEventArgs e)
        {
            loguinDataGridView.DataSource = sl.GetBy("Numero_Documento", Txt_FiltroId.Text);
        }

        private void loguinDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = loguinDataGridView.Rows[e.RowIndex];

                CbAdmin.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Admin"].Value);
                Txt_Documento.Text = filaSeleccionada.Cells["Numero_Documento"].Value.ToString();
                Txt_Contraseña.Text = filaSeleccionada.Cells["Contraseña"].Value.ToString();
                Txt_TipoDocumento.Text = filaSeleccionada.Cells["Tipo_Documento"].Value.ToString();                
            }
        }

        private void Btn_EliminarInfo_Click(object sender, EventArgs e)
        {
            if (CbAdmin.Checked == true)
            {
                PersonaLog.Admin = true;
            }
            else
            {
                PersonaLog.Admin = false;
            }
            PersonaLog.Numero_Documento = Txt_Documento.Text;
            PersonaLog.Contraseña = Txt_Contraseña.Text;
            PersonaLog.Tipo_Documento = Txt_TipoDocumento.Text;
            sl.Delete(PersonaLog);
            persona.Documento = PersonaLog.Numero_Documento;
            SE.Documento = PersonaLog.Numero_Documento;
            SH.Documento = PersonaLog.Numero_Documento;
            SS.Documento = PersonaLog.Numero_Documento;
            sp.Delete(persona);
            logicaSE.Delete(SE);
            logicaSH.Delete(SH);
            logicaSS.Delete(SS);
        }
    }
}
