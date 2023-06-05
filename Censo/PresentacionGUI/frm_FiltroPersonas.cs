using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class frm_FiltroPersonas : Form
    {
        Logica.ServicioPersona Persona = new Logica.ServicioPersona(configConnnection.ConnectionString);
        public frm_FiltroPersonas()
        {
            InitializeComponent();
        }

        private void frm_FiltroPersonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbCensoDataSet1.Persona' Puede moverla o quitarla según sea necesario.
            this.personaTableAdapter.Fill(this.dbCensoDataSet1.Persona);

        }

        private void Txt_Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            personaDataGridView.DataSource = Persona.GetBy("Documento", Txt_FiltroId.Text);            
        }

        private void Txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_FiltroNombre_KeyUp(object sender, KeyEventArgs e)
        {
            personaDataGridView.DataSource = Persona.GetBy("Nombre",Txt_FiltroNombre.Text); ;
        }

        private void Txt_FiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GetBySectores_Click(object sender, EventArgs e)
        {
            personaDataGridView.DataSource = Persona.GetBy("Sectores_Completados", "Completado");
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCensoDataSet1);

        }
    }
}
