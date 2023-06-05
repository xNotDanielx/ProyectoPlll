using Datos;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentacionGUI
{
    public partial class Frm_Graficas : Form
    {
        Persona persona = new Persona();
        Sector_Economico SE = new Sector_Economico();
        Sector_Hogar SH = new Sector_Hogar();
        Sector_Social SS = new Sector_Social();
        Logica.ServicioLogin LogicaL = new Logica.ServicioLogin(configConnnection.ConnectionString);
        Logica.ServicioPersona logicaP = new Logica.ServicioPersona(configConnnection.ConnectionString);
        ServicioSE logicaSE = new ServicioSE(configConnnection.ConnectionString);
        ServicioSH logicaSH = new ServicioSH(configConnnection.ConnectionString);
        ServicioSS logicaSS = new ServicioSS(configConnnection.ConnectionString);
        public Frm_Graficas()
        {
            InitializeComponent();
        }

        public void Cerrar()
        {
            this.Close();
        }

        int i = 0;
        private void Frm_Graficas_Load(object sender, EventArgs e)
        {
            String[] serieSE = {"Empleado", "Propietarios Negocios", "Trabajadores Privados", "Contratistas Independientes","Pensionados","Subsidiados","Accionistas","Trabajadores Publicos","Ingresos en Actividades", "Desempleados"};
            String[] serieSH = {"Rural","Urbana","Srv.Agua","Srv.Luz", "Srv.Gas", "Srv.Saneamiento", "Con Vehiculo", "Con Internet"};
            String[] serieSS = {"Afiliados", "Victimas del Conflicto", "Acceso a Educacion", "Arhuacos", "Koguis", "Kankuamos", "Wiwas", "Yucpas", "Chimilas", "Ninguna Etnia", "Educacion Formal", "Primaria", "Secundaria","Tecnicos","Universitarios","Otro"};
            String[] seriePE = {"Cedula Extrangera","Cedula Ciudadana","Hombres", "Mujeres", "Mayores de Edad", "Menores de Edad", "Hogar", "Apartamento"};
            int[] ResultadosSE = {logicaSE.ContarEmpleado(), logicaSE.ContarPropietario(), logicaSE.ContarT_Privado(), logicaSE.ContarC_Independiente(), logicaSE.ContarPensionado(), logicaSE.ContarSubisidiado(), logicaSE.ContarAccionista(), logicaSE.ContarT_Publico(), logicaSE.ContarI_Actividades(), logicaSE.ContarDesempleado()};
            int[] ResultadosSH = {logicaSH.ContarRural(), logicaSH.ContarUrbana(), logicaSH.ContarAgua(), logicaSH.ContarLuz(), logicaSH.ContarGas(), logicaSH.ContarSaneamiento(), logicaSH.ContarVehiculo(), logicaSH.ContarInternet()};
            int[] ResultadosSS = {logicaSS.ContarAfiliado(), logicaSS.ContarV_Conflicto(), logicaSS.ContarA_Estudio(), logicaSS.ContarArhuaco(), logicaSS.ContarKogui(), logicaSS.ContarKankuamo(), logicaSS.ContarWiwa(), logicaSS.ContarYucpa(), logicaSS.ContarChimila(), logicaSS.ContarNinguna_E(), logicaSS.ContarE_Formal(), logicaSS.ContarPrimaria(), logicaSS.ContarSecundaria(), logicaSS.ContarTecnicos(), logicaSS.ContarUniversitario(), logicaSS.ContarE_Otro()};
            int[] ResultadosPE = {LogicaL.ContarCC(),LogicaL.ContarCE(),logicaP.ContarHombres(),logicaP.ContarMujeres(),logicaP.ContarMayorEdad(), logicaP .ContarMenorEdad(),logicaP.ContarHogar(),logicaP.ContarApartamento()};


            for (i = 0; i < serieSE.Length; i++)
            {
                if(ResultadosSE[i] != 0)
                {
                    chart_SE.Series["SeriesSE"].Points.AddXY(serieSE[i], ResultadosSE[i]);
                }                          
            }

            for (i = 0; i < serieSH.Length; i++)
            {
                if (ResultadosSH[i] != 0)
                {
                    chart_SH.Series["SeriesSH"].Points.AddXY(serieSH[i], ResultadosSH[i]);
                }
        }

            for (i = 0; i < serieSS.Length; i++)
            {
                if (ResultadosSS[i] != 0)
                {
                    chart_SS.Series["SeriesSS"].Points.AddXY(serieSS[i], ResultadosSS[i]); 
                }                    
            }
            for (i = 0; i < seriePE.Length; i++)
            {
                if(ResultadosPE[i] != 0)
                {
                    chart_PE.Series["SeriesPE"].Points.AddXY(seriePE[i], ResultadosPE[i]);
                }                    
            }
           
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
}
