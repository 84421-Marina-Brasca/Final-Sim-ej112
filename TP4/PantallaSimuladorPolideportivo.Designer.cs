namespace TP4
{
    partial class PantallaSimParametros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_tiempoSimulacion = new Label();
            txt_tiempoSimulacion = new TextBox();
            lbl_unidadTSim = new Label();
            txt_horaDesde = new TextBox();
            lbl_horaDesde = new Label();
            lbl_tipoPaciente = new Label();
            lbl_Consulta = new Label();
            lbl_Urgencia = new Label();
            lbl_llegadas = new Label();
            lbl_finAtencion = new Label();
            btn_generar = new Button();
            txt_B_finAtencUrgencia = new TextBox();
            lbl_distoOcupHB3 = new Label();
            lbl_distoOcupHB2 = new Label();
            txt_A_finAtencUrgencia = new TextBox();
            lbl_distoOcupHB1 = new Label();
            txt_B_finAtencConsulta = new TextBox();
            lbl_distoOcupF3 = new Label();
            lbl_distoOcupF2 = new Label();
            txt_A_finAtencConsulta = new TextBox();
            lbl_distoOcupF1 = new Label();
            txt_expLlegConsulta = new TextBox();
            lbl_distLlegF1 = new Label();
            lbl_distLlegF2 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_expLlegUrgencia = new TextBox();
            SuspendLayout();
            // 
            // lbl_tiempoSimulacion
            // 
            lbl_tiempoSimulacion.AutoSize = true;
            lbl_tiempoSimulacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tiempoSimulacion.Location = new Point(64, 50);
            lbl_tiempoSimulacion.Name = "lbl_tiempoSimulacion";
            lbl_tiempoSimulacion.Size = new Size(127, 15);
            lbl_tiempoSimulacion.TabIndex = 0;
            lbl_tiempoSimulacion.Text = "Tiempo de simulación";
            // 
            // txt_tiempoSimulacion
            // 
            txt_tiempoSimulacion.Location = new Point(66, 71);
            txt_tiempoSimulacion.Name = "txt_tiempoSimulacion";
            txt_tiempoSimulacion.Size = new Size(142, 23);
            txt_tiempoSimulacion.TabIndex = 1;
            txt_tiempoSimulacion.Text = "50";
            txt_tiempoSimulacion.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_unidadTSim
            // 
            lbl_unidadTSim.AutoSize = true;
            lbl_unidadTSim.Location = new Point(228, 75);
            lbl_unidadTSim.Name = "lbl_unidadTSim";
            lbl_unidadTSim.Size = new Size(36, 15);
            lbl_unidadTSim.TabIndex = 2;
            lbl_unidadTSim.Text = "horas";
            // 
            // txt_horaDesde
            // 
            txt_horaDesde.Location = new Point(66, 122);
            txt_horaDesde.Name = "txt_horaDesde";
            txt_horaDesde.Size = new Size(142, 23);
            txt_horaDesde.TabIndex = 6;
            txt_horaDesde.Text = "0";
            txt_horaDesde.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_horaDesde
            // 
            lbl_horaDesde.AutoSize = true;
            lbl_horaDesde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_horaDesde.Location = new Point(66, 104);
            lbl_horaDesde.Name = "lbl_horaDesde";
            lbl_horaDesde.Size = new Size(139, 15);
            lbl_horaDesde.TabIndex = 5;
            lbl_horaDesde.Text = "Mostrar resultados desde";
            // 
            // lbl_tipoPaciente
            // 
            lbl_tipoPaciente.AutoSize = true;
            lbl_tipoPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tipoPaciente.Location = new Point(68, 194);
            lbl_tipoPaciente.Name = "lbl_tipoPaciente";
            lbl_tipoPaciente.Size = new Size(99, 15);
            lbl_tipoPaciente.TabIndex = 11;
            lbl_tipoPaciente.Text = "Tipo de Paciente";
            // 
            // lbl_Consulta
            // 
            lbl_Consulta.AutoSize = true;
            lbl_Consulta.Location = new Point(68, 230);
            lbl_Consulta.Name = "lbl_Consulta";
            lbl_Consulta.Size = new Size(54, 15);
            lbl_Consulta.TabIndex = 12;
            lbl_Consulta.Text = "Consulta";
            // 
            // lbl_Urgencia
            // 
            lbl_Urgencia.AutoSize = true;
            lbl_Urgencia.Location = new Point(68, 267);
            lbl_Urgencia.Name = "lbl_Urgencia";
            lbl_Urgencia.Size = new Size(54, 15);
            lbl_Urgencia.TabIndex = 13;
            lbl_Urgencia.Text = "Urgencia";
            // 
            // lbl_llegadas
            // 
            lbl_llegadas.AutoSize = true;
            lbl_llegadas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_llegadas.Location = new Point(202, 194);
            lbl_llegadas.Name = "lbl_llegadas";
            lbl_llegadas.Size = new Size(54, 15);
            lbl_llegadas.TabIndex = 15;
            lbl_llegadas.Text = "Llegadas";
            // 
            // lbl_finAtencion
            // 
            lbl_finAtencion.AutoSize = true;
            lbl_finAtencion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_finAtencion.Location = new Point(367, 194);
            lbl_finAtencion.Name = "lbl_finAtencion";
            lbl_finAtencion.Size = new Size(93, 15);
            lbl_finAtencion.TabIndex = 16;
            lbl_finAtencion.Text = "Fin de Atenciòn";
            // 
            // btn_generar
            // 
            btn_generar.BackColor = Color.DarkBlue;
            btn_generar.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_generar.ForeColor = Color.AliceBlue;
            btn_generar.Location = new Point(299, 51);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(242, 94);
            btn_generar.TabIndex = 17;
            btn_generar.Text = "Generar";
            btn_generar.UseVisualStyleBackColor = false;
            btn_generar.Click += btn_generar_Click;
            // 
            // txt_B_finAtencUrgencia
            // 
            txt_B_finAtencUrgencia.Location = new Point(440, 264);
            txt_B_finAtencUrgencia.Name = "txt_B_finAtencUrgencia";
            txt_B_finAtencUrgencia.Size = new Size(47, 23);
            txt_B_finAtencUrgencia.TabIndex = 38;
            txt_B_finAtencUrgencia.Text = "40";
            txt_B_finAtencUrgencia.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distoOcupHB3
            // 
            lbl_distoOcupHB3.AutoSize = true;
            lbl_distoOcupHB3.Location = new Point(493, 267);
            lbl_distoOcupHB3.Name = "lbl_distoOcupHB3";
            lbl_distoOcupHB3.Size = new Size(35, 15);
            lbl_distoOcupHB3.TabIndex = 37;
            lbl_distoOcupHB3.Text = ") min";
            // 
            // lbl_distoOcupHB2
            // 
            lbl_distoOcupHB2.AutoSize = true;
            lbl_distoOcupHB2.Location = new Point(433, 272);
            lbl_distoOcupHB2.Name = "lbl_distoOcupHB2";
            lbl_distoOcupHB2.Size = new Size(10, 15);
            lbl_distoOcupHB2.TabIndex = 36;
            lbl_distoOcupHB2.Text = ",";
            // 
            // txt_A_finAtencUrgencia
            // 
            txt_A_finAtencUrgencia.Location = new Point(385, 264);
            txt_A_finAtencUrgencia.Name = "txt_A_finAtencUrgencia";
            txt_A_finAtencUrgencia.Size = new Size(47, 23);
            txt_A_finAtencUrgencia.TabIndex = 35;
            txt_A_finAtencUrgencia.Text = "25";
            txt_A_finAtencUrgencia.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distoOcupHB1
            // 
            lbl_distoOcupHB1.AutoSize = true;
            lbl_distoOcupHB1.Location = new Point(367, 267);
            lbl_distoOcupHB1.Name = "lbl_distoOcupHB1";
            lbl_distoOcupHB1.Size = new Size(19, 15);
            lbl_distoOcupHB1.TabIndex = 34;
            lbl_distoOcupHB1.Text = "U(";
            // 
            // txt_B_finAtencConsulta
            // 
            txt_B_finAtencConsulta.Location = new Point(440, 227);
            txt_B_finAtencConsulta.Name = "txt_B_finAtencConsulta";
            txt_B_finAtencConsulta.Size = new Size(47, 23);
            txt_B_finAtencConsulta.TabIndex = 43;
            txt_B_finAtencConsulta.Text = "20";
            txt_B_finAtencConsulta.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distoOcupF3
            // 
            lbl_distoOcupF3.AutoSize = true;
            lbl_distoOcupF3.Location = new Point(493, 230);
            lbl_distoOcupF3.Name = "lbl_distoOcupF3";
            lbl_distoOcupF3.Size = new Size(35, 15);
            lbl_distoOcupF3.TabIndex = 42;
            lbl_distoOcupF3.Text = ") min";
            // 
            // lbl_distoOcupF2
            // 
            lbl_distoOcupF2.AutoSize = true;
            lbl_distoOcupF2.Location = new Point(433, 235);
            lbl_distoOcupF2.Name = "lbl_distoOcupF2";
            lbl_distoOcupF2.Size = new Size(10, 15);
            lbl_distoOcupF2.TabIndex = 41;
            lbl_distoOcupF2.Text = ",";
            // 
            // txt_A_finAtencConsulta
            // 
            txt_A_finAtencConsulta.Location = new Point(385, 227);
            txt_A_finAtencConsulta.Name = "txt_A_finAtencConsulta";
            txt_A_finAtencConsulta.Size = new Size(47, 23);
            txt_A_finAtencConsulta.TabIndex = 40;
            txt_A_finAtencConsulta.Text = "12";
            txt_A_finAtencConsulta.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distoOcupF1
            // 
            lbl_distoOcupF1.AutoSize = true;
            lbl_distoOcupF1.Location = new Point(367, 230);
            lbl_distoOcupF1.Name = "lbl_distoOcupF1";
            lbl_distoOcupF1.Size = new Size(19, 15);
            lbl_distoOcupF1.TabIndex = 39;
            lbl_distoOcupF1.Text = "U(";
            // 
            // txt_expLlegConsulta
            // 
            txt_expLlegConsulta.Location = new Point(265, 224);
            txt_expLlegConsulta.Name = "txt_expLlegConsulta";
            txt_expLlegConsulta.Size = new Size(47, 23);
            txt_expLlegConsulta.TabIndex = 44;
            txt_expLlegConsulta.Text = "40";
            txt_expLlegConsulta.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distLlegF1
            // 
            lbl_distLlegF1.AutoSize = true;
            lbl_distLlegF1.Location = new Point(202, 227);
            lbl_distLlegF1.Name = "lbl_distLlegF1";
            lbl_distLlegF1.Size = new Size(57, 15);
            lbl_distLlegF1.TabIndex = 45;
            lbl_distLlegF1.Text = "Exp. Neg.";
            // 
            // lbl_distLlegF2
            // 
            lbl_distLlegF2.AutoSize = true;
            lbl_distLlegF2.Location = new Point(318, 230);
            lbl_distLlegF2.Name = "lbl_distLlegF2";
            lbl_distLlegF2.Size = new Size(22, 15);
            lbl_distLlegF2.TabIndex = 46;
            lbl_distLlegF2.Text = " hs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 123);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 47;
            label1.Text = "horas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 269);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 50;
            label2.Text = " hs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 266);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 49;
            label3.Text = "Exp. Neg.";
            // 
            // txt_expLlegUrgencia
            // 
            txt_expLlegUrgencia.Location = new Point(265, 263);
            txt_expLlegUrgencia.Name = "txt_expLlegUrgencia";
            txt_expLlegUrgencia.Size = new Size(47, 23);
            txt_expLlegUrgencia.TabIndex = 48;
            txt_expLlegUrgencia.Text = "105";
            // 
            // PantallaSimParametros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(612, 333);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txt_expLlegUrgencia);
            Controls.Add(label1);
            Controls.Add(lbl_distLlegF2);
            Controls.Add(lbl_distLlegF1);
            Controls.Add(txt_expLlegConsulta);
            Controls.Add(txt_B_finAtencConsulta);
            Controls.Add(lbl_distoOcupF3);
            Controls.Add(lbl_distoOcupF2);
            Controls.Add(txt_A_finAtencConsulta);
            Controls.Add(lbl_distoOcupF1);
            Controls.Add(txt_B_finAtencUrgencia);
            Controls.Add(lbl_distoOcupHB3);
            Controls.Add(lbl_distoOcupHB2);
            Controls.Add(txt_A_finAtencUrgencia);
            Controls.Add(lbl_distoOcupHB1);
            Controls.Add(btn_generar);
            Controls.Add(lbl_finAtencion);
            Controls.Add(lbl_llegadas);
            Controls.Add(lbl_Urgencia);
            Controls.Add(lbl_Consulta);
            Controls.Add(lbl_tipoPaciente);
            Controls.Add(txt_horaDesde);
            Controls.Add(lbl_horaDesde);
            Controls.Add(lbl_unidadTSim);
            Controls.Add(txt_tiempoSimulacion);
            Controls.Add(lbl_tiempoSimulacion);
            Name = "PantallaSimParametros";
            Text = "Ej. Consultorio -  Parametros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tiempoSimulacion;
        private TextBox txt_tiempoSimulacion;
        private Label lbl_unidadTSim;
        private TextBox txt_horaDesde;
        private Label lbl_horaDesde;
        private Label lbl_tipoPaciente;
        private Label lbl_Consulta;
        private Label lbl_Urgencia;
        private Label lbl_llegadas;
        private Label lbl_finAtencion;
        private Button btn_generar;
        private TextBox txt_B_finAtencUrgencia;
        private Label lbl_distoOcupHB3;
        private Label lbl_distoOcupHB2;
        private TextBox txt_A_finAtencUrgencia;
        private Label lbl_distoOcupHB1;
        private TextBox txt_B_finAtencConsulta;
        private Label lbl_distoOcupF3;
        private Label lbl_distoOcupF2;
        private TextBox txt_A_finAtencConsulta;
        private Label lbl_distoOcupF1;
        private TextBox txt_expLlegConsulta;
        private Label lbl_distLlegF1;
        private Label lbl_distLlegF2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_expLlegUrgencia;
    }
}