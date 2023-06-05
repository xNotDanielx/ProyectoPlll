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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaCuentas));
            System.Windows.Forms.Label label1;
            this.dbCensoDataSet = new PresentacionGUI.DbCensoDataSet1();
            this.loguinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loguinTableAdapter = new PresentacionGUI.DbCensoDataSet1TableAdapters.LoguinTableAdapter();
            this.tableAdapterManager = new PresentacionGUI.DbCensoDataSet1TableAdapters.TableAdapterManager();
            this.Txt_Documento = new System.Windows.Forms.TextBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Txt_TipoDocumento = new System.Windows.Forms.TextBox();
            this.Btn_ActualizarInfo = new System.Windows.Forms.Button();
            this.CbAdmin = new System.Windows.Forms.CheckBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Btn_EliminarInfo = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loguinDataGridView = new System.Windows.Forms.DataGridView();
            this.Txt_FiltroId = new System.Windows.Forms.TextBox();
            adminLabel = new System.Windows.Forms.Label();
            numero_DocumentoLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            tipo_DocumentoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbCensoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.BackColor = System.Drawing.Color.Transparent;
            adminLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adminLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            adminLabel.Location = new System.Drawing.Point(619, 192);
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
            numero_DocumentoLabel.Location = new System.Drawing.Point(514, 220);
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
            contraseñaLabel.Location = new System.Drawing.Point(583, 248);
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
            tipo_DocumentoLabel.Location = new System.Drawing.Point(540, 274);
            tipo_DocumentoLabel.Name = "tipo_DocumentoLabel";
            tipo_DocumentoLabel.Size = new System.Drawing.Size(142, 20);
            tipo_DocumentoLabel.TabIndex = 7;
            tipo_DocumentoLabel.Text = "Tipo Documento:";
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
            // Txt_Documento
            // 
            this.Txt_Documento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loguinBindingSource, "Numero_Documento", true));
            this.Txt_Documento.Location = new System.Drawing.Point(688, 222);
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Size = new System.Drawing.Size(104, 20);
            this.Txt_Documento.TabIndex = 4;
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loguinBindingSource, "Contraseña", true));
            this.Txt_Contraseña.Location = new System.Drawing.Point(688, 248);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(104, 20);
            this.Txt_Contraseña.TabIndex = 6;
            // 
            // Txt_TipoDocumento
            // 
            this.Txt_TipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loguinBindingSource, "Tipo_Documento", true));
            this.Txt_TipoDocumento.Location = new System.Drawing.Point(688, 274);
            this.Txt_TipoDocumento.Name = "Txt_TipoDocumento";
            this.Txt_TipoDocumento.Size = new System.Drawing.Size(104, 20);
            this.Txt_TipoDocumento.TabIndex = 8;
            // 
            // Btn_ActualizarInfo
            // 
            this.Btn_ActualizarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_ActualizarInfo.ForeColor = System.Drawing.Color.Black;
            this.Btn_ActualizarInfo.Location = new System.Drawing.Point(512, 311);
            this.Btn_ActualizarInfo.Name = "Btn_ActualizarInfo";
            this.Btn_ActualizarInfo.Size = new System.Drawing.Size(170, 38);
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
            this.CbAdmin.Location = new System.Drawing.Point(688, 192);
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(850, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(49, 44);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 12;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_EliminarInfo
            // 
            this.Btn_EliminarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_EliminarInfo.ForeColor = System.Drawing.Color.Black;
            this.Btn_EliminarInfo.Location = new System.Drawing.Point(689, 311);
            this.Btn_EliminarInfo.Name = "Btn_EliminarInfo";
            this.Btn_EliminarInfo.Size = new System.Drawing.Size(170, 38);
            this.Btn_EliminarInfo.TabIndex = 13;
            this.Btn_EliminarInfo.Text = "Eliminar Info";
            this.Btn_EliminarInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cuentas_Registradas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cuentas_Registradas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo_Documento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo_Documento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn2.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numero_Documento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero_Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Admin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Admin";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // loguinDataGridView
            // 
            this.loguinDataGridView.AllowUserToAddRows = false;
            this.loguinDataGridView.AutoGenerateColumns = false;
            this.loguinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loguinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.loguinDataGridView.DataSource = this.loguinBindingSource;
            this.loguinDataGridView.Location = new System.Drawing.Point(1, 2);
            this.loguinDataGridView.Name = "loguinDataGridView";
            this.loguinDataGridView.Size = new System.Drawing.Size(442, 494);
            this.loguinDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            label1.Location = new System.Drawing.Point(583, 85);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 20);
            label1.TabIndex = 15;
            label1.Text = "Buscar por Documento";
            // 
            // Txt_FiltroId
            // 
            this.Txt_FiltroId.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroId.Location = new System.Drawing.Point(572, 108);
            this.Txt_FiltroId.Name = "Txt_FiltroId";
            this.Txt_FiltroId.Size = new System.Drawing.Size(208, 51);
            this.Txt_FiltroId.TabIndex = 14;
            this.Txt_FiltroId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_FiltroId_KeyUp);
            // 
            // Frm_ListaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 556);
            this.Controls.Add(label1);
            this.Controls.Add(this.Txt_FiltroId);
            this.Controls.Add(this.Btn_EliminarInfo);
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
            this.Controls.Add(this.loguinDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListaCuentas";
            this.Text = "Frm_ListaCuentas";
            this.Load += new System.EventHandler(this.Frm_ListaCuentas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_ListaCuentas_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dbCensoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loguinDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbCensoDataSet1 dbCensoDataSet;
        private System.Windows.Forms.BindingSource loguinBindingSource;
        private DbCensoDataSet1TableAdapters.LoguinTableAdapter loguinTableAdapter;
        private DbCensoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Txt_Documento;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.TextBox Txt_TipoDocumento;
        private System.Windows.Forms.Button Btn_ActualizarInfo;
        private System.Windows.Forms.CheckBox CbAdmin;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.Button Btn_EliminarInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView loguinDataGridView;
        private System.Windows.Forms.TextBox Txt_FiltroId;
    }
}