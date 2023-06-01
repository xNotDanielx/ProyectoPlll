namespace PresentacionGUI
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel15 = new System.Windows.Forms.Panel();
            this.Btn_Cuentas = new System.Windows.Forms.Button();
            this.Btn_Reultados = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel15.BackgroundImage")));
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel15.Location = new System.Drawing.Point(291, 24);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(221, 186);
            this.panel15.TabIndex = 61;
            // 
            // Btn_Cuentas
            // 
            this.Btn_Cuentas.BackColor = System.Drawing.Color.Black;
            this.Btn_Cuentas.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cuentas.ForeColor = System.Drawing.Color.White;
            this.Btn_Cuentas.Location = new System.Drawing.Point(291, 245);
            this.Btn_Cuentas.Name = "Btn_Cuentas";
            this.Btn_Cuentas.Size = new System.Drawing.Size(221, 57);
            this.Btn_Cuentas.TabIndex = 62;
            this.Btn_Cuentas.Text = "Gestionar Cuentas";
            this.Btn_Cuentas.UseVisualStyleBackColor = false;
            // 
            // Btn_Reultados
            // 
            this.Btn_Reultados.BackColor = System.Drawing.Color.Black;
            this.Btn_Reultados.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reultados.ForeColor = System.Drawing.Color.White;
            this.Btn_Reultados.Location = new System.Drawing.Point(291, 308);
            this.Btn_Reultados.Name = "Btn_Reultados";
            this.Btn_Reultados.Size = new System.Drawing.Size(221, 57);
            this.Btn_Reultados.TabIndex = 63;
            this.Btn_Reultados.Text = "Imprimir Resultados";
            this.Btn_Reultados.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Black;
            this.Btn_Salir.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Salir.ForeColor = System.Drawing.Color.White;
            this.Btn_Salir.Location = new System.Drawing.Point(291, 371);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(221, 57);
            this.Btn_Salir.TabIndex = 64;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 65;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reultados);
            this.Controls.Add(this.Btn_Cuentas);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button Btn_Cuentas;
        private System.Windows.Forms.Button Btn_Reultados;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}