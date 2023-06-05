namespace PresentacionGUI
{
    partial class Frm_Ayuda
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.LkLabel_LinkBlog = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LkLabel_LinkBlog
            // 
            this.LkLabel_LinkBlog.AutoSize = true;
            this.LkLabel_LinkBlog.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLabel_LinkBlog.Location = new System.Drawing.Point(287, 235);
            this.LkLabel_LinkBlog.Name = "LkLabel_LinkBlog";
            this.LkLabel_LinkBlog.Size = new System.Drawing.Size(51, 63);
            this.LkLabel_LinkBlog.TabIndex = 0;
            this.LkLabel_LinkBlog.TabStop = true;
            this.LkLabel_LinkBlog.Text = " ";
            this.LkLabel_LinkBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLabel_LinkBlog_LinkClicked);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            label1.Location = new System.Drawing.Point(36, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(797, 49);
            label1.TabIndex = 4;
            label1.Text = "Puede encontrar toda la ayuda sobre esta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            label2.Location = new System.Drawing.Point(303, 136);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(293, 49);
            label2.TabIndex = 5;
            label2.Text = "aplicación aqui:";
            // 
            // Frm_Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(903, 517);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.LkLabel_LinkBlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ayuda";
            this.Text = "Frm_Ayuda";
            this.Load += new System.EventHandler(this.Frm_Ayuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LkLabel_LinkBlog;
    }
}