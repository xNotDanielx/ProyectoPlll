namespace PresentacionGUI
{
    partial class Frm_Graficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Graficas));
            this.chart_SH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_SE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_SS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chart_PE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_SH
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_SH.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_SH.Legends.Add(legend1);
            this.chart_SH.Location = new System.Drawing.Point(812, 53);
            this.chart_SH.Name = "chart_SH";
            this.chart_SH.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "SeriesSH";
            this.chart_SH.Series.Add(series1);
            this.chart_SH.Size = new System.Drawing.Size(419, 360);
            this.chart_SH.TabIndex = 0;
            this.chart_SH.Text = "chart1";
            // 
            // chart_SE
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_SE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_SE.Legends.Add(legend2);
            this.chart_SE.Location = new System.Drawing.Point(0, 53);
            this.chart_SE.Name = "chart_SE";
            this.chart_SE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "SeriesSE";
            this.chart_SE.Series.Add(series2);
            this.chart_SE.Size = new System.Drawing.Size(407, 727);
            this.chart_SE.TabIndex = 1;
            this.chart_SE.Text = "chart1";
            // 
            // chart_SS
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_SS.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_SS.Legends.Add(legend3);
            this.chart_SS.Location = new System.Drawing.Point(413, 53);
            this.chart_SS.Name = "chart_SS";
            this.chart_SS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "SeriesSS";
            this.chart_SS.Series.Add(series3);
            this.chart_SS.Size = new System.Drawing.Size(406, 739);
            this.chart_SS.TabIndex = 2;
            this.chart_SS.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(406, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 783);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(812, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 783);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "SECTOR ECONOMICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(946, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "SECTOR HOGAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "SECTOR SOCIAL";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(812, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 21);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(946, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "PERSONAS";
            // 
            // chart_PE
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_PE.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_PE.Legends.Add(legend4);
            this.chart_PE.Location = new System.Drawing.Point(815, 463);
            this.chart_PE.Name = "chart_PE";
            this.chart_PE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "SeriesPE";
            this.chart_PE.Series.Add(series4);
            this.chart_PE.Size = new System.Drawing.Size(416, 318);
            this.chart_PE.TabIndex = 9;
            this.chart_PE.Text = "chart3";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Black;
            this.Btn_Cerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(1182, -1);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(49, 44);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 13;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Frm_Graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 780);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart_PE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart_SE);
            this.Controls.Add(this.chart_SH);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chart_SS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Graficas";
            this.Text = "Frm_Graficas";
            this.Load += new System.EventHandler(this.Frm_Graficas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_SH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PE;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
    }
}