using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PresentacionGUI
{
    public partial class Frm_Ayuda : Form
    {
        public Frm_Ayuda()
        {
            InitializeComponent();
        }

        private void Frm_Ayuda_Load(object sender, EventArgs e)
        {
            LkLabel_LinkBlog.Text = "Ayuda Censo";
            LkLabel_LinkBlog.LinkClicked += LkLabel_LinkBlog_LinkClicked;
        }

        private void LkLabel_LinkBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ayudacenso.blogspot.com/");
        }
    }
}
