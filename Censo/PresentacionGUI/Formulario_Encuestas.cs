using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class Formulario_Encuestas : Form
    {
        Sector_Economico SE = new Sector_Economico();
        Sector_Social SS = new Sector_Social();
        Sector_Hogar SH = new Sector_Hogar();
        Persona persona = new Persona();
        ServicioSE logicaSE = new ServicioSE();
        ServicioSH logicaSH = new ServicioSH();
        ServicioSS logicaSS = new ServicioSS();

        public Formulario_Encuestas()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool Pregunta1 = false;
        bool Pregunta2 = false;
        bool Pregunta3 = false;
        bool Pregunta4 = false;
        bool Pregunta5 = false;
        bool Pregunta6 = false;
        bool Pregunta7 = false;
        bool Pregunta8 = false;
        bool Pregunta9 = false;
        bool Pregunta10 = false;
        bool Pregunta11 = false;
        bool Pregunta12 = false;
        bool Pregunta13 = false;
        bool Pregunta14 = false;
        bool Pregunta15 = false;
        bool SE_Completado = false;
        bool SH_Completado = false;
        bool SS_Completado = false;
        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            if ((SE_Completado == false)&& (SH_Completado == false) && (SS_Completado == false))
             {
                Pregunta1SE();
                Pregunta2SE();
                Pregunta3SE();
                Pregunta4SE();
                Pregunta5SE();
                Pregunta6SE();
                Pregunta7SE();
                Pregunta8SE();
                Pregunta9SE();
                Pregunta10SE();
                Verificar_SectorE();
                
            }
             else if ((SE_Completado == true) && (SH_Completado == false) && (SS_Completado == false))
            {
                Pregunta1SH();
                Pregunta2SH();
                Pregunta3SH();
                Pregunta4SH();
                Pregunta5SH();
                Pregunta6SH();
                Pregunta7SH();
                Pregunta8SH();
                Pregunta9SH();
                Pregunta10SH();
                Pregunta11SH();
                Pregunta12SH();
                Pregunta13SH();
                Pregunta14SH();
                Pregunta15SH();
                Verificar_SectorH();


            }
            /*else if((SE_Completado == true)&& (SH_Completado == true) && (SS_Completado == false))
            {
                Pregunta1SS();
                Pregunta2SS();
                Pregunta3SS();
                Pregunta4SS();
                Pregunta5SS();
                Pregunta6SS();
                Pregunta7SS();
                Pregunta8SS();
                Pregunta9SS();
                Pregunta10SS();
                Verificar_SectorSS();
            }
            else
            {
                Verificar_Sectores();
            }*/
        }
        //Preguntas del Sector Economico
        public void Pregunta1SE()
        {
            try
            {
                if (Si_Pregunta1SE.Checked)
                {
                    Pregunta1 = true;
                }
                else if(No_Pregunta1SE.Checked)
                {
                    Pregunta1 = true;
                }
                else
                {
                    Si_Pregunta1SE.BackColor = Color.Red;
                    No_Pregunta1SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }
            
        }
        public void Pregunta2SE()
        {
            try
            {
                if (Si_Pregunta2SE.Checked)
                {
                    Pregunta2 = true;
                }
                else if (No_Pregunta2SE.Checked)
                {
                    Pregunta2 = true;
                }
                else
                {
                    Si_Pregunta2SE.BackColor = Color.Red;
                    No_Pregunta2SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }
        public void Pregunta3SE()
        {
            try
            {
                if (Si_Pregunta3SE.Checked)
                {
                    Pregunta3 = true;
                }
                else if (No_Pregunta3SE.Checked)
                {
                    Pregunta3 = true;
                }
                else
                {
                    Si_Pregunta3SE.BackColor = Color.Red;
                    No_Pregunta3SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta4SE()
        {
            try
            {
                if (Si_Pregunta4SE.Checked)
                {
                    Pregunta4 = true;
                }
                else if (No_Pregunta4SE.Checked)
                {
                    Pregunta4 = true;
                }
                else
                {
                    Si_Pregunta4SE.BackColor = Color.Red;
                    No_Pregunta4SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta5SE()
        {
            try
            {
                if (Si_Pregunta5SE.Checked)
                {
                    Pregunta5 = true;
                }
                else if (No_Pregunta5SE.Checked)
                {
                    Pregunta5 = true;
                }
                else
                {
                    Si_Pregunta5SE.BackColor = Color.Red;
                    No_Pregunta5SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta6SE()
        {
            try
            {
                if (Si_Pregunta6SE.Checked)
                {
                    Pregunta6 = true;
                }
                else if (No_Pregunta6SE.Checked)
                {
                    Pregunta6 = true;
                }
                else
                {
                    Si_Pregunta6SE.BackColor = Color.Red;
                    No_Pregunta6SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }
        public void Pregunta7SE()
        {
            try
            {
                if (Si_Pregunta7SE.Checked)
                {
                    Pregunta7 = true;
                }
                else if (No_Pregunta7SE.Checked)
                {
                    Pregunta7 = true;
                }
                else
                {
                    Si_Pregunta7SE.BackColor = Color.Red;
                    No_Pregunta7SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }
        public void Pregunta8SE()
        {
            try
            {
                if (Si_Pregunta8SE.Checked)
                {
                    Pregunta8 = true;
                }
                else if (No_Pregunta8SE.Checked)
                {
                    Pregunta8 = true;
                }
                else
                {
                    Si_Pregunta8SE.BackColor = Color.Red;
                    No_Pregunta8SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }
        public void Pregunta9SE()
        {
            try
            {
                if (Si_Pregunta9SE.Checked)
                {
                    Pregunta9 = true;
                }
                else if (No_Pregunta9SE.Checked)
                {
                    Pregunta9 = true;
                }
                else
                {
                    Si_Pregunta9SE.BackColor = Color.Red;
                    No_Pregunta9SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }
        public void Pregunta10SE()
        {
            try
            {
                if (Si_Pregunta10SE.Checked)
                {
                    Pregunta10 = true;
                }
                else if (No_Pregunta10SE.Checked)
                {
                    Pregunta10 = true;
                }
                else
                {
                    Si_Pregunta10SE.BackColor = Color.Red;
                    No_Pregunta10SE.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        //Preguntas del Sector Hogar
        public void Pregunta1SH()
        {
            try
            {
                if(Si_Pregunta1SH.Checked)
                {
                    Pregunta1 = true;
                }
                else if (No_Pregunta1SH.Checked)
                {
                    Pregunta1 = true;
                }
                else
                {
                    Si_Pregunta1SH.BackColor = Color.Red;
                    No_Pregunta1SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }
        public void Pregunta2SH()
        {
            try
            {
                if (Si_Pregunta2SH.Checked)
                {
                    Pregunta2 = true;
                }
                else if (No_Pregunta2SH.Checked)
                {
                    Pregunta2 = true;
                }
                else
                {
                    Si_Pregunta2SH.BackColor = Color.Red;
                    No_Pregunta2SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta3SH()
        {
            try
            {
                if (Si_Pregunta3SH.Checked)
                {
                    Pregunta3 = true;
                }
                else if (No_Pregunta3SH.Checked)
                {
                    Pregunta3 = true;
                }
                else
                {
                    Si_Pregunta3SH.BackColor = Color.Red;
                    No_Pregunta3SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta4SH()
        {
            try
            {
                if (Si_Pregunta4SH.Checked)
                {
                    Pregunta4 = true;
                }
                else if (No_Pregunta4SH.Checked)
                {
                    Pregunta4 = true;
                }
                else
                {
                    Si_Pregunta4SH.BackColor = Color.Red;
                    No_Pregunta4SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta5SH()
        {
            try
            {
                if (Si_Pregunta5SH.Checked)
                {
                    Pregunta5 = true;
                }
                else if (No_Pregunta5SH.Checked)
                {
                    Pregunta5 = true;
                }
                else
                {
                    Si_Pregunta5SH.BackColor = Color.Red;
                    No_Pregunta5SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta6SH()
        {
            try
            {
                if (Si_Pregunta6SH.Checked)
                {
                    Pregunta6 = true;
                }
                else if (No_Pregunta6SH.Checked)
                {
                    Pregunta6 = true;
                }
                else
                {
                    Si_Pregunta6SH.BackColor = Color.Red;
                    No_Pregunta6SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta7SH()
        {
            try
            {
                if (Si_Pregunta7SH.Checked)
                {
                    Pregunta7 = true;
                }
                else if (No_Pregunta7SH.Checked)
                {
                    Pregunta7 = true;
                }
                else
                {
                    Si_Pregunta7SH.BackColor = Color.Red;
                    No_Pregunta7SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta8SH()
        {
            try
            {
                if (Si_Pregunta8SH.Checked)
                {
                    Pregunta8 = true;
                }
                else if (No_Pregunta8SH.Checked)
                {
                    Pregunta8 = true;
                }
                else
                {
                    Si_Pregunta8SH.BackColor = Color.Red;
                    No_Pregunta8SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta9SH()
        {
            try
            {
                if (Si_Pregunta9SH.Checked)
                {
                    Pregunta9 = true;
                }
                else if (No_Pregunta9SH.Checked)
                {
                    Pregunta9 = true;
                }
                else
                {
                    Si_Pregunta9SH.BackColor = Color.Red;
                    No_Pregunta9SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta10SH()
        {
            try
            {
                if (Si_Pregunta10SH.Checked)
                {
                    Pregunta10 = true;
                }
                else if (No_Pregunta10SH.Checked)
                {
                    Pregunta10 = true;
                }
                else
                {
                    Si_Pregunta10SH.BackColor = Color.Red;
                    No_Pregunta10SH.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta11SH()
        {
            try
            {
                if (Opc_Urbano.Checked)
                {
                    Opc_Urbano.ForeColor = Color.Black;
                    Opc_Urbano.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else if (Opc_Rural.Checked)
                {
                    Opc_Urbano.ForeColor = Color.Black;
                    Opc_Rural.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else
                {
                    Opc_Urbano.ForeColor = Color.Red;
                    Opc_Rural.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta12SH()
        {
            try
            {
                if(txt_Habitaciones.Text=="")
                {
                    txtHabitaciones.ForeColor = Color.Red;
                    Pregunta12 = true;
                }
                else
                {
                    txtHabitaciones.ForeColor = Color.Black;
                    // txt_Habitaciones.Text =
                }
            }

            catch
            {

            }
        }
        public void Pregunta13SH()
        {
            try
            {
                if (txt_Baños.Text == "")
                {
                    txt_Baños.ForeColor = Color.Red;
                    Pregunta13 = true;
                }
                else
                {
                    txt_Baños.ForeColor = Color.Black;
                    // txt_Baños.Text =
                }
            }

            catch
            {

            }
        }
        public void Pregunta14SH()
        {
            try
            {
                if (Opc_Propia.Checked)
                {
                    Opc_Propia.ForeColor = Color.Black;
                    Opc_Alquilada.ForeColor = Color.Black;
                    Pregunta14 = true;
                }
                else if (Opc_Alquilada.Checked)
                {
                    Opc_Propia.ForeColor = Color.Black;
                    Opc_Alquilada.ForeColor = Color.Black;
                    Pregunta14 = true;
                }
                else
                {
                    Opc_Propia.ForeColor = Color.Red;
                    Opc_Alquilada.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta15SH()
        {
            try
            {
                if (Opc_Bajo.Checked)
                {
                    Opc_Bajo.ForeColor = Color.Black;
                    Opc_Medio.ForeColor = Color.Black;
                    Opc_Alto.ForeColor = Color.Black;
                    Pregunta15 = true;
                }
                else if (Opc_Medio.Checked)
                {
                    Opc_Bajo.ForeColor = Color.Black;
                    Opc_Medio.ForeColor = Color.Black;
                    Opc_Alto.ForeColor = Color.Black;
                    Pregunta15 = true;
                }
                else if(Opc_Alto.Checked)
                {
                    Opc_Bajo.ForeColor = Color.Black;
                    Opc_Medio.ForeColor = Color.Black;
                    Opc_Alto.ForeColor = Color.Black;
                    Pregunta15 = true;
                }
                else
                {
                    Opc_Bajo.ForeColor = Color.Red;
                    Opc_Medio.ForeColor = Color.Red;
                    Opc_Alto.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        //Preguntas del Sector Social
        public void Pregunta1SS()
        {
        }
        public void Pregunta2SS()
        {

        }
        public void Pregunta3SS()
        {

        }
        public void Pregunta4SS()
        {
        }
        public void Pregunta5SS()
        {

        }
        public void Pregunta6SS()
        {

        }
        public void Pregunta7SS()
        {

        }
        public void Pregunta8SS()
        {

        }
        public void Pregunta9SS()
        {

        }
        public void Pregunta10SS()
        {

        }
        public void Verificar_SectorE()
        {
            if((Pregunta1==true) && (Pregunta2 == true) && (Pregunta3 == true) && (Pregunta4 == true) && (Pregunta5 == true) && (Pregunta6 == true) && (Pregunta7 == true) && (Pregunta8 == true) && (Pregunta9 == true) && (Pregunta10 == true))
            {
                SectorSi_SectorE.Visible = true;
                Panel_SH.Visible = true;
                Btn_Volver.Visible = true;
                SE_Completado = true;
                Pregunta1 = false;
                Pregunta2 = false;
                Pregunta3 = false;
                Pregunta4 = false;
                Pregunta5 = false;
                Pregunta6 = false;
                Pregunta7 = false;
                Pregunta8 = false;
                Pregunta9 = false;
                Pregunta10 = false;
                Pregunta11 = false;
                Pregunta12= false;
                Pregunta13= false;
                Pregunta14 = false;
                Pregunta15 = false;
                SH_Completado = false;
                SS_Completado = false;

            }
        }
        public void Verificar_SectorH()
        {
            if ((Pregunta1 == true) && (Pregunta2 == true) && (Pregunta3 == true) && (Pregunta4 == true) && (Pregunta5 == true) && (Pregunta6 == true) && (Pregunta7 == true) && (Pregunta8 == true) && (Pregunta9 == true) && (Pregunta10 == true) && (Pregunta11 == true) && (Pregunta12 == true) && (Pregunta13 == true) && (Pregunta14 == true) && (Pregunta15 == true))
            {
                SectorSi_SectorH.Visible = true;
                Panel_SH.Visible = false;
                //Panel_SS.Visible = true;
                Pregunta1 = false;
                Pregunta2 = false;
                Pregunta3 = false;
                Pregunta4 = false;
                Pregunta5 = false;
                Pregunta6 = false;
                Pregunta7 = false;
                Pregunta8 = false;
                Pregunta9 = false;
                Pregunta10 = false;
                Pregunta11 = false;
                Pregunta12 = false;
                Pregunta13 = false;
                Pregunta14 = false;
                Pregunta15 = false;
                SS_Completado = false;
            }
        }
        public void Verificar_SectorS()
        {
            if ((Pregunta1 == true) && (Pregunta2 == true) && (Pregunta3 == true) && (Pregunta4 == true) && (Pregunta5 == true) && (Pregunta6 == true) && (Pregunta7 == true) && (Pregunta8 == true) && (Pregunta9 == true) && (Pregunta10 == true))
            {
                SectorSi_SectorS.Visible = true;
               // Panel_SS.Visible = false;
               // Panel_Finalizado.Visible = true;
                Sectores_Finalizado.Visible = true;
                Pregunta1 = false;
                Pregunta2 = false;
                Pregunta3 = false;
                Pregunta4 = false;
                Pregunta5 = false;
                Pregunta6 = false;
                Pregunta7 = false;
                Pregunta8 = false;
                Pregunta9 = false;
                Pregunta10 = false;
                Pregunta11 = false;
                Pregunta12 = false;
                Pregunta13 = false;
                Pregunta14 = false;
                Pregunta15 = false;
                SE_Completado = false;
                SH_Completado = false;
                SS_Completado = false;
                

            }
        }

        //Color de Botones SI/NO

        private void Si_Pregunta1SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta1SE.BackColor = Color.Green;
            No_Pregunta1SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta1SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta1SE.BackColor = Color.LightGray;
            No_Pregunta1SE.BackColor = Color.Green;
        }
        private void Si_Pregunta2SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta2SE.BackColor = Color.Green;
            No_Pregunta2SE.BackColor = Color.LightGray;
        }
        private void No_Pregunta2SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta2SE.BackColor = Color.LightGray;
            No_Pregunta2SE.BackColor = Color.Green;
        }

        private void Si_Pregunta3SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta3SE.BackColor = Color.Green;
            No_Pregunta3SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta3SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta3SE.BackColor = Color.LightGray;
            No_Pregunta3SE.BackColor = Color.Green;
        }

        private void Si_Pregunta4SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta4SE.BackColor = Color.Green;
            No_Pregunta4SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta4SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta4SE.BackColor = Color.LightGray;
            No_Pregunta4SE.BackColor = Color.Green;
        }

        private void Si_Pregunta5SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta5SE.BackColor = Color.Green;
            No_Pregunta5SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta5SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta5SE.BackColor = Color.LightGray;
            No_Pregunta5SE.BackColor = Color.Green;
        }

        private void Si_Pregunta6SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta6SE.BackColor = Color.Green;
            No_Pregunta6SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta6SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta6SE.BackColor = Color.LightGray;
            No_Pregunta6SE.BackColor = Color.Green;
        }

        private void Si_Pregunta7SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta7SE.BackColor = Color.Green;
            No_Pregunta7SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta7SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta7SE.BackColor = Color.LightGray;
            No_Pregunta7SE.BackColor = Color.Green;
        }

        private void Si_Pregunta8SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta8SE.BackColor = Color.Green;
            No_Pregunta8SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta8SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta8SE.BackColor = Color.LightGray;
            No_Pregunta8SE.BackColor = Color.Green;
        }

        private void Si_Pregunta9SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta9SE.BackColor = Color.Green;
            No_Pregunta9SE.BackColor = Color.LightGray;
        }
        private void No_Pregunta9SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta9SE.BackColor = Color.LightGray;
            No_Pregunta9SE.BackColor = Color.Green;
        }
      
        private void Si_Pregunta10SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta10SE.BackColor = Color.Green;
            No_Pregunta10SE.BackColor = Color.LightGray;
        }

        private void No_Pregunta10SE_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta10SE.BackColor = Color.LightGray;
            No_Pregunta10SE.BackColor = Color.Green;
        }

        private void Btn_Volver_Click_1(object sender, EventArgs e)
        {
            if(Panel_SH.Visible == true)
            {
                Panel_SH.Visible = false;
                Panel_SE.Visible = true;
                SE_Completado = false;  //Para que repita la verificacion del Sector y actualize
            }  
        }
        private void Si_Pregunta1SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta1SH.BackColor = Color.Green;
            No_Pregunta1SH.BackColor = Color.LightGray;
        }
        private void No_Pregunta1SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta1SH.BackColor = Color.LightGray;
            No_Pregunta1SH.BackColor = Color.Green;
        }

        private void Si_Pregunta2SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta2SH.BackColor = Color.Green;
            No_Pregunta2SH.BackColor = Color.LightGray;
        }

        private void No_Pregunta2SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta2SH.BackColor = Color.LightGray;
            No_Pregunta2SH.BackColor = Color.Green;
        }

        private void Si_Pregunta3SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta3SH.BackColor = Color.Green;
            No_Pregunta3SH.BackColor = Color.LightGray;

        }

        private void No_Pregunta3SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta3SH.BackColor = Color.LightGray;
            No_Pregunta3SH.BackColor = Color.Green;
        }

        private void Si_Pregunta4SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta4SH.BackColor = Color.Green;
            No_Pregunta4SH.BackColor = Color.LightGray;
        }

        private void No_Pregunta4SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta4SH.BackColor = Color.LightGray;
            No_Pregunta4SH.BackColor = Color.Green;
        }

        private void Si_Pregunta5SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta5SH.BackColor = Color.Green;
            No_Pregunta5SH.BackColor = Color.LightGray;
        }

        private void No_Pregunta5SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta5SH.BackColor = Color.LightGray;
            No_Pregunta5SH.BackColor = Color.Green;
        }

        private void Si_Pregunta6SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta6SH.BackColor = Color.Green;
            No_Pregunta6SH.BackColor = Color.LightGray;
        }

        private void No_Pregunta6SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta6SH.BackColor = Color.LightGray;
            No_Pregunta6SH.BackColor = Color.Green;
        }

        private void Si_Pregunta7SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta7SH.BackColor = Color.Green;
            No_Pregunta7SH.BackColor = Color.LightGray;

        }

        private void No_Pregunta7SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta7SH.BackColor = Color.LightGray;
            No_Pregunta7SH.BackColor = Color.Green;
        }

        private void Si_Pregunta8SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta8SH.BackColor = Color.Green;
            No_Pregunta8SH.BackColor = Color.LightGray;
        }

        private void No_Pregunta8SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta8SH.BackColor = Color.LightGray;
            No_Pregunta8SH.BackColor = Color.Green;
        }

        private void Si_Pregunta9SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta9SH.BackColor = Color.Green;
            No_Pregunta9SH.BackColor = Color.LightGray;
        }

        private void No_Pregunta9SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta9SH.BackColor = Color.LightGray;
            No_Pregunta9SH.BackColor = Color.Green;
        }

        private void Si_Pregunta10SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta10SH.BackColor = Color.Green;
            No_Pregunta10SH.BackColor = Color.LightGray;
        }

        private void No_Pregunta10SH_CheckedChanged(object sender, EventArgs e)
        {
            Si_Pregunta10SH.BackColor = Color.LightGray;
            No_Pregunta10SH.BackColor = Color.Green;
        }

        
    }
} 