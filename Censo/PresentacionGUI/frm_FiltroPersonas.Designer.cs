namespace PresentacionGUI
{
    partial class frm_FiltroPersonas
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
            System.Windows.Forms.Label numero_DocumentoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FiltroPersonas));
            this.Txt_FiltroId = new System.Windows.Forms.TextBox();
            this.Txt_FiltroNombre = new System.Windows.Forms.TextBox();
            this.GetBySectores = new System.Windows.Forms.Button();
            this.personaDataGridView = new System.Windows.Forms.DataGridView();
            numero_DocumentoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_DocumentoLabel
            // 
            numero_DocumentoLabel.AutoSize = true;
            numero_DocumentoLabel.BackColor = System.Drawing.Color.Transparent;
            numero_DocumentoLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_DocumentoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            numero_DocumentoLabel.Location = new System.Drawing.Point(126, 560);
            numero_DocumentoLabel.Name = "numero_DocumentoLabel";
            numero_DocumentoLabel.Size = new System.Drawing.Size(183, 20);
            numero_DocumentoLabel.TabIndex = 13;
            numero_DocumentoLabel.Text = "Buscar por Documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            label1.Location = new System.Drawing.Point(577, 560);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 20);
            label1.TabIndex = 14;
            label1.Text = "Buscar por Nombre";
            // 
            // Txt_FiltroId
            // 
            this.Txt_FiltroId.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroId.Location = new System.Drawing.Point(115, 583);
            this.Txt_FiltroId.Name = "Txt_FiltroId";
            this.Txt_FiltroId.Size = new System.Drawing.Size(208, 51);
            this.Txt_FiltroId.TabIndex = 1;
            this.Txt_FiltroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Filtro_KeyPress);
            this.Txt_FiltroId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Filtro_KeyUp);
            // 
            // Txt_FiltroNombre
            // 
            this.Txt_FiltroNombre.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroNombre.Location = new System.Drawing.Point(551, 583);
            this.Txt_FiltroNombre.Name = "Txt_FiltroNombre";
            this.Txt_FiltroNombre.Size = new System.Drawing.Size(208, 51);
            this.Txt_FiltroNombre.TabIndex = 2;
            this.Txt_FiltroNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FiltroNombre_KeyPress);
            this.Txt_FiltroNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_FiltroNombre_KeyUp);
            // 
            // GetBySectores
            // 
            this.GetBySectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.GetBySectores.ForeColor = System.Drawing.Color.Black;
            this.GetBySectores.Location = new System.Drawing.Point(963, 582);
            this.GetBySectores.Name = "GetBySectores";
            this.GetBySectores.Size = new System.Drawing.Size(208, 51);
            this.GetBySectores.TabIndex = 12;
            this.GetBySectores.Text = "Personas que completaron la encuesta";
            this.GetBySectores.UseVisualStyleBackColor = true;
            this.GetBySectores.Click += new System.EventHandler(this.GetBySectores_Click);
            // 
            // personaDataGridView
            // 
            this.personaDataGridView.AllowUserToAddRows = false;
            this.personaDataGridView.AllowUserToDeleteRows = false;
            this.personaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personaDataGridView.Location = new System.Drawing.Point(12, 23);
            this.personaDataGridView.Name = "personaDataGridView";
            this.personaDataGridView.Size = new System.Drawing.Size(1241, 516);
            this.personaDataGridView.TabIndex = 15;
            // 
            // frm_FiltroPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1265, 727);
            this.Controls.Add(this.personaDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(numero_DocumentoLabel);
            this.Controls.Add(this.GetBySectores);
            this.Controls.Add(this.Txt_FiltroNombre);
            this.Controls.Add(this.Txt_FiltroId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_FiltroPersonas";
            this.Text = "frm_FiltroPersonas";
            this.Load += new System.EventHandler(this.frm_FiltroPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_FiltroId;
        private System.Windows.Forms.TextBox Txt_FiltroNombre;
        private System.Windows.Forms.Button GetBySectores;
        private System.Windows.Forms.DataGridView personaDataGridView;
    }
}