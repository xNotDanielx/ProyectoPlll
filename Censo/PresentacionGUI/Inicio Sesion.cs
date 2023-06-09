﻿using Datos;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static PresentacionGUI.DbCensoDataSet1;

namespace PresentacionGUI
{
    public partial class Form_InicioSesion : Form
    {
        Logica.ServicioLogin sl = new Logica.ServicioLogin(configConnnection.ConnectionString);
        Logica.ServicioPersona sp= new Logica.ServicioPersona(configConnnection.ConnectionString);
        Encuestas_Perfil ec = new Encuestas_Perfil();
        Login login = new Login();
        Persona persona = new Persona();
        public Form_InicioSesion()
        {
            InitializeComponent();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }
        public void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string NC_persona;
        String ND_Persona;
        public void Btn_Login_Click(object sender, EventArgs e)
        {
            
            if (Opc_CC.Checked)
            {
                if (Txt_NDocumento.Text.Length <= 7 || Txt_NDocumento.Text.Length >= 11)
                {
                    Picture_Error1.Visible = true;
                    Picture_Error2.Visible = true;
                    Picture_Error3.Visible = false;
                    Picture_Error4.Visible = false;
                }
                else
                {
                    Picture_Error1.Visible = false;
                    Picture_Error2.Visible = false;
                    Picture_Error3.Visible = false;
                    Picture_Error4.Visible = false;
                    login.Numero_Documento = Txt_NDocumento.Text;
                    login.Contraseña = Txt_Contraseña.Text;
                    if (sl.Buscar_Cuenta(login) == true)
                    {
                        buscarCuenta();
                    }
                    else
                    {
                        Picture_Error1.Visible = false;
                        Picture_Error2.Visible = false;
                        Picture_Error3.Visible = true;
                        Picture_Error4.Visible = true;
                    }
                }
            }
            else if (Opc_CE.Checked)
            {
                if (Txt_NDocumento.Text.Length <= 5 || Txt_NDocumento.Text.Length >= 8)
                {
                    Picture_Error1.Visible = true;
                    Picture_Error2.Visible = true;
                    Picture_Error3.Visible = false;
                    Picture_Error4.Visible = false;
                }
                else
                {
                    buscarCuenta();
                }
            }
            else
            {
                Picture_Error1.Visible = true;
                Picture_Error2.Visible = true;
                Picture_Error3.Visible = false;
                Picture_Error4.Visible = false;
            }
        }

        private void Txt_NDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        public void buscarCuenta()
        {
            
            Picture_Error1.Visible = false;
            Picture_Error2.Visible = false;
            Picture_Error3.Visible = false;
            Picture_Error4.Visible = false;
            login.Numero_Documento = Txt_NDocumento.Text.ToString();
            login.Contraseña = Txt_Contraseña.Text.ToString();
            if (sl.Buscar_Cuenta(login) == true)
            {
                foreach (Login personaLog in sl.Obtener_Informacion(login))
                {
                    NC_persona = personaLog.Numero_Documento;
                }
                ND_Persona = login.Numero_Documento;
                Opc_CC.Checked = false;
                Opc_CE.Checked = false;
                login.Numero_Documento = "";
                login.Contraseña = "";
                Txt_NDocumento.Text = "";
                Txt_Contraseña.Text = "";                
                Encuestas_Perfil ec = new Encuestas_Perfil();
                ec.Info_Persona(ND_Persona, NC_persona);
                ec.Show();
                
            }
            else
            {
                Picture_Error1.Visible = false;
                Picture_Error2.Visible = false;
                Picture_Error3.Visible = true;
                Picture_Error4.Visible = true;
            }
        }

        private void Txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Txt_Contraseña.UseSystemPasswordChar = true;
            Txt_Contraseña.PasswordChar = '*';
        }
    }
    
}

