namespace PresentacionGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Barra_Superior = new System.Windows.Forms.Panel();
            this.btn_VentanaMin = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_VentanaMax = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Censo_Base = new System.Windows.Forms.Panel();
            this.Barra_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VentanaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VentanaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Superior
            // 
            this.Barra_Superior.BackColor = System.Drawing.Color.Purple;
            this.Barra_Superior.Controls.Add(this.btn_VentanaMin);
            this.Barra_Superior.Controls.Add(this.btn_Minimizar);
            this.Barra_Superior.Controls.Add(this.btn_VentanaMax);
            this.Barra_Superior.Controls.Add(this.btn_Cerrar);
            this.Barra_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Superior.Location = new System.Drawing.Point(0, 0);
            this.Barra_Superior.Name = "Barra_Superior";
            this.Barra_Superior.Size = new System.Drawing.Size(1300, 50);
            this.Barra_Superior.TabIndex = 0;
            // 
            // btn_VentanaMin
            // 
            this.btn_VentanaMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VentanaMin.Image = ((System.Drawing.Image)(resources.GetObject("btn_VentanaMin.Image")));
            this.btn_VentanaMin.Location = new System.Drawing.Point(1202, 5);
            this.btn_VentanaMin.Name = "btn_VentanaMin";
            this.btn_VentanaMin.Size = new System.Drawing.Size(40, 39);
            this.btn_VentanaMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_VentanaMin.TabIndex = 3;
            this.btn_VentanaMin.TabStop = false;
            this.btn_VentanaMin.Click += new System.EventHandler(this.btn_VentanaMin_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(1156, 4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(40, 39);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_VentanaMax
            // 
            this.btn_VentanaMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VentanaMax.Image = ((System.Drawing.Image)(resources.GetObject("btn_VentanaMax.Image")));
            this.btn_VentanaMax.Location = new System.Drawing.Point(1202, 4);
            this.btn_VentanaMax.Name = "btn_VentanaMax";
            this.btn_VentanaMax.Size = new System.Drawing.Size(40, 38);
            this.btn_VentanaMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_VentanaMax.TabIndex = 1;
            this.btn_VentanaMax.TabStop = false;
            this.btn_VentanaMax.Click += new System.EventHandler(this.btn_VentanaMax_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1248, 4);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(40, 39);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 600);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Censo_Base
            // 
            this.Censo_Base.BackColor = System.Drawing.Color.DarkViolet;
            this.Censo_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Censo_Base.Location = new System.Drawing.Point(220, 50);
            this.Censo_Base.Name = "Censo_Base";
            this.Censo_Base.Size = new System.Drawing.Size(1080, 600);
            this.Censo_Base.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Censo_Base);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Barra_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_VentanaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VentanaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Superior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Censo_Base;
        private System.Windows.Forms.PictureBox btn_VentanaMin;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox btn_VentanaMax;
        private System.Windows.Forms.PictureBox btn_Cerrar;
    }
}