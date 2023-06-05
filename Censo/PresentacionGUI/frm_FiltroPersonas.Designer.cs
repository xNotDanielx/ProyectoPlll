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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numero_DocumentoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FiltroPersonas));
            this.Txt_FiltroId = new System.Windows.Forms.TextBox();
            this.Txt_FiltroNombre = new System.Windows.Forms.TextBox();
            this.GetBySectores = new System.Windows.Forms.Button();
            this.dbCensoDataSet1 = new PresentacionGUI.DbCensoDataSet1();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new PresentacionGUI.DbCensoDataSet1TableAdapters.PersonaTableAdapter();
            this.tableAdapterManager = new PresentacionGUI.DbCensoDataSet1TableAdapters.TableAdapterManager();
            this.personaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numero_DocumentoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbCensoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
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
            // dbCensoDataSet1
            // 
            this.dbCensoDataSet1.DataSetName = "DbCensoDataSet1";
            this.dbCensoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.dbCensoDataSet1;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoguinTableAdapter = null;
            this.tableAdapterManager.PersonaTableAdapter = this.personaTableAdapter;
            this.tableAdapterManager.Sector_EconomicoTableAdapter = null;
            this.tableAdapterManager.Sector_HogarTableAdapter = null;
            this.tableAdapterManager.SectorSocialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PresentacionGUI.DbCensoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personaDataGridView
            // 
            this.personaDataGridView.AllowUserToAddRows = false;
            this.personaDataGridView.AllowUserToDeleteRows = false;
            this.personaDataGridView.AutoGenerateColumns = false;
            this.personaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.personaDataGridView.DataSource = this.personaBindingSource;
            this.personaDataGridView.Location = new System.Drawing.Point(9, 23);
            this.personaDataGridView.Name = "personaDataGridView";
            this.personaDataGridView.Size = new System.Drawing.Size(1244, 523);
            this.personaDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Documento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn7.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Barrio";
            this.dataGridViewTextBoxColumn10.HeaderText = "Barrio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Tipo_Vivienda";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tipo_Vivienda";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Sectores_Completados";
            this.dataGridViewTextBoxColumn12.HeaderText = "Sectores_Completados";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
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
            ((System.ComponentModel.ISupportInitialize)(this.dbCensoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_FiltroId;
        private System.Windows.Forms.TextBox Txt_FiltroNombre;
        private System.Windows.Forms.Button GetBySectores;
        private DbCensoDataSet1 dbCensoDataSet1;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private DbCensoDataSet1TableAdapters.PersonaTableAdapter personaTableAdapter;
        private DbCensoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}