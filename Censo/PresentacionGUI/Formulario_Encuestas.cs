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
using Datos;

namespace PresentacionGUI
{
    public partial class Formulario_Encuestas : Form
    {
        Sector_Economico SE = new Sector_Economico();
        Sector_Social SS = new Sector_Social();
        Sector_Hogar SH = new Sector_Hogar();
        Persona persona = new Persona();
        Entidades.Login login = new Entidades.Login();
        Logica.ServicioPersona logicaP = new Logica.ServicioPersona(configConnnection.ConnectionString);
        ServicioSE logicaSE = new ServicioSE(configConnnection.ConnectionString);
        ServicioSH logicaSH = new ServicioSH(configConnnection.ConnectionString);
        ServicioSS logicaSS = new ServicioSS(configConnnection.ConnectionString);
        Form_Registrar registrar = new Form_Registrar();

        public Formulario_Encuestas()
        {
            InitializeComponent();                
        }
        public void Cerrar()
        {
            this.Close();
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
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

        public void Info_Persona(string DocPersona)
        {
            persona.Documento = DocPersona;
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            if ((SE_Completado == false) && (SH_Completado == false))
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
                Pregunta11SE();
                Verificar_SectorE();
            }
             else if ((SE_Completado == true))
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
            
        }
        //Preguntas del Sector Economico
        public void Pregunta1SE()
        {
            try
            {
                if (Si_Pregunta1SE.Checked)
                {
                    SE.Empleado = 1;                    
                    Pregunta1 = true;
                }
                else if(No_Pregunta1SE.Checked)
                {
                    SE.Empleado = 0;
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
                    SE.Propietario_Negocio = 1;
                    Pregunta2 = true;
                }
                else if (No_Pregunta2SE.Checked)
                {
                    SE.Propietario_Negocio = 0;
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
                    SE.Trabajador_Privado = 1;
                    Pregunta3 = true;
                }
                else if (No_Pregunta3SE.Checked)
                {
                    SE.Trabajador_Privado = 0;
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
                    SE.Contratista_Independiente = 1;
                    Pregunta4 = true;
                }
                else if (No_Pregunta4SE.Checked)
                {
                    SE.Contratista_Independiente = 0;
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
                    SE.Pensionado = 1;
                    Pregunta5 = true;
                }
                else if (No_Pregunta5SE.Checked)
                {
                    SE.Pensionado = 0;
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
                    SE.Subsidiado = 1;
                    Pregunta6 = true;
                }
                else if (No_Pregunta6SE.Checked)
                {
                    SE.Subsidiado = 0;
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
                    SE.Accionistas = 1;
                    Pregunta7 = true;
                }
                else if (No_Pregunta7SE.Checked)
                {
                    SE.Accionistas = 0;
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
                    SE.Trabajador_Publico = 1;
                    Pregunta8 = true;
                }
                else if (No_Pregunta8SE.Checked)
                {
                    SE.Trabajador_Publico = 0;
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
                    SE.Ingreso_Actividades = 1;
                    Pregunta9 = true;
                }
                else if (No_Pregunta9SE.Checked)
                {
                    SE.Ingreso_Actividades = 0;
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
                    SE.Desempleado = 1;
                    Pregunta10 = true;
                }
                else if (No_Pregunta10SE.Checked)
                {
                    SE.Desempleado = 0;
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

        public void Pregunta11SE()
        {
            try
            {
                if (Opc_Estrato1.Checked)
                {
                    SE.Estrato = "1";
                    Opc_Estrato1.ForeColor = Color.Black;
                    Opc_Estrato2.ForeColor = Color.Black;
                    Opc_Estrato3.ForeColor = Color.Black;
                    Opc_Estrato4.ForeColor = Color.Black;
                    Opc_Estrato5.ForeColor = Color.Black;
                    Opc_Estrato6.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else if (Opc_Estrato2.Checked)
                {
                    SE.Estrato = "2";
                    Opc_Estrato1.ForeColor = Color.Black;
                    Opc_Estrato2.ForeColor = Color.Black;
                    Opc_Estrato3.ForeColor = Color.Black;
                    Opc_Estrato4.ForeColor = Color.Black;
                    Opc_Estrato5.ForeColor = Color.Black;
                    Opc_Estrato6.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else if (Opc_Estrato3.Checked)
                {
                    SE.Estrato = "3";
                    Opc_Estrato1.ForeColor = Color.Black;
                    Opc_Estrato2.ForeColor = Color.Black;
                    Opc_Estrato3.ForeColor = Color.Black;
                    Opc_Estrato4.ForeColor = Color.Black;
                    Opc_Estrato5.ForeColor = Color.Black;
                    Opc_Estrato6.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else if (Opc_Estrato4.Checked)
                {
                    SE.Estrato = "4";
                    Opc_Estrato1.ForeColor = Color.Black;
                    Opc_Estrato2.ForeColor = Color.Black;
                    Opc_Estrato3.ForeColor = Color.Black;
                    Opc_Estrato4.ForeColor = Color.Black;
                    Opc_Estrato5.ForeColor = Color.Black;
                    Opc_Estrato6.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else if (Opc_Estrato5.Checked)
                {
                    SE.Estrato = "5";
                    Opc_Estrato1.ForeColor = Color.Black;
                    Opc_Estrato2.ForeColor = Color.Black;
                    Opc_Estrato3.ForeColor = Color.Black;
                    Opc_Estrato4.ForeColor = Color.Black;
                    Opc_Estrato5.ForeColor = Color.Black;
                    Opc_Estrato6.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else if (Opc_Estrato6.Checked)
                {
                    SE.Estrato = "6";
                    Opc_Estrato1.ForeColor = Color.Black;
                    Opc_Estrato2.ForeColor = Color.Black;
                    Opc_Estrato3.ForeColor = Color.Black;
                    Opc_Estrato4.ForeColor = Color.Black;
                    Opc_Estrato5.ForeColor = Color.Black;
                    Opc_Estrato6.ForeColor = Color.Black;
                    Pregunta11 = true;
                }
                else
                {
                    Opc_Estrato1.ForeColor = Color.Red;
                    Opc_Estrato2.ForeColor = Color.Red;
                    Opc_Estrato3.ForeColor = Color.Red;
                    Opc_Estrato4.ForeColor = Color.Red;
                    Opc_Estrato5.ForeColor = Color.Red;
                    Opc_Estrato6.ForeColor = Color.Red;
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
                    SH.Propietario = 1;                    
                    Pregunta1 = true;
                }
                else if(No_Pregunta1SH.Checked)
                {
                    SH.Propietario = 0;
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
                    SH.Servicio_Agua = 1;
                    Pregunta2 = true;
                    Console.WriteLine("2");
                }
                else if (No_Pregunta2SH.Checked)
                {
                    SH.Servicio_Agua = 0;
                    Pregunta2 = true;
                    Console.WriteLine("2");
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
                    SH.Servicio_Luz = 1;
                    Pregunta3 = true;
                    Console.WriteLine("3");
                }
                else if (No_Pregunta3SH.Checked)
                {
                    SH.Servicio_Luz = 0;
                    Pregunta3 = true;
                    Console.WriteLine("3");
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
                    SH.Servicio_Gas = 1;
                    Pregunta4 = true;
                    Console.WriteLine("4");
                }
                else if(No_Pregunta4SH.Checked)
                {
                    SH.Servicio_Gas = 0;
                    Pregunta4 = true;
                    Console.WriteLine("4");
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
                    SH.Saneamiento = 1;
                    Pregunta5 = true;
                    Console.WriteLine("5");
                }
                else if (No_Pregunta5SH.Checked)
                {
                    SH.Saneamiento = 0;
                    Pregunta5 = true;
                    Console.WriteLine("5");
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
                    SH.Adicional = 1;
                    Pregunta6 = true;
                    Console.WriteLine("6");
                }
                else if (No_Pregunta6SH.Checked)
                {
                    SH.Adicional = 0;
                    Pregunta6 = true;
                    Console.WriteLine("6");
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
                    SH.Internet = 1;
                    Pregunta7 = true;
                    Console.WriteLine("7");
                }
                else if (No_Pregunta7SH.Checked)
                {
                    SH.Internet = 0;
                    Pregunta7 = true;
                    Console.WriteLine("7");
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
                    SH.Cable = 1;
                    Pregunta8 = true;
                    Console.WriteLine("8");
                }
                else if (No_Pregunta8SH.Checked)
                {
                    SH.Cable = 0;
                    Pregunta8 = true;
                    Console.WriteLine("8");
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
                    SH.Telefono = 1;
                    Pregunta9 = true;
                    Console.WriteLine("9");
                }
                else if (No_Pregunta9SH.Checked)
                {
                    SH.Telefono = 0;
                    Pregunta9 = true;
                    Console.WriteLine("9");
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
                    SH.Vehiculo = 1;
                    Pregunta10 = true;
                    Console.WriteLine("10");
                }
                else if (No_Pregunta10SH.Checked)
                {
                    SH.Vehiculo = 0;
                    Pregunta10 = true;
                    Console.WriteLine("10");
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
                    SH.Zona = "Urbana";
                    Opc_Urbano.ForeColor = Color.Black;
                    Opc_Urbano.ForeColor = Color.Black;
                    Pregunta11 = true;
                    Console.WriteLine("11");
                }
                else if (Opc_Rural.Checked)
                {
                    SH.Zona = "Rural";
                    Opc_Urbano.ForeColor = Color.Black;
                    Opc_Rural.ForeColor = Color.Black;
                    Pregunta11 = true;
                    Console.WriteLine("11");
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
                if(txt_Habitaciones.Text != "")
                {
                    SH.Habitaciones = txt_Habitaciones.Text;
                    txtHabitaciones.ForeColor = Color.Black;
                    Pregunta12 = true;
                    Console.WriteLine("12");
                }
                else
                {
                    txtHabitaciones.ForeColor = Color.Red;
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
                if (txt_Baños.Text != "")
                {
                    SH.Baños = txt_Baños.Text;
                    txtBaño.ForeColor = Color.Black;
                    Pregunta13 = true;
                    Console.WriteLine("13");
                }
                else
                {
                    txtBaño.ForeColor = Color.Red;
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
                    SH.Tipo_Vivienda = "Propia";
                    Opc_Propia.ForeColor = Color.Black;
                    Opc_Alquilada.ForeColor = Color.Black;
                    Pregunta14 = true;
                    Console.WriteLine("14");
                }
                else if (Opc_Alquilada.Checked)
                {
                    SH.Tipo_Vivienda = "Alquilada";
                    Opc_Propia.ForeColor = Color.Black;
                    Opc_Alquilada.ForeColor = Color.Black;
                    Pregunta14 = true;
                    Console.WriteLine("14");
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
                    SH.Ingreso = "Bajo";
                    Opc_Bajo.ForeColor = Color.Black;
                    Opc_Medio.ForeColor = Color.Black;
                    Opc_Alto.ForeColor = Color.Black;
                    Pregunta15 = true;
                    Console.WriteLine("15");
                }
                else if (Opc_Medio.Checked)
                {
                    SH.Ingreso = "Medio";
                    Opc_Bajo.ForeColor = Color.Black;
                    Opc_Medio.ForeColor = Color.Black;
                    Opc_Alto.ForeColor = Color.Black;
                    Pregunta15 = true;
                    Console.WriteLine("15");
                }
                else if(Opc_Alto.Checked)
                {
                    SH.Ingreso = "Alto";
                    Opc_Bajo.ForeColor = Color.Black;
                    Opc_Medio.ForeColor = Color.Black;
                    Opc_Alto.ForeColor = Color.Black;
                    Pregunta15 = true;
                    Console.WriteLine("15");
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
            try
            {
                if (Si_Pregunta1SS.Checked)
                {
                    SS.Afliado = 1;                    
                    Pregunta1 = true;
                }
                else if (No_Pregunta1SS.Checked)
                {
                    SS.Afliado = 0;
                    Pregunta1 = true;
                }
                else
                {
                    Si_Pregunta1SS.BackColor = Color.Red;
                    No_Pregunta1SS.BackColor = Color.Red;
                }
            }
            catch
            {

            }

        }
        public void Pregunta2SS()
        {
            try
            {
                if (Si_Pregunta2SS.Checked)
                {
                    SS.Victima_Conflicto = 1;
                    Pregunta2 = true;
                }
                else if (No_Pregunta2SS.Checked)
                {
                    SS.Victima_Conflicto= 0;
                    Pregunta2 = true;
                }
                else
                {
                    Si_Pregunta2SS.BackColor = Color.Red;
                    No_Pregunta2SS.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta3SS()
        {
            try
            {
                if (Si_Pregunta3SS.Checked)
                {
                    SS.Acceso_Estudio = 1;
                    Pregunta3 = true;
                }
                else if (No_Pregunta3SS.Checked)
                {
                    SS.Acceso_Estudio = 0;
                    Pregunta3 = true;
                }
                else
                {
                    Si_Pregunta3SS.BackColor = Color.Red;
                    No_Pregunta3SS.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta4SS()
        {
            try
            {
                if (Si_Pregunta4SS.Checked)
                {
                    SS.Servicio_Transporte = 1;
                    Pregunta4 = true;
                }
                else if (No_Pregunta4SS.Checked)
                {
                    SS.Servicio_Transporte = 0;
                    Pregunta4 = true;
                }
                else
                {
                    Si_Pregunta4SS.BackColor = Color.Red;
                    No_Pregunta4SS.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta5SS()
        {
            try
            {
                if (Opc_Arhuaco.Checked)
                {
                    SS.Etnia = "Arhuaco";
                    Opc_Arhuaco.ForeColor = Color.Black;
                    Opc_Kogui.ForeColor = Color.Black;
                    Opc_Kankuamo.ForeColor = Color.Black;
                    Opc_Wiwa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Ninguno.ForeColor = Color.Black;
                    Pregunta5 = true;
                }
                else if (Opc_Kogui.Checked)
                {
                    SS.Etnia = "Kogui";
                    Opc_Arhuaco.ForeColor = Color.Black;
                    Opc_Kogui.ForeColor = Color.Black;
                    Opc_Kankuamo.ForeColor = Color.Black;
                    Opc_Wiwa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Ninguno.ForeColor = Color.Black;
                    Pregunta5 = true;
                }
                else if (Opc_Kankuamo.Checked)
                {
                    SS.Etnia = "Kankuamo";
                    Opc_Arhuaco.ForeColor = Color.Black;
                    Opc_Kogui.ForeColor = Color.Black;
                    Opc_Kankuamo.ForeColor = Color.Black;
                    Opc_Wiwa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Ninguno.ForeColor = Color.Black;
                    Pregunta5 = true;
                }
                else if (Opc_Wiwa.Checked)
                {
                    SS.Etnia = "Wiwa";
                    Opc_Arhuaco.ForeColor = Color.Black;
                    Opc_Kogui.ForeColor = Color.Black;
                    Opc_Kankuamo.ForeColor = Color.Black;
                    Opc_Wiwa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Ninguno.ForeColor = Color.Black;
                    Pregunta5 = true;
                }
                else if (Opc_Yucpa.Checked)
                {
                    SS.Etnia = "Yucpa";
                    Opc_Arhuaco.ForeColor = Color.Black;
                    Opc_Kogui.ForeColor = Color.Black;
                    Opc_Kankuamo.ForeColor = Color.Black;
                    Opc_Wiwa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Ninguno.ForeColor = Color.Black;
                    Pregunta5 = true;
                }
                else if (Opc_Chimila.Checked)
                {
                    SS.Etnia = "Chimila";
                    Opc_Arhuaco.ForeColor = Color.Black;
                    Opc_Kogui.ForeColor = Color.Black;
                    Opc_Kankuamo.ForeColor = Color.Black;
                    Opc_Wiwa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Ninguno.ForeColor = Color.Black;
                    Pregunta5 = true;
                }
                else if (Opc_Ninguno.Checked)
                {
                    SS.Etnia = "Ninguno";
                    Opc_Arhuaco.ForeColor = Color.Black;
                    Opc_Kogui.ForeColor = Color.Black;
                    Opc_Kankuamo.ForeColor = Color.Black;
                    Opc_Wiwa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Yucpa.ForeColor = Color.Black;
                    Opc_Ninguno.ForeColor = Color.Black;
                    Pregunta5 = true;
                }
                else
                {
                    Opc_Arhuaco.ForeColor = Color.Red;
                    Opc_Kogui.ForeColor = Color.Red;
                    Opc_Kankuamo.ForeColor = Color.Red;
                    Opc_Wiwa.ForeColor = Color.Red;
                    Opc_Yucpa.ForeColor = Color.Red;
                    Opc_Yucpa.ForeColor = Color.Red;
                    Opc_Ninguno.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta6SS()
        {
            try
            {
                if (Opc_Soltero.Checked)
                {
                    SS.Estado_Civil = "Soltero";
                    Opc_Soltero.ForeColor = Color.Black;
                    Opc_Casado.ForeColor = Color.Black;
                    Opc_Viudo.ForeColor = Color.Black;
                    Opc_Divorciado.ForeColor = Color.Black;
                    Opc_OtroCivil.ForeColor = Color.Black;
                    Pregunta6 = true;
                }
                else if (Opc_Casado.Checked)
                {
                    SS.Estado_Civil = "Casado";
                    Opc_Soltero.ForeColor = Color.Black;
                    Opc_Casado.ForeColor = Color.Black;
                    Opc_Viudo.ForeColor = Color.Black;
                    Opc_Divorciado.ForeColor = Color.Black;
                    Opc_OtroCivil.ForeColor = Color.Black;
                    Pregunta6 = true;
                }
                else if (Opc_Viudo.Checked)
                {
                    SS.Estado_Civil = "Viudo";
                    Opc_Soltero.ForeColor = Color.Black;
                    Opc_Casado.ForeColor = Color.Black;
                    Opc_Viudo.ForeColor = Color.Black;
                    Opc_Divorciado.ForeColor = Color.Black;
                    Opc_OtroCivil.ForeColor = Color.Black;
                    Pregunta6 = true;
                }
                else if (Opc_Divorciado.Checked)
                {
                    SS.Estado_Civil = "Divorciado";
                    Opc_Soltero.ForeColor = Color.Black;
                    Opc_Casado.ForeColor = Color.Black;
                    Opc_Viudo.ForeColor = Color.Black;
                    Opc_Divorciado.ForeColor = Color.Black;
                    Opc_OtroCivil.ForeColor = Color.Black;
                    Pregunta6 = true;
                }
                else if (Opc_OtroCivil.Checked)
                {
                    SS.Estado_Civil = "Otro";
                    Opc_Soltero.ForeColor = Color.Black;
                    Opc_Casado.ForeColor = Color.Black;
                    Opc_Viudo.ForeColor = Color.Black;
                    Opc_Divorciado.ForeColor = Color.Black;
                    Opc_OtroCivil.ForeColor = Color.Black;
                    Pregunta6 = true;
                }                
                else
                {
                    Opc_Soltero.ForeColor = Color.Red;
                    Opc_Casado.ForeColor = Color.Red;
                    Opc_Viudo.ForeColor = Color.Red;
                    Opc_Divorciado.ForeColor = Color.Red;
                    Opc_OtroCivil.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void Pregunta7SS()
        {
            try
            {
                if (Opc_SinEstudio.Checked)
                {
                    SS.NivelEducacion = "Sin Estudio";
                    Opc_SinEstudio.ForeColor = Color.Black;
                    Opc_Primaria.ForeColor = Color.Black;
                    Opc_Secundaria.ForeColor = Color.Black;
                    Opc_Tecnica.ForeColor = Color.Black;
                    Opc_Universitaria.ForeColor = Color.Black;
                    Opc_OtroEducacion.ForeColor = Color.Black;
                    Pregunta7 = true;
                }
                else if (Opc_Primaria.Checked)
                {
                    SS.NivelEducacion = "Primaria";
                    Opc_SinEstudio.ForeColor = Color.Black;
                    Opc_Primaria.ForeColor = Color.Black;
                    Opc_Secundaria.ForeColor = Color.Black;
                    Opc_Tecnica.ForeColor = Color.Black;
                    Opc_Universitaria.ForeColor = Color.Black;
                    Opc_OtroEducacion.ForeColor = Color.Black;
                    Pregunta7 = true;
                }
                else if (Opc_Secundaria.Checked)
                {
                    SS.NivelEducacion = "Secundaria";
                    Opc_SinEstudio.ForeColor = Color.Black;
                    Opc_Primaria.ForeColor = Color.Black;
                    Opc_Secundaria.ForeColor = Color.Black;
                    Opc_Tecnica.ForeColor = Color.Black;
                    Opc_Universitaria.ForeColor = Color.Black;
                    Opc_OtroEducacion.ForeColor = Color.Black;
                    Pregunta7 = true;
                }
                else if (Opc_Tecnica.Checked)
                {
                    SS.NivelEducacion = "Tecnica";
                    Opc_SinEstudio.ForeColor = Color.Black;
                    Opc_Primaria.ForeColor = Color.Black;
                    Opc_Secundaria.ForeColor = Color.Black;
                    Opc_Tecnica.ForeColor = Color.Black;
                    Opc_Universitaria.ForeColor = Color.Black;
                    Opc_OtroEducacion.ForeColor = Color.Black;
                    Pregunta7 = true;
                }
                else if (Opc_Universitaria.Checked)
                {
                    SS.NivelEducacion = "Universitaria";
                    Opc_SinEstudio.ForeColor = Color.Black;
                    Opc_Primaria.ForeColor = Color.Black;
                    Opc_Secundaria.ForeColor = Color.Black;
                    Opc_Tecnica.ForeColor = Color.Black;
                    Opc_Universitaria.ForeColor = Color.Black;
                    Opc_OtroEducacion.ForeColor = Color.Black;
                    Pregunta7 = true;
                }
                else if (Opc_OtroEducacion.Checked)
                {
                    SS.NivelEducacion = "Otro";
                    Opc_SinEstudio.ForeColor = Color.Black;
                    Opc_Primaria.ForeColor = Color.Black;
                    Opc_Secundaria.ForeColor = Color.Black;
                    Opc_Tecnica.ForeColor = Color.Black;
                    Opc_Universitaria.ForeColor = Color.Black;
                    Opc_OtroEducacion.ForeColor = Color.Black;
                    Pregunta7 = true;
                }
                else
                {
                    Opc_SinEstudio.ForeColor = Color.Red;
                    Opc_Primaria.ForeColor = Color.Red;
                    Opc_Secundaria.ForeColor = Color.Red;
                    Opc_Tecnica.ForeColor = Color.Red;
                    Opc_Universitaria.ForeColor = Color.Red;
                    Opc_OtroEducacion.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
        }
        public void PreguntasFalse()
        {
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
        }
        public void Verificar_SectorE()
        {
            if ((Pregunta1 == true) && (Pregunta2 == true) && (Pregunta3 == true) && (Pregunta4 == true) && (Pregunta5 == true) && (Pregunta6 == true) && (Pregunta7 == true) && (Pregunta8 == true) && (Pregunta9 == true) && (Pregunta10 == true) && (Pregunta11 == true))
            {
                Btn_Finalizar.Visible = false;
                Btn_Siguiente.Visible = true;
                SectorSi_SectorE.Visible = true;
                Panel_SH.Visible = true;
                Btn_Volver.Visible = true;
                SE_Completado = true;
                PreguntasFalse();
                SH_Completado = false;
                SS_Completado = false;                                
            }
        }
        public void Verificar_SectorH()
        {
            if ((Pregunta1 == true) && (Pregunta2 == true) && (Pregunta3 == true) && (Pregunta4 == true) && (Pregunta5 == true) && (Pregunta6 == true) && (Pregunta7 == true) && (Pregunta8 == true) && (Pregunta9 == true) && (Pregunta10 == true) && (Pregunta11 == true) && (Pregunta12 == true) && (Pregunta13 == true) && (Pregunta14 == true) && (Pregunta15 == true))
            {
                Btn_Siguiente.Visible = false;
                Btn_Finalizar.Visible = true;             
                SectorSi_SectorH.Visible = true;
                Panel_SS.Visible = true;
                SE_Completado = true;
                SH_Completado = true;
                PreguntasFalse();
                SS_Completado = false;                                
            }
        }
        public void Verificar_SectorS()
        {
            if ((Pregunta1 == true) && (Pregunta2 == true) && (Pregunta3 == true) && (Pregunta4 == true) && (Pregunta5 == true) && (Pregunta6 == true) && (Pregunta7 == true))
            {
                Panel_Mensaje.Visible = true;                                                                     
            }
                        
        }

        string DocSectores;
        public string Doc()
        {
            foreach (var item in logicaSE.GetAll())
            {
                DocSectores = registrar.GuardarDocSE(item);
            }
            return DocSectores;
        }

        private void Finalizar_Si_Click(object sender, EventArgs e)
        {
            
            Panel_Mensaje.Visible = false;
            SectorSi_SectorS.Visible = true;
            Sectores_Finalizado.Visible = true;
            SE_Completado = true;
            SH_Completado = true;
            SS_Completado = true;
            Btn_Volver.Visible = false;
            Btn_Siguiente.Visible = false;
            Btn_Cancelar.Visible = false;
            Btn_Finalizar.Visible = false;
            Btn_Salir.Visible = true;
            SE.Documento = persona.Documento;
            SH.Documento = persona.Documento;
            SS.Documento = persona.Documento;
            logicaSE.Update(SE);
            logicaSH.Update(SH);
            logicaSS.Update(SS);            
            logicaP.updateSectorComplete("Completado", persona.Documento);
            panel_Finalizado.Visible = true;
        }

        private void Finalizar_No_Click(object sender, EventArgs e)
        {
            Panel_Mensaje.Visible = false;
        }

        //Color de Botones SI/NO

        public void Si(RadioButton botonSi, RadioButton botonNo)
        {
            botonSi.BackColor = Color.Green;
            botonNo.BackColor = Color.LightGray;
        }

        public void No(RadioButton botonSi, RadioButton botonNo)
        {
            botonSi.BackColor = Color.LightGray;
            botonNo.BackColor = Color.Red;
        }

        private void Si_Pregunta1SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta1SE, No_Pregunta1SE);
        }

        private void No_Pregunta1SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta1SE, No_Pregunta1SE);
        }
        private void Si_Pregunta2SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta2SE, No_Pregunta2SE);
        }
        private void No_Pregunta2SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta2SE, No_Pregunta2SE);
        }

        private void Si_Pregunta3SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta3SE, No_Pregunta3SE);
        }

        private void No_Pregunta3SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta3SE, No_Pregunta3SE);
        }

        private void Si_Pregunta4SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta4SE, No_Pregunta4SE);
        }

        private void No_Pregunta4SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta4SE, No_Pregunta4SE);
        }

        private void Si_Pregunta5SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta5SE, No_Pregunta5SE);
        }

        private void No_Pregunta5SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta5SE, No_Pregunta5SE);
        }

        private void Si_Pregunta6SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta6SE, No_Pregunta6SE);
        }

        private void No_Pregunta6SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta6SE, No_Pregunta6SE);
        }

        private void Si_Pregunta7SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta7SE, No_Pregunta7SE);
        }

        private void No_Pregunta7SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta7SE, No_Pregunta7SE);
        }

        private void Si_Pregunta8SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta8SE, No_Pregunta8SE);
        }

        private void No_Pregunta8SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta8SE, No_Pregunta8SE);
        }

        private void Si_Pregunta9SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta9SE, No_Pregunta9SE);
        }
        private void No_Pregunta9SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta9SE, No_Pregunta9SE);
        }
      
        private void Si_Pregunta10SE_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta10SE, No_Pregunta10SE);
        }

        private void No_Pregunta10SE_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta10SE, No_Pregunta10SE);
        }

        private void Btn_Volver_Click_1(object sender, EventArgs e)
        {
            if((Panel_SH.Visible == true)&&(Panel_SS.Visible == false))
            {
                Btn_Volver.Visible = false;
                SectorSi_SectorE.Visible = false;
                Panel_SH.Visible = false;
                SE_Completado = false;  //Para que repita la verificacion del Sector y actualize
            } 
            else if ((Panel_SH.Visible == true) && (Panel_SS.Visible == true))
            {
                SectorSi_SectorH.Visible = false;
                Btn_Finalizar.Visible = false;
                Btn_Siguiente.Visible = true;
                Panel_SS.Visible = false;                          
                SH_Completado = false;  //Para que repita la verificacion del Sector y actualize
            }                
        }
        private void Si_Pregunta1SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta1SH, No_Pregunta1SH);
        }
        private void No_Pregunta1SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta1SH, No_Pregunta1SH);
        }

        private void Si_Pregunta2SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta2SH, No_Pregunta2SH);
        }

        private void No_Pregunta2SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta2SH, No_Pregunta2SH);
        }

        private void Si_Pregunta3SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta3SH, No_Pregunta3SH);

        }

        private void No_Pregunta3SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta3SH, No_Pregunta3SH);
        }

        private void Si_Pregunta4SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta4SH, No_Pregunta4SH);
        }

        private void No_Pregunta4SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta4SH, No_Pregunta4SH);
        }

        private void Si_Pregunta5SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta5SH, No_Pregunta5SH);
        }

        private void No_Pregunta5SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta5SH, No_Pregunta5SH);
        }

        private void Si_Pregunta6SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta6SH, No_Pregunta6SH);
        }

        private void No_Pregunta6SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta6SH, No_Pregunta6SH);
        }

        private void Si_Pregunta7SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta7SH, No_Pregunta7SH);

        }

        private void No_Pregunta7SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta7SH, No_Pregunta7SH);
        }

        private void Si_Pregunta8SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta8SH, No_Pregunta8SH);
        }

        private void No_Pregunta8SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta8SH, No_Pregunta8SH);
        }

        private void Si_Pregunta9SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta9SH, No_Pregunta9SH);
        }

        private void No_Pregunta9SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta9SH, No_Pregunta9SH);
        }

        private void Si_Pregunta10SH_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta10SH, No_Pregunta10SH);
        }

        private void No_Pregunta10SH_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta10SH, No_Pregunta10SH);
        }

        private void Si_Pregunta1SS_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta1SS, No_Pregunta1SS);
        }

        private void No_Pregunta1SS_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta1SS, No_Pregunta1SS);
        }

        private void Si_Pregunta2SS_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta2SS, No_Pregunta2SS);
        }

        private void No_Pregunta2SS_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta2SS, No_Pregunta2SS);
        }

        private void Si_Pregunta3SS_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta3SS, No_Pregunta3SS);
        }

        private void No_Pregunta3SS_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta3SS, No_Pregunta3SS);
        }

        private void Si_Pregunta4SS_CheckedChanged(object sender, EventArgs e)
        {
            Si(Si_Pregunta4SS, No_Pregunta4SS);
        }

        private void No_Pregunta4SS_CheckedChanged(object sender, EventArgs e)
        {
            No(Si_Pregunta4SS, No_Pregunta4SS);
        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            if ((SH_Completado == true))
            {
                Pregunta1SS();
                Pregunta2SS();
                Pregunta3SS();
                Pregunta4SS();
                Pregunta5SS();
                Pregunta6SS();
                Pregunta7SS();
                Verificar_SectorS();
            }
            /*else
            {
                Verificar_Sectores();
            }*/
            Panel_Mensaje.Visible = true;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
} 