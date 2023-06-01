namespace PresentacionGUI
{
    partial class Form_InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InicioSesion));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_NDocumento = new System.Windows.Forms.TextBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Group_TipoD = new System.Windows.Forms.GroupBox();
            this.Opc_CE = new System.Windows.Forms.RadioButton();
            this.Opc_CC = new System.Windows.Forms.RadioButton();
            this.Picture_Error1 = new System.Windows.Forms.PictureBox();
            this.Picture_Error2 = new System.Windows.Forms.Label();
            this.Picture_Error3 = new System.Windows.Forms.PictureBox();
            this.Picture_Error4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Group_TipoD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Error3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(464, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de documento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(464, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Login.ForeColor = System.Drawing.Color.Black;
            this.Btn_Login.Location = new System.Drawing.Point(642, 406);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(187, 50);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "INICIAR SESION";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txt_NDocumento
            // 
            this.Txt_NDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_NDocumento.Location = new System.Drawing.Point(467, 230);
            this.Txt_NDocumento.Name = "Txt_NDocumento";
            this.Txt_NDocumento.Size = new System.Drawing.Size(295, 24);
            this.Txt_NDocumento.TabIndex = 7;
            this.Txt_NDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NDocumento_KeyPress);
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Contraseña.Location = new System.Drawing.Point(467, 295);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(295, 24);
            this.Txt_Contraseña.TabIndex = 10;
            this.Txt_Contraseña.TextChanged += new System.EventHandler(this.Txt_Contraseña_TextChanged);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cancelar.Location = new System.Drawing.Point(418, 406);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(187, 50);
            this.Btn_Cancelar.TabIndex = 11;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Group_TipoD
            // 
            this.Group_TipoD.Controls.Add(this.Opc_CE);
            this.Group_TipoD.Controls.Add(this.Opc_CC);
            this.Group_TipoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Group_TipoD.ForeColor = System.Drawing.Color.Black;
            this.Group_TipoD.Location = new System.Drawing.Point(418, 133);
            this.Group_TipoD.Name = "Group_TipoD";
            this.Group_TipoD.Size = new System.Drawing.Size(400, 61);
            this.Group_TipoD.TabIndex = 13;
            this.Group_TipoD.TabStop = false;
            this.Group_TipoD.Text = "Tipo de documento";
            // 
            // Opc_CE
            // 
            this.Opc_CE.AutoSize = true;
            this.Opc_CE.Location = new System.Drawing.Point(191, 25);
            this.Opc_CE.Name = "Opc_CE";
            this.Opc_CE.Size = new System.Drawing.Size(186, 22);
            this.Opc_CE.TabIndex = 1;
            this.Opc_CE.TabStop = true;
            this.Opc_CE.Text = "Cedula de Extranjeria";
            this.Opc_CE.UseVisualStyleBackColor = true;
            // 
            // Opc_CC
            // 
            this.Opc_CC.AutoSize = true;
            this.Opc_CC.Location = new System.Drawing.Point(15, 25);
            this.Opc_CC.Name = "Opc_CC";
            this.Opc_CC.Size = new System.Drawing.Size(162, 22);
            this.Opc_CC.TabIndex = 0;
            this.Opc_CC.TabStop = true;
            this.Opc_CC.Text = "Cedula Ciudadana";
            this.Opc_CC.UseVisualStyleBackColor = true;
            // 
            // Picture_Error1
            // 
            this.Picture_Error1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Picture_Error1.BackColor = System.Drawing.Color.DarkRed;
            this.Picture_Error1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picture_Error1.BackgroundImage")));
            this.Picture_Error1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture_Error1.Location = new System.Drawing.Point(460, 348);
            this.Picture_Error1.Name = "Picture_Error1";
            this.Picture_Error1.Size = new System.Drawing.Size(56, 45);
            this.Picture_Error1.TabIndex = 47;
            this.Picture_Error1.TabStop = false;
            this.Picture_Error1.Visible = false;
            // 
            // Picture_Error2
            // 
            this.Picture_Error2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Picture_Error2.BackColor = System.Drawing.Color.Red;
            this.Picture_Error2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture_Error2.ForeColor = System.Drawing.Color.Snow;
            this.Picture_Error2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Picture_Error2.Location = new System.Drawing.Point(510, 348);
            this.Picture_Error2.Name = "Picture_Error2";
            this.Picture_Error2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Picture_Error2.Size = new System.Drawing.Size(255, 45);
            this.Picture_Error2.TabIndex = 46;
            this.Picture_Error2.Text = "LLENE TODAS LAS CASILLAS CORRECTAMENTE";
            this.Picture_Error2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Picture_Error2.Visible = false;
            // 
            // Picture_Error3
            // 
            this.Picture_Error3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Picture_Error3.BackColor = System.Drawing.Color.DarkRed;
            this.Picture_Error3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picture_Error3.BackgroundImage")));
            this.Picture_Error3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture_Error3.Location = new System.Drawing.Point(460, 348);
            this.Picture_Error3.Name = "Picture_Error3";
            this.Picture_Error3.Size = new System.Drawing.Size(56, 45);
            this.Picture_Error3.TabIndex = 49;
            this.Picture_Error3.TabStop = false;
            this.Picture_Error3.Visible = false;
            // 
            // Picture_Error4
            // 
            this.Picture_Error4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Picture_Error4.BackColor = System.Drawing.Color.Red;
            this.Picture_Error4.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture_Error4.ForeColor = System.Drawing.Color.Snow;
            this.Picture_Error4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Picture_Error4.Location = new System.Drawing.Point(510, 348);
            this.Picture_Error4.Name = "Picture_Error4";
            this.Picture_Error4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Picture_Error4.Size = new System.Drawing.Size(255, 45);
            this.Picture_Error4.TabIndex = 48;
            this.Picture_Error4.Text = "DOCUMENTO / CONRASEÑA INCORECTA";
            this.Picture_Error4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Picture_Error4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form_InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(866, 550);
            this.Controls.Add(this.Picture_Error3);
            this.Controls.Add(this.Picture_Error4);
            this.Controls.Add(this.Picture_Error1);
            this.Controls.Add(this.Picture_Error2);
            this.Controls.Add(this.Group_TipoD);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_NDocumento);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_InicioSesion";
            this.Text = "Form2";
            this.Group_TipoD.ResumeLayout(false);
            this.Group_TipoD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Error3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox Txt_NDocumento;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox Group_TipoD;
        private System.Windows.Forms.RadioButton Opc_CE;
        private System.Windows.Forms.RadioButton Opc_CC;
        private System.Windows.Forms.PictureBox Picture_Error1;
        private System.Windows.Forms.Label Picture_Error2;
        private System.Windows.Forms.PictureBox Picture_Error3;
        private System.Windows.Forms.Label Picture_Error4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}