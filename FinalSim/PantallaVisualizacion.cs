﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalSim.Entidades;

namespace FinalSim
{
    public partial class PantallaVisualizacion : Form
    {
        DataTable CSV;
        CsvReader CSVReader;
        public PantallaVisualizacion(string _archivoCSV)
        {
            // Inicializa los componentes de la pantalla e instancia
            InitializeComponent();
            CSVReader = new CsvReader(_archivoCSV);
            CSV = new DataTable();
        }

        private void PantallaVisualizacion_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los contenidos del CSV


            double[] resultados = CSVReader.LoadCsvData(CSV);
            gdw_iteracionesSolicitadas.DataSource = CSV;

            // Estetico Columnas Tabla
            foreach (DataGridViewColumn columna in gdw_iteracionesSolicitadas.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Cargamos la probabilidad

            txt_colaMaxTotal.Text = resultados[0].ToString();
            txt_PorcUrgenciasAtend.Text = resultados[1].ToString();
            txt_colaMaxUrgencia.Text = resultados[2].ToString();
            txt_colaMaxConsulta.Text = resultados[3].ToString();
            txt_maxEsperaConsulta.Text = resultados[4].ToString();
            txt_maxEsperaUrgencia.Text = resultados[5].ToString();

        }
    }
}
