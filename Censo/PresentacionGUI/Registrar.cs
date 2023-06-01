using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class Form_Registrar : Form
    {
        Login login = new Login();
        Persona persona = new Persona();
        ServicioLogin sl = new ServicioLogin();
        ServicioPersona sp = new ServicioPersona();
        public Form_Registrar()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Txt_Ndocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Txt_Nombres_TextChanged(object sender, EventArgs e)
        {
            Txt_Nombres.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Txt_Nombres.Text);
            Txt_Nombres.SelectionStart = Txt_Nombres.Text.Length;
        }

        private void Txt_Apellidos_TextChanged(object sender, EventArgs e)
        {
            Txt_Apellidos.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Txt_Apellidos.Text);
            Txt_Apellidos.SelectionStart = Txt_Apellidos.Text.Length;
        }

        private void Txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Txt_Barrio_TextChanged(object sender, EventArgs e)
        {
            Txt_Barrio.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Txt_Barrio.Text);
            Txt_Barrio.SelectionStart = Txt_Barrio.Text.Length;
        }
        bool TDocumento = false;
        bool NDocumento = false;
        bool Contraseña = false;
        bool Nombres = false;
        bool Apellidos = false;
        bool Fecha_Nacimiento = false;
        bool Sexo = false;
        bool Telefono = false;
        bool Direccion = false;
        bool Barrio = false;
        bool Tipo_Vivienda = false;
        bool Correo = false;

        public void GuardarDocumento()
        {
            try
            {
                if (Opc_CC.Checked)
                {
                    Error_TipoD.Visible = false;
                    login.Tipo_Documento = "CC";
                    if (Txt_Ndocumento.Text.Length <= 7 || Txt_Ndocumento.Text.Length >= 11)
                    {
                        TDocumento = false;
                        NDocumento = false;
                        Error_NDocumento.Visible = true;
                    }
                    else
                    {
                        Error_NDocumento.Visible = false;
                        login.Numero_Documento = Txt_Ndocumento.Text.ToString();
                        persona.Documento = Txt_Ndocumento.Text;
                        TDocumento = true;
                        NDocumento = true;
                    }
                }
                else if (Opc_CE.Checked)
                {
                    Error_TipoD.Visible = false;
                    login.Tipo_Documento = "CE";
                    if (Txt_Ndocumento.Text.Length <= 5 || Txt_Ndocumento.Text.Length >= 8)
                    {
                        TDocumento = false;
                        NDocumento = false;
                        Error_NDocumento.Visible = true;
                    }
                    else
                    {
                        Error_NDocumento.Visible = false;
                        login.Numero_Documento = Txt_Ndocumento.Text.ToString();
                        persona.Documento = Txt_Ndocumento.Text;
                        TDocumento = true;
                        NDocumento = true;
                    }
                }
                else
                {
                    TDocumento = false;
                    NDocumento = false;
                    Error_TipoD.Visible = true;
                }
            }
            catch
            {

            }
        }
        public void GuardarContraseña()
        {
            try
            {
                if (Txt_Contraseña.Text.Length <= 7)
                {
                    Contraseña = false;
                    Error_Contraseña.Visible = true;
                    Error_ConfContraseña.Visible = true;
                }
                else if (Txt_Contraseña.Text.Equals(Txt_ConfContraseña.Text))
                {
                    Contraseña = true;
                    Error_ConfContraseña.Visible = false;
                    Error_Contraseña.Visible = false;
                    login.Contraseña = Txt_Contraseña.Text.ToString();
                }
                else
                {
                    Contraseña = false;
                    Error_Contraseña.Visible = false;
                    Error_ConfContraseña.Visible = true;
                }
            }
            catch
            {

            }
        }

        public void GuardarNombres()
        {
            try
            {
                if (Txt_Nombres.Text.Length <= 4)
                {
                    Nombres = false;
                    Error_Nombres.Visible = true;
                }
                else
                {
                    Error_Nombres.Visible = false;
                    persona.Nombre = Txt_Nombres.Text.ToString();
                    Nombres = true;
                }
            }
            catch
            {

            }
        }

        public void GuardarApellidos()
        {
            try
            {
                if (Txt_Nombres.Text.Length <= 4)
                {
                    Apellidos = false;
                    Error_Apellidos.Visible = true;
                }
                else
                {
                    Apellidos = true;
                    Error_Apellidos.Visible = false;
                    persona.Apellido = Txt_Apellidos.Text.ToString();
                }
            }
            catch
            {

            }
        }

        public void GuardarFechaNacimiento()
        {
            try
            {
                int Edad_Verifficar = DateTime.Today.Year - F_Nacimiento.Value.Year;
                if (DateTime.Today < F_Nacimiento.Value.AddYears(Edad_Verifficar))
                {
                    Edad_Verifficar--;
                }
                if (F_Nacimiento.Value > DateTime.Now)
                {
                    Fecha_Nacimiento = false;
                    Error_FechaNacimiento.Visible = true;
                }
                else if (Edad_Verifficar <= 17)
                {
                    Fecha_Nacimiento = false;
                    Error_FechaNacimiento.Visible = true;
                }
                else
                {
                    Fecha_Nacimiento = true;
                    Error_FechaNacimiento.Visible = false;
                    persona.FechaNacimiento = F_Nacimiento.Value;
                }
            }
            catch
            {

            }
        }
        public void GuardarSexo()
        {
            try
            {
                if (Opc_M.Checked)
                {
                    Sexo = true;
                    Error_Sexo.Visible = false;
                    persona.Sexo = "Masculino";
                }
                else if (Opc_F.Checked)
                {
                    Sexo = true;
                    Error_Sexo.Visible = false;
                    persona.Sexo = "Femenino";
                }
                else
                {
                    Sexo = false;
                    Error_Sexo.Visible = true;
                }
            }
            catch
            {

            }
        }

        public void GuardarEdad()
        {
            try
            {
                int edad = DateTime.Today.Year - F_Nacimiento.Value.Year;
                if (DateTime.Today < F_Nacimiento.Value.AddYears(edad))
                {
                    edad--;
                }
                persona.Edad = edad.ToString();
            }
            catch
            {

            }
        }

        public void GuardarTelefono()
        {
            try
            {
                if ((Txt_Telefono.Text.Length <= 9) || (Txt_Telefono.Text.Length >= 11))
                {
                    Telefono = false;
                    Error_Telefono.Visible = true;
                }
                else
                {
                    Telefono = true;
                    Error_Telefono.Visible = false;
                    persona.Telefono = Txt_Telefono.Text.ToString();
                }
            }
            catch
            {

            }
        }

        public void GuardarDireccion()
        {
            try
            {
                string DireccionPersona;
                if ((Txt_Cra.Text.Length <= 1) || (Txt_Cra.Text.Length >= 4))
                {
                    Direccion = false;
                    Error_Direccion.Visible = true;
                }
                else if ((Txt_Cra2.Text.Length <= 3) || (Txt_Cra2.Text.Length >= 6))
                {
                    Direccion = false;
                    Error_Direccion.Visible = true;
                }
                else
                {
                    Direccion = true;
                    Error_Direccion.Visible = false;
                    DireccionPersona = "Cra" + Txt_Cra.Text + "#" + Txt_Cra2.Text;
                    persona.Direccion = DireccionPersona.ToString();
                }
            }
            catch
            {

            }
        }

        public void GuardarBarrio()
        {
            try
            {
                if (Txt_Barrio.Text.Length <= 3)
                {
                    Barrio = false;
                    Error_Barrio.Visible = true;
                }
                else
                {
                    Barrio = true;
                    Error_Barrio.Visible = false;
                    persona.Barrio = Txt_Barrio.Text.ToString();
                }
            }
            catch
            {

            }
        }

        public void GuardarTipoVivienda()
        {
            try
            {
                if (Opc_Hogar.Checked)
                {
                    Error_Tipo_Vivienda.Visible = false;
                    persona.Tipo_Vivienda = "Hogar";
                    Tipo_Vivienda = true;
                }
                else if (Opc_Apartamento.Checked)
                {
                    Error_Tipo_Vivienda.Visible = false;
                    persona.Tipo_Vivienda = "Apartamento";
                    Tipo_Vivienda = true;
                }
                else
                {
                    Tipo_Vivienda = false;
                    Error_Tipo_Vivienda.Visible = true;
                }
            }
            catch
            {

            }
        }

        public void GuardarCorreo()
        {
            try
            {
                if (Txt_Correo.Text.Contains(""))
                {
                    Correo = true;
                    Error_Correo.Visible = false;
                    persona.Correo = "Sin Correo";
                }
                else if (Txt_Correo.Text.Contains("@hotmail.com") || Txt_Correo.Text.Contains("@outlook.com") || Txt_Correo.Text.Contains("@gmail.com"))
                {
                    Correo = true;
                    Error_Correo.Visible = false;
                    persona.Correo = Txt_Correo.Text.ToString();
                }
                else
                {
                    Correo = false;
                    Error_Correo.Visible = true;
                }
            }
            catch
            {
            }
        }

        public void Verificacion()
        {
            if (TDocumento == true && NDocumento == true && Contraseña == true && Nombres == true && Apellidos == true && Fecha_Nacimiento == true && Sexo == true && Telefono == true && Direccion == true && Barrio == true && Tipo_Vivienda == true && Correo == true)
            {
                if (login.Cuentas_Registradas == 0)
                {
                    Picture_Registrado.Visible = true;
                    picture_Regist.Visible = true;
                    Picture_Error1.Visible = false;
                    Picture_Error2.Visible = false;
                    Error_Cdupli.Visible = false;
                    picture_Cdupli.Visible = false;
                    persona.Sectores_Completados = "Sin Completar";
                    login.Cuentas_Registradas += 1;

                    sl.Añadir(login);
                    sp.Añadir(persona);
                }
                else
                {
                    if (sl.Buscar_Persona(login) == true)
                    {
                        Error_Cdupli.Visible = true;
                        picture_Cdupli.Visible = true;
                        Console.WriteLine("Este Documento ya se encuentra Registrado");
                    }
                    else
                    {
                        Picture_Registrado.Visible = true;
                        picture_Regist.Visible = true;
                        Picture_Error1.Visible = false;
                        Picture_Error2.Visible = false;
                        login.Cuentas_Registradas = login.Cuentas_Registradas + 1;
                        persona.Documento = persona.Documento + 1;
                        persona.Sectores_Completados = "Sin Completar";
                        sl.Añadir(login);
                        sp.Añadir(persona);
                        Console.WriteLine("");
                    }
                }
            }
            else
            {
                Picture_Error1.Visible = true;
                Picture_Error2.Visible = true;
            }
        }
        public void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            //Tipo de documento y Numero de documento
            GuardarDocumento();

            //Contraseña
            GuardarContraseña();

            //Nombre
            GuardarNombres();

            //Apellido
            GuardarApellidos();

            //Fecha Nacimiento
            GuardarFechaNacimiento();

            //Sexo
            GuardarSexo();

            //Edad
            GuardarEdad();

            //Telefono
            GuardarTelefono();

            //Direccion
            GuardarDireccion();

            //Barrio
            GuardarBarrio();

            //Tipo de Vivienda
            GuardarTipoVivienda();

            //Correo
            GuardarCorreo();

            Verificacion();
           
        }
        public void MostrarMensajeAyuda(PictureBox pic, String mensaje)
        {
            var mensajeAyuda = new ToolTip();
            mensajeAyuda.SetToolTip(pic, mensaje);
        }
        private void Error_NDocumento_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_NDocumento, "Escriba correctamente su documento");
        }

        private void Error_Contraseña_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Contraseña, "Escriba correctamente la contraseña");
        }

        private void Error_ConfContraseña_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_ConfContraseña, "Las contraseñas no coinciden");
        }

        private void Error_Nombres_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Nombres, "No puede dejar este campo vacío");
        }

        private void Error_Apellidos_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Apellidos, "No puede dejar este campo vacío");
        }

        private void Error_FechaNacimiento_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_FechaNacimiento, "No puede ser menor de edad");
        }

        private void Error_Sexo_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Sexo, "Tiene que seleccionar uno");
        }

        private void Error_Telefono_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Telefono, "Escriba correctamente el numero de telefono");
        }

        private void Error_Direccion_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Direccion, "Escriba correctamente la direccion");
        }

        private void Error_Barrio_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Barrio, "Escriba correcttamente el barrio");
        }

        private void Error_Tipo_Vivienda_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_Tipo_Vivienda, "Tiene que seleccionar uno");
        }

        private void Error_TipoD_MouseHover(object sender, EventArgs e)
        {
            MostrarMensajeAyuda(Error_TipoD, "Tiene que seleccionar uno");
        }
    }

}
