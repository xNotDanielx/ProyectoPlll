namespace PresentacionGUI
{
    partial class Frm_ListaCuentas
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
            System.Windows.Forms.Label adminLabel;
            System.Windows.Forms.Label numero_DocumentoLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label tipo_DocumentoLabel;
            System.Windows.Forms.Label cuentas_RegistradasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaCuentas));
            this.dbCensoDataSet = new PresentacionGUI.DbCensoDataSet1();
            this.loguinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loguinTableAdapter = new PresentacionGUI.DbCensoDataSet1TableAdapters.LoguinTableAdapter();
            this.tableAdapterManager = new PresentacionGUI.DbCensoDataSet1TableAdapters.TableAdapterManager();
            this.loguinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Documento = new System.Windows.Forms.TextBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Txt_TipoDocumento = new System.Windows.Forms.TextBox();
            this.Txt_CuentasRegistradas = new System.Windows.Forms.TextBox();
            this.Btn_ActualizarInfo = new System.Windows.Forms.Button();
            this.CbAdmin = new System.Windows.Forms.CheckBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            adminLabel = new System.Windows.Forms.Label();
            numero_DocumentoLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            tipo_DocumentoLabel = new System.Windows.Forms.Label();
            cuentas_RegistradasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbCensoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.BackColor = System.Drawing.Color.Transparent;
            adminLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adminLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            adminLabel.Location = new System.Drawing.Point(726, 99);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new System.Drawing.Size(63, 20);
            adminLabel.TabIndex = 1;
            adminLabel.Text = "Admin:";
            // 
            // numero_DocumentoLabel
            // 
            numero_DocumentoLabel.AutoSize = true;
            numero_DocumentoLabel.BackColor = System.Drawing.Color.Transparent;
            numero_DocumentoLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_DocumentoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            numero_DocumentoLabel.Location = new System.Drawing.Point(621, 127);
            numero_DocumentoLabel.Name = "numero_DocumentoLabel";
            numero_DocumentoLabel.Size = new System.Drawing.Size(168, 20);
            numero_DocumentoLabel.TabIndex = 3;
            numero_DocumentoLabel.Text = "Numero Documento:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.BackColor = System.Drawing.Color.Transparent;
            contraseñaLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseñaLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            contraseñaLabel.Location = new System.Drawing.Point(690, 155);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(99, 20);
            contraseñaLabel.TabIndex = 5;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // tipo_DocumentoLabel
            // 
            tipo_DocumentoLabel.AutoSize = true;
            tipo_DocumentoLabel.BackColor = System.Drawing.Color.Transparent;
            tipo_DocumentoLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_DocumentoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            tipo_DocumentoLabel.Location = new System.Drawing.Point(647, 181);
            tipo_DocumentoLabel.Name = "tipo_DocumentoLabel";
            tipo_DocumentoLabel.Size = new System.Drawing.Size(142, 20);
            tipo_DocumentoLabel.TabIndex = 7;
            tipo_DocumentoLabel.Text = "Tipo Documento:";
            // 
            // cuentas_RegistradasLabel
            // 
            cuentas_RegistradasLabel.AutoSize = true;
            cuentas_RegistradasLabel.BackColor = System.Drawing.Color.Transparent;
            cuentas_RegistradasLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuentas_RegistradasLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            cuentas_RegistradasLabel.Location = new System.Drawing.Point(619, 207);
            cuentas_RegistradasLabel.Name = "cuentas_RegistradasLabel";
            cuentas_RegistradasLabel.Size = new System.Drawing.Size(170, 20);
            cuentas_RegistradasLabel.TabIndex = 9;
            cuentas_RegistradasLabel.Text = "Cuentas Registradas:";
            // 
            // dbCensoDataSet
            // 
            this.dbCensoDataSet.DataSetName = "DbCensoDataSet";
            this.dbCensoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loguinBindingSource
            // 
            this.loguinBindingSource.DataMember = "Loguin";
            this.loguinBindingSource.DataSource = this.dbCensoDataSet;
            // 
            // loguinTableAdapter
            // 
            this.loguinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoguinTableAdapter = this.loguinTableAdapter;
            this.tableAdapterManager.PersonaTableAdapter = null;
            this.tableAdapterManager.Sector_EconomicoTableAdapter = null;
            this.tableAdapterManager.Sector_HogarTableAdapter = null;
            this.tableAdapterManager.SectorSocialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PresentacionGUI.DbCensoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loguinDataGridView
            // 
            this.loguinDataGridView.AutoGenerateColumns = false;
            this.loguinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loguinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.loguinDataGridView.DataSource = this.loguinBindingSource;
            this.loguinDataGridView.Location = new System.Drawing.Point(2, 2);
            this.loguinDataGridView.Name = "loguinDataGridView";
            this.loguinDataGridView.Size = new System.Drawing.Size(546, 533);
            this.loguinDataGridView.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Admin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Admin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numero_Documento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero_Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn2.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo_Documento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo_Documento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cuentas_Registradas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cuentas_Registradas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Txt_Documento
            // 
            this.Txt_Documento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loguinBindingSource, "Numero_Documento", true));
            this.Txt_Documento.Location = new System.Drawing.Point(795, 129);
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Size = new System.Drawing.Size(104, 20);
            this.Txt_Documento.TabIndex = 4;
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loguinBindingSource, "Contraseña", true));
            this.Txt_Contraseña.Location = new System.Drawing.Point(795, 155);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(104, 20);
            this.Txt_Contraseña.TabIndex = 6;
            // 
            // Txt_TipoDocumento
            // 
            this.Txt_TipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loguinBindingSource, "Tipo_Documento", true));
            this.Txt_TipoDocumento.Location = new System.Drawing.Point(795, 181);
            this.Txt_TipoDocumento.Name = "Txt_TipoDocumento";
            this.Txt_TipoDocumento.Size = new System.Drawing.Size(104, 20);
            this.Txt_TipoDocumento.TabIndex = 8;
            // 
            // Txt_CuentasRegistradas
            // 
            this.Txt_CuentasRegistradas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loguinBindingSource, "Cuentas_Registradas", true));
            this.Txt_CuentasRegistradas.Location = new System.Drawing.Point(795, 207);
            this.Txt_CuentasRegistradas.Name = "Txt_CuentasRegistradas";
            this.Txt_CuentasRegistradas.Size = new System.Drawing.Size(104, 20);
            this.Txt_CuentasRegistradas.TabIndex = 10;
            this.Txt_CuentasRegistradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CuentasRegistradas_KeyPress);
            // 
            // Btn_ActualizarInfo
            // 
            this.Btn_ActualizarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_ActualizarInfo.ForeColor = System.Drawing.Color.Black;
            this.Btn_ActualizarInfo.Location = new System.Drawing.Point(683, 242);
            this.Btn_ActualizarInfo.Name = "Btn_ActualizarInfo";
            this.Btn_ActualizarInfo.Size = new System.Drawing.Size(187, 50);
            this.Btn_ActualizarInfo.TabIndex = 11;
            this.Btn_ActualizarInfo.Text = "Actualizar Info";
            this.Btn_ActualizarInfo.UseVisualStyleBackColor = true;
            this.Btn_ActualizarInfo.Click += new System.EventHandler(this.Btn_ActualizarInfo_Click);
            // 
            // CbAdmin
            // 
            this.CbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.CbAdmin.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.loguinBindingSource, "Admin", true));
            this.CbAdmin.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CbAdmin.Location = new System.Drawing.Point(795, 99);
            this.CbAdmin.Name = "CbAdmin";
            this.CbAdmin.Size = new System.Drawing.Size(104, 24);
            this.CbAdmin.TabIndex = 2;
            this.CbAdmin.UseVisualStyleBackColor = false;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(870, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(49, 44);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 12;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Frm_ListaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 556);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_ActualizarInfo);
            this.Controls.Add(adminLabel);
            this.Controls.Add(this.CbAdmin);
            this.Controls.Add(numero_DocumentoLabel);
            this.Controls.Add(this.Txt_Documento);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(tipo_DocumentoLabel);
            this.Controls.Add(this.Txt_TipoDocumento);
            this.Controls.Add(cuentas_RegistradasLabel);
            this.Controls.Add(this.Txt_CuentasRegistradas);
            this.Controls.Add(this.loguinDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListaCuentas";
            this.Text = "Frm_ListaCuentas";
            this.Load += new System.EventHandler(this.Frm_ListaCuentas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_ListaCuentas_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dbCensoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbCensoDataSet1 dbCensoDataSet;
        private System.Windows.Forms.BindingSource loguinBindingSource;
        private DbCensoDataSet1TableAdapters.LoguinTableAdapter loguinTableAdapter;
        private DbCensoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView loguinDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox Txt_Documento;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.TextBox Txt_TipoDocumento;
        private System.Windows.Forms.TextBox Txt_CuentasRegistradas;
        private System.Windows.Forms.Button Btn_ActualizarInfo;
        private System.Windows.Forms.CheckBox CbAdmin;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
    }
}