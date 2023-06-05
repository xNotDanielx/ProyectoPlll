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
    public partial class Frm_ListaCuentas : Form
    {
        Login PersonaLog = new Login();
        ServicioLogin sl = new ServicioLogin(configConnnection.ConnectionString);
        int posx = 0;
        int posy = 0;
        public Frm_ListaCuentas()
        {
            InitializeComponent();
        }

        private void loguinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loguinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCensoDataSet);

        }

        private void Frm_ListaCuentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbCensoDataSet.Loguin' Puede moverla o quitarla según sea necesario.
            this.loguinTableAdapter.Fill(this.dbCensoDataSet.Loguin);

        }

        private void loguinBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.loguinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCensoDataSet);

        }

        private void loguinBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.loguinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCensoDataSet);

        }

        private void loguinBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.loguinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCensoDataSet);

        }

        private void loguinBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.loguinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCensoDataSet);

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
    }
}
