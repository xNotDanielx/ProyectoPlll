namespace PresentacionGUI
{
    partial class Encuestas_Perfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encuestas_Perfil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer_Intro = new System.Windows.Forms.Timer(this.components);
            this.Panel_Encuesta = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelHoraFecha = new System.Windows.Forms.Panel();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.Panel_Status = new System.Windows.Forms.Panel();
            this.picture_SinCompletar = new System.Windows.Forms.PictureBox();
            this.Txt_Estado_Censo = new System.Windows.Forms.Label();
            this.picture_Completado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Info = new System.Windows.Forms.Panel();
            this.Panel_Foto = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Edad = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Txt_Correo = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Txt_Direccion = new System.Windows.Forms.Label();
            this.Txt_Barrio = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_Nombre_Apellido = new System.Windows.Forms.Label();
            this.Txt_NumeroD = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txt_Telefono = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Perfil_Masculino = new System.Windows.Forms.PictureBox();
            this.Perfil_Femenino = new System.Windows.Forms.PictureBox();
            this.timerhorafecha = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Encuesta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelHoraFecha.SuspendLayout();
            this.Panel_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SinCompletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Completado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Panel_Info.SuspendLayout();
            this.Panel_Foto.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Masculino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Femenino)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentacionGUI.Properties.Resources.InicioSenso;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Timer_Intro
            // 
            this.Timer_Intro.Enabled = true;
            this.Timer_Intro.Interval = 4000;
            // 
            // Panel_Encuesta
            // 
            this.Panel_Encuesta.BackColor = System.Drawing.Color.Black;
            this.Panel_Encuesta.Controls.Add(this.panel1);
            this.Panel_Encuesta.Controls.Add(this.PanelHoraFecha);
            this.Panel_Encuesta.Controls.Add(this.Panel_Status);
            this.Panel_Encuesta.Controls.Add(this.Logo);
            this.Panel_Encuesta.Controls.Add(this.Panel_Info);
            this.Panel_Encuesta.Location = new System.Drawing.Point(-2, -2);
            this.Panel_Encuesta.Name = "Panel_Encuesta";
            this.Panel_Encuesta.Size = new System.Drawing.Size(889, 587);
            this.Panel_Encuesta.TabIndex = 1;
            this.Panel_Encuesta.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(388, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 230);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 103);
            this.label2.TabIndex = 0;
            this.label2.Text = "INICIAR ENCUESTA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PanelHoraFecha
            // 
            this.PanelHoraFecha.BackColor = System.Drawing.Color.Transparent;
            this.PanelHoraFecha.Controls.Add(this.lbl_Fecha);
            this.PanelHoraFecha.Controls.Add(this.lbl_Hora);
            this.PanelHoraFecha.Location = new System.Drawing.Point(579, 4);
            this.PanelHoraFecha.Name = "PanelHoraFecha";
            this.PanelHoraFecha.Size = new System.Drawing.Size(307, 234);
            this.PanelHoraFecha.TabIndex = 4;
            this.PanelHoraFecha.Visible = false;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(99, 136);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(100, 33);
            this.lbl_Fecha.TabIndex = 1;
            this.lbl_Fecha.Text = "Domingo";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hora.Font = new System.Drawing.Font("Yu Gothic", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.White;
            this.lbl_Hora.Location = new System.Drawing.Point(54, 40);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(192, 96);
            this.lbl_Hora.TabIndex = 0;
            this.lbl_Hora.Text = "1:32";
            // 
            // Panel_Status
            // 
            this.Panel_Status.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Status.Controls.Add(this.picture_SinCompletar);
            this.Panel_Status.Controls.Add(this.Txt_Estado_Censo);
            this.Panel_Status.Controls.Add(this.picture_Completado);
            this.Panel_Status.Controls.Add(this.label1);
            this.Panel_Status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Panel_Status.Location = new System.Drawing.Point(276, 492);
            this.Panel_Status.Name = "Panel_Status";
            this.Panel_Status.Size = new System.Drawing.Size(237, 80);
            this.Panel_Status.TabIndex = 3;
            this.Panel_Status.Visible = false;
            // 
            // picture_SinCompletar
            // 
            this.picture_SinCompletar.BackColor = System.Drawing.Color.Transparent;
            this.picture_SinCompletar.Image = ((System.Drawing.Image)(resources.GetObject("picture_SinCompletar.Image")));
            this.picture_SinCompletar.Location = new System.Drawing.Point(7, 27);
            this.picture_SinCompletar.Name = "picture_SinCompletar";
            this.picture_SinCompletar.Size = new System.Drawing.Size(47, 39);
            this.picture_SinCompletar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_SinCompletar.TabIndex = 24;
            this.picture_SinCompletar.TabStop = false;
            // 
            // Txt_Estado_Censo
            // 
            this.Txt_Estado_Censo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Estado_Censo.AutoSize = true;
            this.Txt_Estado_Censo.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Estado_Censo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado_Censo.ForeColor = System.Drawing.Color.White;
            this.Txt_Estado_Censo.Location = new System.Drawing.Point(60, 34);
            this.Txt_Estado_Censo.Name = "Txt_Estado_Censo";
            this.Txt_Estado_Censo.Size = new System.Drawing.Size(170, 24);
            this.Txt_Estado_Censo.TabIndex = 23;
            this.Txt_Estado_Censo.Text = "Estado de Censo";
            // 
            // picture_Completado
            // 
            this.picture_Completado.BackColor = System.Drawing.Color.Transparent;
            this.picture_Completado.Image = ((System.Drawing.Image)(resources.GetObject("picture_Completado.Image")));
            this.picture_Completado.Location = new System.Drawing.Point(7, 27);
            this.picture_Completado.Name = "picture_Completado";
            this.picture_Completado.Size = new System.Drawing.Size(47, 39);
            this.picture_Completado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Completado.TabIndex = 22;
            this.picture_Completado.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estado de Censo";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(263, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(291, 235);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Visible = false;
            // 
            // Panel_Info
            // 
            this.Panel_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Info.BackgroundImage")));
            this.Panel_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Info.Controls.Add(this.Panel_Foto);
            this.Panel_Info.Controls.Add(this.panel10);
            this.Panel_Info.Controls.Add(this.panel12);
            this.Panel_Info.Controls.Add(this.panel7);
            this.Panel_Info.Controls.Add(this.panel9);
            this.Panel_Info.Controls.Add(this.panel4);
            this.Panel_Info.Controls.Add(this.panel6);
            this.Panel_Info.Controls.Add(this.panel5);
            this.Panel_Info.Controls.Add(this.Perfil_Masculino);
            this.Panel_Info.Controls.Add(this.Perfil_Femenino);
            this.Panel_Info.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel_Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Info.Location = new System.Drawing.Point(0, 0);
            this.Panel_Info.Name = "Panel_Info";
            this.Panel_Info.Size = new System.Drawing.Size(260, 587);
            this.Panel_Info.TabIndex = 0;
            this.Panel_Info.Visible = false;
            // 
            // Panel_Foto
            // 
            this.Panel_Foto.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Foto.Controls.Add(this.panel13);
            this.Panel_Foto.Location = new System.Drawing.Point(28, 244);
            this.Panel_Foto.Name = "Panel_Foto";
            this.Panel_Foto.Size = new System.Drawing.Size(192, 72);
            this.Panel_Foto.TabIndex = 24;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Controls.Add(this.label3);
            this.panel13.Controls.Add(this.Txt_Edad);
            this.panel13.Location = new System.Drawing.Point(21, 13);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(171, 36);
            this.panel13.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad :";
            // 
            // Txt_Edad
            // 
            this.Txt_Edad.AutoSize = true;
            this.Txt_Edad.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Edad.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Edad.ForeColor = System.Drawing.Color.White;
            this.Txt_Edad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Txt_Edad.Location = new System.Drawing.Point(105, 1);
            this.Txt_Edad.Name = "Txt_Edad";
            this.Txt_Edad.Size = new System.Drawing.Size(83, 35);
            this.Txt_Edad.TabIndex = 25;
            this.Txt_Edad.Text = "Edad";
            this.Txt_Edad.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.Txt_Correo);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel10.Location = new System.Drawing.Point(47, 478);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(172, 45);
            this.panel10.TabIndex = 7;
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Correo.AutoSize = true;
            this.Txt_Correo.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Correo.ForeColor = System.Drawing.Color.White;
            this.Txt_Correo.Location = new System.Drawing.Point(2, 14);
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.Size = new System.Drawing.Size(61, 18);
            this.Txt_Correo.TabIndex = 21;
            this.Txt_Correo.Text = "Correo";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel12.Location = new System.Drawing.Point(9, 478);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(40, 45);
            this.panel12.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.Txt_Direccion);
            this.panel7.Controls.Add(this.Txt_Barrio);
            this.panel7.Location = new System.Drawing.Point(47, 399);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 45);
            this.panel7.TabIndex = 7;
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Direccion.AutoSize = true;
            this.Txt_Direccion.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Direccion.ForeColor = System.Drawing.Color.White;
            this.Txt_Direccion.Location = new System.Drawing.Point(3, 0);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(85, 18);
            this.Txt_Direccion.TabIndex = 20;
            this.Txt_Direccion.Text = "Direccion ";
            // 
            // Txt_Barrio
            // 
            this.Txt_Barrio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Barrio.AutoSize = true;
            this.Txt_Barrio.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Barrio.ForeColor = System.Drawing.Color.White;
            this.Txt_Barrio.Location = new System.Drawing.Point(3, 20);
            this.Txt_Barrio.Name = "Txt_Barrio";
            this.Txt_Barrio.Size = new System.Drawing.Size(54, 18);
            this.Txt_Barrio.TabIndex = 22;
            this.Txt_Barrio.Text = "Barrio";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(4, 399);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(40, 45);
            this.panel9.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.Txt_Nombre_Apellido);
            this.panel4.Controls.Add(this.Txt_NumeroD);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 45);
            this.panel4.TabIndex = 5;
            // 
            // Txt_Nombre_Apellido
            // 
            this.Txt_Nombre_Apellido.AutoSize = true;
            this.Txt_Nombre_Apellido.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Nombre_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre_Apellido.ForeColor = System.Drawing.Color.White;
            this.Txt_Nombre_Apellido.Location = new System.Drawing.Point(3, 4);
            this.Txt_Nombre_Apellido.Name = "Txt_Nombre_Apellido";
            this.Txt_Nombre_Apellido.Size = new System.Drawing.Size(77, 18);
            this.Txt_Nombre_Apellido.TabIndex = 18;
            this.Txt_Nombre_Apellido.Text = "Nombres";
            this.Txt_Nombre_Apellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_NumeroD
            // 
            this.Txt_NumeroD.AutoSize = true;
            this.Txt_NumeroD.BackColor = System.Drawing.Color.Transparent;
            this.Txt_NumeroD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroD.ForeColor = System.Drawing.Color.White;
            this.Txt_NumeroD.Location = new System.Drawing.Point(3, 22);
            this.Txt_NumeroD.Name = "Txt_NumeroD";
            this.Txt_NumeroD.Size = new System.Drawing.Size(163, 16);
            this.Txt_NumeroD.TabIndex = 20;
            this.Txt_NumeroD.Text = "Numero de documento";
            this.Txt_NumeroD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.Txt_Telefono);
            this.panel6.Location = new System.Drawing.Point(47, 314);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 45);
            this.panel6.TabIndex = 5;
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Telefono.AutoSize = true;
            this.Txt_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Telefono.ForeColor = System.Drawing.Color.White;
            this.Txt_Telefono.Location = new System.Drawing.Point(2, 15);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(74, 18);
            this.Txt_Telefono.TabIndex = 20;
            this.Txt_Telefono.Text = "Telefono";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(9, 314);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 46);
            this.panel5.TabIndex = 3;
            // 
            // Perfil_Masculino
            // 
            this.Perfil_Masculino.BackColor = System.Drawing.Color.Transparent;
            this.Perfil_Masculino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Perfil_Masculino.Image = ((System.Drawing.Image)(resources.GetObject("Perfil_Masculino.Image")));
            this.Perfil_Masculino.Location = new System.Drawing.Point(28, 54);
            this.Perfil_Masculino.Name = "Perfil_Masculino";
            this.Perfil_Masculino.Size = new System.Drawing.Size(191, 184);
            this.Perfil_Masculino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Perfil_Masculino.TabIndex = 23;
            this.Perfil_Masculino.TabStop = false;
            this.Perfil_Masculino.Visible = false;
            // 
            // Perfil_Femenino
            // 
            this.Perfil_Femenino.BackColor = System.Drawing.Color.Transparent;
            this.Perfil_Femenino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Perfil_Femenino.Image = ((System.Drawing.Image)(resources.GetObject("Perfil_Femenino.Image")));
            this.Perfil_Femenino.Location = new System.Drawing.Point(28, 54);
            this.Perfil_Femenino.Name = "Perfil_Femenino";
            this.Perfil_Femenino.Size = new System.Drawing.Size(191, 184);
            this.Perfil_Femenino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Perfil_Femenino.TabIndex = 1;
            this.Perfil_Femenino.TabStop = false;
            this.Perfil_Femenino.Visible = false;
            // 
            // timerhorafecha
            // 
            this.timerhorafecha.Enabled = true;
            this.timerhorafecha.Tick += new System.EventHandler(this.timerhorafecha_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 4);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 4);
            this.panel2.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(1, 41);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(168, 4);
            this.panel11.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(1, 41);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(168, 4);
            this.panel8.TabIndex = 4;
            // 
            // Encuestas_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 582);
            this.Controls.Add(this.Panel_Encuesta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encuestas_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Encuesta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelHoraFecha.ResumeLayout(false);
            this.PanelHoraFecha.PerformLayout();
            this.Panel_Status.ResumeLayout(false);
            this.Panel_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SinCompletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Completado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Panel_Info.ResumeLayout(false);
            this.Panel_Foto.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Masculino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Femenino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Timer_Intro;
        private System.Windows.Forms.Panel Panel_Encuesta;
        private System.Windows.Forms.Panel Panel_Info;
        private System.Windows.Forms.PictureBox Perfil_Femenino;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox Perfil_Masculino;
        private System.Windows.Forms.Label Txt_Barrio;
        private System.Windows.Forms.Label Txt_Correo;
        private System.Windows.Forms.Label Txt_NumeroD;
        private System.Windows.Forms.Label Txt_Direccion;
        private System.Windows.Forms.Label Txt_Telefono;
        private System.Windows.Forms.Label Txt_Nombre_Apellido;
        private System.Windows.Forms.Panel Panel_Foto;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel Panel_Status;
        private System.Windows.Forms.Panel PanelHoraFecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.PictureBox picture_SinCompletar;
        private System.Windows.Forms.Label Txt_Estado_Censo;
        private System.Windows.Forms.PictureBox picture_Completado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Txt_Edad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Timer timerhorafecha;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}