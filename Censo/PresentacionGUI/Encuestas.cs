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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Timers;
using System.Drawing.Imaging;
using Entidades;
using Logica;
using System.Reflection;

namespace PresentacionGUI
{
    public partial class Encuestas : Form
    {
        int Contador = 0;
        Login login = new Login();
        Persona persona = new Persona();
        ServicioLogin sl = new ServicioLogin();
        ServicioPersona sp = new ServicioPersona();
        int i;
        public Encuestas()
        {
            InitializeComponent();
            InitializeTimer();
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
                pictureBox1.Dispose();
                Timer_Intro.Stop();
                Iniciar_Info();
            }
        }
        public void Info_Persona(string NdUsuario, string InfoUsuario)
        {
            login.Numero_Documento = NdUsuario;
            persona.Documento = InfoUsuario;
        }
        private void Iniciar_Info()
        {
            Console.WriteLine("NC: " + persona.Documento);
            Console.WriteLine("ID: " + login.Numero_Documento);
            Panel_Encuesta.Visible = true;
            PanelHoraFecha.Visible = true;
            Panel_Info.Visible = true;
            Panel_Status.Visible = true;
            Logo.Visible = true;
            List<Login> loginI = sl.Obtener_Informacion(login);
            List<Persona> personaI = sp.Obtener_Informacion(persona);
            foreach (Login LoginInfo in loginI)
            {
                Txt_NumeroD.Text = LoginInfo.Numero_Documento;
            }

            foreach (Persona PersonaInfo in personaI)
            {

                Txt_Nombre_Apellido.Text = PersonaInfo.Nombre + " " + PersonaInfo.Apellido;
                Txt_Telefono.Text = PersonaInfo.Telefono;
                Txt_Direccion.Text = PersonaInfo.Direccion;
                Txt_Barrio.Text = PersonaInfo.Barrio;
                Txt_Correo.Text = PersonaInfo.Correo;
                if (PersonaInfo.Sexo == "Masculino")
                {
                    Perfil_Masculino.Visible = true;
                    Btn_Tomar_Foto.Visible = false;
                    Btn_Subir_Foto.Visible = false;
                    Perfil_Femenino.Dispose();
                }
                else
                {
                    Perfil_Femenino.Visible = true;
                    Btn_Tomar_Foto.Visible = false;
                    Btn_Subir_Foto.Visible = false;
                    Perfil_Masculino.Dispose();
                }
                if(PersonaInfo.Sectores_Completados == "Sin Completar")
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

        private void Perfil_Masculino_Click_1(object sender, EventArgs e)
        {
            Btn_Tomar_Foto.Visible = true;
            panel_tomarfoto.Visible = true;
            Btn_Subir_Foto.Visible = true;
            panel_subirfoto.Visible = true;
        }

        private void Perfil_Femenino_Click_1(object sender, EventArgs e)
        {
            Btn_Tomar_Foto.Visible = true;
            Btn_Subir_Foto.Visible = true;
        }

        private void timerhorafecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm");
            lbl_Fecha.Text = DateTime.Now.ToString("ddd M MMM yy");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
