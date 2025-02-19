namespace FinalSim
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
            this.lbl_tiempoSimulacion = new System.Windows.Forms.Label();
            this.txt_tiempoSimulacion = new System.Windows.Forms.TextBox();
            this.lbl_unidadTSim = new System.Windows.Forms.Label();
            this.txt_horaDesde = new System.Windows.Forms.TextBox();
            this.lbl_horaDesde = new System.Windows.Forms.Label();
            this.lbl_tipoPaciente = new System.Windows.Forms.Label();
            this.lbl_Consulta = new System.Windows.Forms.Label();
            this.lbl_Urgencia = new System.Windows.Forms.Label();
            this.lbl_llegadas = new System.Windows.Forms.Label();
            this.lbl_finAtencion = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_B_finAtencUrgencia = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupHB3 = new System.Windows.Forms.Label();
            this.lbl_distoOcupHB2 = new System.Windows.Forms.Label();
            this.txt_A_finAtencUrgencia = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupHB1 = new System.Windows.Forms.Label();
            this.txt_B_finAtencConsulta = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupF3 = new System.Windows.Forms.Label();
            this.lbl_distoOcupF2 = new System.Windows.Forms.Label();
            this.txt_A_finAtencConsulta = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupF1 = new System.Windows.Forms.Label();
            this.txt_expLlegConsulta = new System.Windows.Forms.TextBox();
            this.lbl_distLlegF1 = new System.Windows.Forms.Label();
            this.lbl_distLlegF2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_expLlegUrgencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_tiempoSimulacion
            // 
            this.lbl_tiempoSimulacion.AutoSize = true;
            this.lbl_tiempoSimulacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tiempoSimulacion.Location = new System.Drawing.Point(64, 50);
            this.lbl_tiempoSimulacion.Name = "lbl_tiempoSimulacion";
            this.lbl_tiempoSimulacion.Size = new System.Drawing.Size(127, 15);
            this.lbl_tiempoSimulacion.TabIndex = 0;
            this.lbl_tiempoSimulacion.Text = "Tiempo de simulación";
            // 
            // txt_tiempoSimulacion
            // 
            this.txt_tiempoSimulacion.Location = new System.Drawing.Point(66, 71);
            this.txt_tiempoSimulacion.Name = "txt_tiempoSimulacion";
            this.txt_tiempoSimulacion.Size = new System.Drawing.Size(142, 23);
            this.txt_tiempoSimulacion.TabIndex = 1;
            this.txt_tiempoSimulacion.Text = "50";
            this.txt_tiempoSimulacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_unidadTSim
            // 
            this.lbl_unidadTSim.AutoSize = true;
            this.lbl_unidadTSim.Location = new System.Drawing.Point(228, 75);
            this.lbl_unidadTSim.Name = "lbl_unidadTSim";
            this.lbl_unidadTSim.Size = new System.Drawing.Size(36, 15);
            this.lbl_unidadTSim.TabIndex = 2;
            this.lbl_unidadTSim.Text = "horas";
            // 
            // txt_horaDesde
            // 
            this.txt_horaDesde.Location = new System.Drawing.Point(66, 122);
            this.txt_horaDesde.Name = "txt_horaDesde";
            this.txt_horaDesde.Size = new System.Drawing.Size(142, 23);
            this.txt_horaDesde.TabIndex = 6;
            this.txt_horaDesde.Text = "0";
            this.txt_horaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_horaDesde
            // 
            this.lbl_horaDesde.AutoSize = true;
            this.lbl_horaDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_horaDesde.Location = new System.Drawing.Point(66, 104);
            this.lbl_horaDesde.Name = "lbl_horaDesde";
            this.lbl_horaDesde.Size = new System.Drawing.Size(139, 15);
            this.lbl_horaDesde.TabIndex = 5;
            this.lbl_horaDesde.Text = "Mostrar resultados desde";
            // 
            // lbl_tipoPaciente
            // 
            this.lbl_tipoPaciente.AutoSize = true;
            this.lbl_tipoPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tipoPaciente.Location = new System.Drawing.Point(68, 194);
            this.lbl_tipoPaciente.Name = "lbl_tipoPaciente";
            this.lbl_tipoPaciente.Size = new System.Drawing.Size(99, 15);
            this.lbl_tipoPaciente.TabIndex = 11;
            this.lbl_tipoPaciente.Text = "Tipo de Paciente";
            // 
            // lbl_Consulta
            // 
            this.lbl_Consulta.AutoSize = true;
            this.lbl_Consulta.Location = new System.Drawing.Point(68, 230);
            this.lbl_Consulta.Name = "lbl_Consulta";
            this.lbl_Consulta.Size = new System.Drawing.Size(54, 15);
            this.lbl_Consulta.TabIndex = 12;
            this.lbl_Consulta.Text = "Consulta";
            // 
            // lbl_Urgencia
            // 
            this.lbl_Urgencia.AutoSize = true;
            this.lbl_Urgencia.Location = new System.Drawing.Point(68, 267);
            this.lbl_Urgencia.Name = "lbl_Urgencia";
            this.lbl_Urgencia.Size = new System.Drawing.Size(54, 15);
            this.lbl_Urgencia.TabIndex = 13;
            this.lbl_Urgencia.Text = "Urgencia";
            // 
            // lbl_llegadas
            // 
            this.lbl_llegadas.AutoSize = true;
            this.lbl_llegadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_llegadas.Location = new System.Drawing.Point(202, 194);
            this.lbl_llegadas.Name = "lbl_llegadas";
            this.lbl_llegadas.Size = new System.Drawing.Size(54, 15);
            this.lbl_llegadas.TabIndex = 15;
            this.lbl_llegadas.Text = "Llegadas";
            // 
            // lbl_finAtencion
            // 
            this.lbl_finAtencion.AutoSize = true;
            this.lbl_finAtencion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_finAtencion.Location = new System.Drawing.Point(367, 194);
            this.lbl_finAtencion.Name = "lbl_finAtencion";
            this.lbl_finAtencion.Size = new System.Drawing.Size(93, 15);
            this.lbl_finAtencion.TabIndex = 16;
            this.lbl_finAtencion.Text = "Fin de Atenciòn";
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_generar.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_generar.Location = new System.Drawing.Point(299, 51);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(242, 94);
            this.btn_generar.TabIndex = 17;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_B_finAtencUrgencia
            // 
            this.txt_B_finAtencUrgencia.Location = new System.Drawing.Point(440, 264);
            this.txt_B_finAtencUrgencia.Name = "txt_B_finAtencUrgencia";
            this.txt_B_finAtencUrgencia.Size = new System.Drawing.Size(47, 23);
            this.txt_B_finAtencUrgencia.TabIndex = 38;
            this.txt_B_finAtencUrgencia.Text = "40";
            this.txt_B_finAtencUrgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_distoOcupHB3
            // 
            this.lbl_distoOcupHB3.AutoSize = true;
            this.lbl_distoOcupHB3.Location = new System.Drawing.Point(493, 267);
            this.lbl_distoOcupHB3.Name = "lbl_distoOcupHB3";
            this.lbl_distoOcupHB3.Size = new System.Drawing.Size(35, 15);
            this.lbl_distoOcupHB3.TabIndex = 37;
            this.lbl_distoOcupHB3.Text = ") min";
            // 
            // lbl_distoOcupHB2
            // 
            this.lbl_distoOcupHB2.AutoSize = true;
            this.lbl_distoOcupHB2.Location = new System.Drawing.Point(433, 272);
            this.lbl_distoOcupHB2.Name = "lbl_distoOcupHB2";
            this.lbl_distoOcupHB2.Size = new System.Drawing.Size(10, 15);
            this.lbl_distoOcupHB2.TabIndex = 36;
            this.lbl_distoOcupHB2.Text = ",";
            // 
            // txt_A_finAtencUrgencia
            // 
            this.txt_A_finAtencUrgencia.Location = new System.Drawing.Point(385, 264);
            this.txt_A_finAtencUrgencia.Name = "txt_A_finAtencUrgencia";
            this.txt_A_finAtencUrgencia.Size = new System.Drawing.Size(47, 23);
            this.txt_A_finAtencUrgencia.TabIndex = 35;
            this.txt_A_finAtencUrgencia.Text = "25";
            this.txt_A_finAtencUrgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_distoOcupHB1
            // 
            this.lbl_distoOcupHB1.AutoSize = true;
            this.lbl_distoOcupHB1.Location = new System.Drawing.Point(367, 267);
            this.lbl_distoOcupHB1.Name = "lbl_distoOcupHB1";
            this.lbl_distoOcupHB1.Size = new System.Drawing.Size(19, 15);
            this.lbl_distoOcupHB1.TabIndex = 34;
            this.lbl_distoOcupHB1.Text = "U(";
            // 
            // txt_B_finAtencConsulta
            // 
            this.txt_B_finAtencConsulta.Location = new System.Drawing.Point(440, 227);
            this.txt_B_finAtencConsulta.Name = "txt_B_finAtencConsulta";
            this.txt_B_finAtencConsulta.Size = new System.Drawing.Size(47, 23);
            this.txt_B_finAtencConsulta.TabIndex = 43;
            this.txt_B_finAtencConsulta.Text = "20";
            this.txt_B_finAtencConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_distoOcupF3
            // 
            this.lbl_distoOcupF3.AutoSize = true;
            this.lbl_distoOcupF3.Location = new System.Drawing.Point(493, 230);
            this.lbl_distoOcupF3.Name = "lbl_distoOcupF3";
            this.lbl_distoOcupF3.Size = new System.Drawing.Size(35, 15);
            this.lbl_distoOcupF3.TabIndex = 42;
            this.lbl_distoOcupF3.Text = ") min";
            // 
            // lbl_distoOcupF2
            // 
            this.lbl_distoOcupF2.AutoSize = true;
            this.lbl_distoOcupF2.Location = new System.Drawing.Point(433, 235);
            this.lbl_distoOcupF2.Name = "lbl_distoOcupF2";
            this.lbl_distoOcupF2.Size = new System.Drawing.Size(10, 15);
            this.lbl_distoOcupF2.TabIndex = 41;
            this.lbl_distoOcupF2.Text = ",";
            // 
            // txt_A_finAtencConsulta
            // 
            this.txt_A_finAtencConsulta.Location = new System.Drawing.Point(385, 227);
            this.txt_A_finAtencConsulta.Name = "txt_A_finAtencConsulta";
            this.txt_A_finAtencConsulta.Size = new System.Drawing.Size(47, 23);
            this.txt_A_finAtencConsulta.TabIndex = 40;
            this.txt_A_finAtencConsulta.Text = "12";
            this.txt_A_finAtencConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_distoOcupF1
            // 
            this.lbl_distoOcupF1.AutoSize = true;
            this.lbl_distoOcupF1.Location = new System.Drawing.Point(367, 230);
            this.lbl_distoOcupF1.Name = "lbl_distoOcupF1";
            this.lbl_distoOcupF1.Size = new System.Drawing.Size(19, 15);
            this.lbl_distoOcupF1.TabIndex = 39;
            this.lbl_distoOcupF1.Text = "U(";
            // 
            // txt_expLlegConsulta
            // 
            this.txt_expLlegConsulta.Location = new System.Drawing.Point(265, 224);
            this.txt_expLlegConsulta.Name = "txt_expLlegConsulta";
            this.txt_expLlegConsulta.Size = new System.Drawing.Size(47, 23);
            this.txt_expLlegConsulta.TabIndex = 44;
            this.txt_expLlegConsulta.Text = "40";
            this.txt_expLlegConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_distLlegF1
            // 
            this.lbl_distLlegF1.AutoSize = true;
            this.lbl_distLlegF1.Location = new System.Drawing.Point(202, 227);
            this.lbl_distLlegF1.Name = "lbl_distLlegF1";
            this.lbl_distLlegF1.Size = new System.Drawing.Size(57, 15);
            this.lbl_distLlegF1.TabIndex = 45;
            this.lbl_distLlegF1.Text = "Exp. Neg.";
            // 
            // lbl_distLlegF2
            // 
            this.lbl_distLlegF2.AutoSize = true;
            this.lbl_distLlegF2.Location = new System.Drawing.Point(318, 230);
            this.lbl_distLlegF2.Name = "lbl_distLlegF2";
            this.lbl_distLlegF2.Size = new System.Drawing.Size(28, 15);
            this.lbl_distLlegF2.TabIndex = 46;
            this.lbl_distLlegF2.Text = "min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Exp. Neg.";
            // 
            // txt_expLlegUrgencia
            // 
            this.txt_expLlegUrgencia.Location = new System.Drawing.Point(265, 263);
            this.txt_expLlegUrgencia.Name = "txt_expLlegUrgencia";
            this.txt_expLlegUrgencia.Size = new System.Drawing.Size(47, 23);
            this.txt_expLlegUrgencia.TabIndex = 48;
            this.txt_expLlegUrgencia.Text = "105";
            this.txt_expLlegUrgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // PantallaSimParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(612, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_expLlegUrgencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_distLlegF2);
            this.Controls.Add(this.lbl_distLlegF1);
            this.Controls.Add(this.txt_expLlegConsulta);
            this.Controls.Add(this.txt_B_finAtencConsulta);
            this.Controls.Add(this.lbl_distoOcupF3);
            this.Controls.Add(this.lbl_distoOcupF2);
            this.Controls.Add(this.txt_A_finAtencConsulta);
            this.Controls.Add(this.lbl_distoOcupF1);
            this.Controls.Add(this.txt_B_finAtencUrgencia);
            this.Controls.Add(this.lbl_distoOcupHB3);
            this.Controls.Add(this.lbl_distoOcupHB2);
            this.Controls.Add(this.txt_A_finAtencUrgencia);
            this.Controls.Add(this.lbl_distoOcupHB1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.lbl_finAtencion);
            this.Controls.Add(this.lbl_llegadas);
            this.Controls.Add(this.lbl_Urgencia);
            this.Controls.Add(this.lbl_Consulta);
            this.Controls.Add(this.lbl_tipoPaciente);
            this.Controls.Add(this.txt_horaDesde);
            this.Controls.Add(this.lbl_horaDesde);
            this.Controls.Add(this.lbl_unidadTSim);
            this.Controls.Add(this.txt_tiempoSimulacion);
            this.Controls.Add(this.lbl_tiempoSimulacion);
            this.Name = "PantallaSimParametros";
            this.Text = "Ej. Consultorio -  Parametros";
            this.ResumeLayout(false);
            this.PerformLayout();

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