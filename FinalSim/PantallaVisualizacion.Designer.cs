namespace FinalSim
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
            this.gdw_iteracionesSolicitadas = new System.Windows.Forms.DataGridView();
            this.lbl_tiempoMaxEspera = new System.Windows.Forms.Label();
            this.lbl_colasMax = new System.Windows.Forms.Label();
            this.txt_PorcUrgenciasAtend = new System.Windows.Forms.TextBox();
            this.txt_colaMaxConsulta = new System.Windows.Forms.TextBox();
            this.txt_colaMaxUrgencia = new System.Windows.Forms.TextBox();
            this.txt_colaMaxTotal = new System.Windows.Forms.TextBox();
            this.lbl_colaMaxTotal = new System.Windows.Forms.Label();
            this.lbl_colaMaxConsulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maxEsperaUrgencia = new System.Windows.Forms.TextBox();
            this.txt_maxEsperaConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdw_iteracionesSolicitadas)).BeginInit();
            this.SuspendLayout();
            // 
            // gdw_iteracionesSolicitadas
            // 
            this.gdw_iteracionesSolicitadas.AllowUserToAddRows = false;
            this.gdw_iteracionesSolicitadas.AllowUserToDeleteRows = false;
            this.gdw_iteracionesSolicitadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdw_iteracionesSolicitadas.Location = new System.Drawing.Point(24, 22);
            this.gdw_iteracionesSolicitadas.Name = "gdw_iteracionesSolicitadas";
            this.gdw_iteracionesSolicitadas.ReadOnly = true;
            this.gdw_iteracionesSolicitadas.RowHeadersWidth = 51;
            this.gdw_iteracionesSolicitadas.RowTemplate.Height = 25;
            this.gdw_iteracionesSolicitadas.Size = new System.Drawing.Size(1137, 415);
            this.gdw_iteracionesSolicitadas.TabIndex = 0;
            // 
            // lbl_tiempoMaxEspera
            // 
            this.lbl_tiempoMaxEspera.AutoSize = true;
            this.lbl_tiempoMaxEspera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tiempoMaxEspera.Location = new System.Drawing.Point(24, 455);
            this.lbl_tiempoMaxEspera.Name = "lbl_tiempoMaxEspera";
            this.lbl_tiempoMaxEspera.Size = new System.Drawing.Size(268, 17);
            this.lbl_tiempoMaxEspera.TabIndex = 1;
            this.lbl_tiempoMaxEspera.Text = "Tiempos màximos de espera (en minutos)";
            // 
            // lbl_colasMax
            // 
            this.lbl_colasMax.AutoSize = true;
            this.lbl_colasMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_colasMax.Location = new System.Drawing.Point(880, 454);
            this.lbl_colasMax.Name = "lbl_colasMax";
            this.lbl_colasMax.Size = new System.Drawing.Size(100, 17);
            this.lbl_colasMax.TabIndex = 2;
            this.lbl_colasMax.Text = "Colas Màximas";
            // 
            // txt_PorcUrgenciasAtend
            // 
            this.txt_PorcUrgenciasAtend.Enabled = false;
            this.txt_PorcUrgenciasAtend.Location = new System.Drawing.Point(445, 485);
            this.txt_PorcUrgenciasAtend.Name = "txt_PorcUrgenciasAtend";
            this.txt_PorcUrgenciasAtend.Size = new System.Drawing.Size(297, 23);
            this.txt_PorcUrgenciasAtend.TabIndex = 3;
            // 
            // txt_colaMaxConsulta
            // 
            this.txt_colaMaxConsulta.Enabled = false;
            this.txt_colaMaxConsulta.Location = new System.Drawing.Point(940, 485);
            this.txt_colaMaxConsulta.Name = "txt_colaMaxConsulta";
            this.txt_colaMaxConsulta.Size = new System.Drawing.Size(68, 23);
            this.txt_colaMaxConsulta.TabIndex = 4;
            // 
            // txt_colaMaxUrgencia
            // 
            this.txt_colaMaxUrgencia.Enabled = false;
            this.txt_colaMaxUrgencia.Location = new System.Drawing.Point(1092, 485);
            this.txt_colaMaxUrgencia.Name = "txt_colaMaxUrgencia";
            this.txt_colaMaxUrgencia.Size = new System.Drawing.Size(69, 23);
            this.txt_colaMaxUrgencia.TabIndex = 5;
            // 
            // txt_colaMaxTotal
            // 
            this.txt_colaMaxTotal.Enabled = false;
            this.txt_colaMaxTotal.Location = new System.Drawing.Point(1092, 456);
            this.txt_colaMaxTotal.Name = "txt_colaMaxTotal";
            this.txt_colaMaxTotal.Size = new System.Drawing.Size(69, 23);
            this.txt_colaMaxTotal.TabIndex = 6;
            // 
            // lbl_colaMaxTotal
            // 
            this.lbl_colaMaxTotal.AutoSize = true;
            this.lbl_colaMaxTotal.Location = new System.Drawing.Point(1045, 459);
            this.lbl_colaMaxTotal.Name = "lbl_colaMaxTotal";
            this.lbl_colaMaxTotal.Size = new System.Drawing.Size(38, 15);
            this.lbl_colaMaxTotal.TabIndex = 8;
            this.lbl_colaMaxTotal.Text = "Total :";
            // 
            // lbl_colaMaxConsulta
            // 
            this.lbl_colaMaxConsulta.AutoSize = true;
            this.lbl_colaMaxConsulta.Location = new System.Drawing.Point(880, 489);
            this.lbl_colaMaxConsulta.Name = "lbl_colaMaxConsulta";
            this.lbl_colaMaxConsulta.Size = new System.Drawing.Size(60, 15);
            this.lbl_colaMaxConsulta.TabIndex = 9;
            this.lbl_colaMaxConsulta.Text = "Consulta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1027, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Urgencia :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Urgencia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Consulta :";
            // 
            // txt_maxEsperaUrgencia
            // 
            this.txt_maxEsperaUrgencia.Enabled = false;
            this.txt_maxEsperaUrgencia.Location = new System.Drawing.Point(221, 484);
            this.txt_maxEsperaUrgencia.Name = "txt_maxEsperaUrgencia";
            this.txt_maxEsperaUrgencia.Size = new System.Drawing.Size(56, 23);
            this.txt_maxEsperaUrgencia.TabIndex = 12;
            // 
            // txt_maxEsperaConsulta
            // 
            this.txt_maxEsperaConsulta.Enabled = false;
            this.txt_maxEsperaConsulta.Location = new System.Drawing.Point(86, 485);
            this.txt_maxEsperaConsulta.Name = "txt_maxEsperaConsulta";
            this.txt_maxEsperaConsulta.Size = new System.Drawing.Size(55, 23);
            this.txt_maxEsperaConsulta.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(445, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Porcentaje urgencias atendidas / tot atendidos";
            // 
            // PantallaVisualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1184, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maxEsperaUrgencia);
            this.Controls.Add(this.txt_maxEsperaConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_colaMaxConsulta);
            this.Controls.Add(this.lbl_colaMaxTotal);
            this.Controls.Add(this.txt_colaMaxTotal);
            this.Controls.Add(this.txt_colaMaxUrgencia);
            this.Controls.Add(this.txt_colaMaxConsulta);
            this.Controls.Add(this.txt_PorcUrgenciasAtend);
            this.Controls.Add(this.lbl_colasMax);
            this.Controls.Add(this.lbl_tiempoMaxEspera);
            this.Controls.Add(this.gdw_iteracionesSolicitadas);
            this.Name = "PantallaVisualizacion";
            this.Text = "Final Simulación - Ej. 112 - Brasca Marina";
            ((System.ComponentModel.ISupportInitialize)(this.gdw_iteracionesSolicitadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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