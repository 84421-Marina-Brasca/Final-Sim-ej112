namespace TP4
{
    partial class PantallaVisualizacion
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
            gdw_iteracionesSolicitadas = new DataGridView();
            lbl_tiempoMaxEspera = new Label();
            lbl_colasMax = new Label();
            txt_PorcUrgenciasAtend = new TextBox();
            txt_colaMaxConsulta = new TextBox();
            txt_colaMaxUrgencia = new TextBox();
            txt_colaMaxTotal = new TextBox();
            lbl_colaMaxTotal = new Label();
            lbl_colaMaxConsulta = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_maxEsperaUrgencia = new TextBox();
            txt_maxEsperaConsulta = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdw_iteracionesSolicitadas).BeginInit();
            SuspendLayout();
            // 
            // gdw_iteracionesSolicitadas
            // 
            gdw_iteracionesSolicitadas.AllowUserToAddRows = false;
            gdw_iteracionesSolicitadas.AllowUserToDeleteRows = false;
            gdw_iteracionesSolicitadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdw_iteracionesSolicitadas.Location = new Point(24, 22);
            gdw_iteracionesSolicitadas.Name = "gdw_iteracionesSolicitadas";
            gdw_iteracionesSolicitadas.ReadOnly = true;
            gdw_iteracionesSolicitadas.RowHeadersWidth = 51;
            gdw_iteracionesSolicitadas.RowTemplate.Height = 25;
            gdw_iteracionesSolicitadas.Size = new Size(1137, 415);
            gdw_iteracionesSolicitadas.TabIndex = 0;
            // 
            // lbl_tiempoMaxEspera
            // 
            lbl_tiempoMaxEspera.AutoSize = true;
            lbl_tiempoMaxEspera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tiempoMaxEspera.Location = new Point(24, 455);
            lbl_tiempoMaxEspera.Name = "lbl_tiempoMaxEspera";
            lbl_tiempoMaxEspera.Size = new Size(268, 17);
            lbl_tiempoMaxEspera.TabIndex = 1;
            lbl_tiempoMaxEspera.Text = "Tiempos màximos de espera (en minutos)";
            // 
            // lbl_colasMax
            // 
            lbl_colasMax.AutoSize = true;
            lbl_colasMax.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_colasMax.Location = new Point(880, 454);
            lbl_colasMax.Name = "lbl_colasMax";
            lbl_colasMax.Size = new Size(100, 17);
            lbl_colasMax.TabIndex = 2;
            lbl_colasMax.Text = "Colas Màximas";
            // 
            // txt_PorcUrgenciasAtend
            // 
            txt_PorcUrgenciasAtend.Enabled = false;
            txt_PorcUrgenciasAtend.Location = new Point(445, 485);
            txt_PorcUrgenciasAtend.Name = "txt_PorcUrgenciasAtend";
            txt_PorcUrgenciasAtend.Size = new Size(297, 23);
            txt_PorcUrgenciasAtend.TabIndex = 3;
            // 
            // txt_colaMaxConsulta
            // 
            txt_colaMaxConsulta.Enabled = false;
            txt_colaMaxConsulta.Location = new Point(940, 485);
            txt_colaMaxConsulta.Name = "txt_colaMaxConsulta";
            txt_colaMaxConsulta.Size = new Size(68, 23);
            txt_colaMaxConsulta.TabIndex = 4;
            // 
            // txt_colaMaxUrgencia
            // 
            txt_colaMaxUrgencia.Enabled = false;
            txt_colaMaxUrgencia.Location = new Point(1092, 485);
            txt_colaMaxUrgencia.Name = "txt_colaMaxUrgencia";
            txt_colaMaxUrgencia.Size = new Size(69, 23);
            txt_colaMaxUrgencia.TabIndex = 5;
            // 
            // txt_colaMaxTotal
            // 
            txt_colaMaxTotal.Enabled = false;
            txt_colaMaxTotal.Location = new Point(1092, 456);
            txt_colaMaxTotal.Name = "txt_colaMaxTotal";
            txt_colaMaxTotal.Size = new Size(69, 23);
            txt_colaMaxTotal.TabIndex = 6;
            // 
            // lbl_colaMaxTotal
            // 
            lbl_colaMaxTotal.AutoSize = true;
            lbl_colaMaxTotal.Location = new Point(1045, 459);
            lbl_colaMaxTotal.Name = "lbl_colaMaxTotal";
            lbl_colaMaxTotal.Size = new Size(38, 15);
            lbl_colaMaxTotal.TabIndex = 8;
            lbl_colaMaxTotal.Text = "Total :";
            // 
            // lbl_colaMaxConsulta
            // 
            lbl_colaMaxConsulta.AutoSize = true;
            lbl_colaMaxConsulta.Location = new Point(880, 489);
            lbl_colaMaxConsulta.Name = "lbl_colaMaxConsulta";
            lbl_colaMaxConsulta.Size = new Size(60, 15);
            lbl_colaMaxConsulta.TabIndex = 9;
            lbl_colaMaxConsulta.Text = "Consulta :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1027, 489);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 10;
            label1.Text = "Urgencia :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 489);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 14;
            label2.Text = "Urgencia :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 489);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 13;
            label3.Text = "Consulta :";
            // 
            // txt_maxEsperaUrgencia
            // 
            txt_maxEsperaUrgencia.Enabled = false;
            txt_maxEsperaUrgencia.Location = new Point(221, 484);
            txt_maxEsperaUrgencia.Name = "txt_maxEsperaUrgencia";
            txt_maxEsperaUrgencia.Size = new Size(56, 23);
            txt_maxEsperaUrgencia.TabIndex = 12;
            // 
            // txt_maxEsperaConsulta
            // 
            txt_maxEsperaConsulta.Enabled = false;
            txt_maxEsperaConsulta.Location = new Point(86, 485);
            txt_maxEsperaConsulta.Name = "txt_maxEsperaConsulta";
            txt_maxEsperaConsulta.Size = new Size(55, 23);
            txt_maxEsperaConsulta.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(445, 459);
            label4.Name = "label4";
            label4.Size = new Size(297, 17);
            label4.TabIndex = 15;
            label4.Text = "Porcentaje urgencias atendidas / tot atendidos";
            // 
            // PantallaVisualizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1184, 526);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txt_maxEsperaUrgencia);
            Controls.Add(txt_maxEsperaConsulta);
            Controls.Add(label1);
            Controls.Add(lbl_colaMaxConsulta);
            Controls.Add(lbl_colaMaxTotal);
            Controls.Add(txt_colaMaxTotal);
            Controls.Add(txt_colaMaxUrgencia);
            Controls.Add(txt_colaMaxConsulta);
            Controls.Add(txt_PorcUrgenciasAtend);
            Controls.Add(lbl_colasMax);
            Controls.Add(lbl_tiempoMaxEspera);
            Controls.Add(gdw_iteracionesSolicitadas);
            Name = "PantallaVisualizacion";
            Text = "Final Simulación - Ej. 112 - Brasca Marina";
            Load += PantallaVisualizacion_Load;
            ((System.ComponentModel.ISupportInitialize)gdw_iteracionesSolicitadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdw_iteracionesSolicitadas;
        private Label lbl_tiempoMaxEspera;
        private Label lbl_colasMax;
        private TextBox txt_PorcUrgenciasAtend;
        private TextBox txt_colaMaxConsulta;
        private TextBox txt_colaMaxUrgencia;
        private TextBox txt_colaMaxTotal;
        private Label lbl_colaMaxTotal;
        private Label lbl_colaMaxConsulta;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_maxEsperaUrgencia;
        private TextBox txt_maxEsperaConsulta;
        private Label label4;
    }
}