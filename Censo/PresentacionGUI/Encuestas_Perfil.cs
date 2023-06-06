using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Imaging;
using Entidades;
using Logica;
using System.Reflection;
using Datos;
using Microsoft.Win32;

namespace PresentacionGUI
{
    public partial class Encuestas_Perfil : Form
    {
        int Contador = 0;
        Login login = new Login();
        Persona persona = new Persona();
        Logica.ServicioLogin sl = new Logica.ServicioLogin(configConnnection.ConnectionString);
        Logica.ServicioPersona sp = new Logica.ServicioPersona(configConnnection.ConnectionString);        
        int i;
        public Encuestas_Perfil()
        {
            InitializeComponent();
            InitializeTimer();            
        }

        public void Cerrar()
        {
            this.Close();
        }

        private void InitializeTimer()
        {
            pictureBox1.Visible = true;
            Timer_Intro.Interval = 1000;
            Timer_Intro.Tick += Timer_Tick;
            Timer_Intro.Start();
            Contador = Contador + 1;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i <= 3)
            {
                i++;

            }
            else
            {
                pictureBox1.Visible = false;
                Timer_Intro.Stop();
                Iniciar_Info();
            }
        }
        public string Info_Persona(string NdUsuario, string InfoUsuario)
        {
            login.Numero_Documento = NdUsuario;
            persona.Documento = InfoUsuario;
            return persona.Documento;
        }

        public void Iniciar_Info()
        {
            Panel_Encuesta.Visible = true;
            PanelHoraFecha.Visible = true;
            Panel_Info.Visible = true;
            Panel_Status.Visible = true;
            Logo.Visible = true;
            foreach (Login Log in sl.Obtener_Informacion(login))
            {
                Txt_NumeroD.Text = Log.Numero_Documento;
            }

            foreach (Persona PersonaInfo in sp.Obtener_Informacion(persona))
            {

                Txt_Nombre_Apellido.Text = PersonaInfo.Nombre + " " + PersonaInfo.Apellido;
                Txt_Telefono.Text = PersonaInfo.Telefono;
                Txt_Direccion.Text = PersonaInfo.Direccion;
                Txt_Barrio.Text = PersonaInfo.Barrio;
                Txt_Correo.Text = PersonaInfo.Correo;
                Txt_Edad.Text = PersonaInfo.Edad;
                if (PersonaInfo.Sexo == "Masculino")
                {
                    Perfil_Masculino.Visible = true;
                    Perfil_Femenino.Visible = false;
                }
                else
                {
                    Perfil_Femenino.Visible = true;
                    Perfil_Masculino.Visible = false;
                }
                if (PersonaInfo.Sectores_Completados == "Sin Completar")
                {
                    picture_Completado.Visible = false;
                    picture_SinCompletar.Visible = true;
                    Txt_Estado_Censo.Text = "Sin Completar";
                }
                else
                {
                    picture_Completado.Visible = true;
                    picture_SinCompletar.Visible = false;
                    Txt_Estado_Censo.Text = "Completado";
                }
            }
        }


        private void Perfil_Femenino_Click(object sender, EventArgs e)
        {
            Panel_Foto.Visible = true;
        }

        private void Perfil_Masculino_Click(object sender, EventArgs e)
        {
            Panel_Foto.Visible = true;
        }

        private void timerhorafecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm");
            lbl_Fecha.Text = DateTime.Now.ToString("ddd M MMM yy");
        }
        private void panel1_Click(object sender, EventArgs e)
        {
        }

        //Persona DocPersona;
        //public Persona guardarDoc()
        //{
        //    foreach (var item in sp.GetAll())
        //    {
        //        DocPersona = Registrar.GuardarDocPersona(item);
        //    }         
        //    return DocPersona;
        //}

        private void label2_Click(object sender, EventArgs e)
        {
            foreach (Persona persona in sp.Obtener_Informacion(persona))
            {
                if (persona.Sectores_Completados == "Completado")
                {
                    label2.Text = "Encuesta Completada";
                }
                else
                {
                    Formulario_Encuestas forme = new Formulario_Encuestas();
                    forme.Info_Persona(Info_Persona(login.Numero_Documento, persona.Documento));
                    forme.Show();
                }
            }                        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
}
