using FinalSim.Entidades;

namespace FinalSim
{
    public partial class PantallaSimParametros : Form
    {
        ValidadorParametros validadorParametros;
        public PantallaSimParametros()
        {
            InitializeComponent();
            validadorParametros = new ValidadorParametros();
        }

        private bool estaVacio(string texto)
        {
            return texto == "";
        }

        private bool faltanParams()
        {
            bool faltaObligatorio = estaVacio(txt_tiempoSimulacion.Text) || estaVacio(txt_horaDesde.Text);
            bool faltaExponencial = estaVacio(txt_expLlegConsulta.Text) || estaVacio(txt_expLlegUrgencia.Text);
            bool faltaUniforme = estaVacio(txt_A_finAtencConsulta.Text) || estaVacio(txt_B_finAtencConsulta.Text) || estaVacio(txt_A_finAtencUrgencia.Text) || estaVacio(txt_B_finAtencUrgencia.Text);

            return (faltaObligatorio || faltaExponencial || faltaUniforme);
        }

        private bool validarParamsGestor(double inicioImp, double finSim, double mediaLlegConsulta, double mediaLlegUrgencia, double[] limsfinConsulta, double[] limsfinUrgencia)
        {
            ValidadorParametros validadorParametros = new ValidadorParametros();
            bool todosSuperioresACero = validadorParametros.validarSuperiorACero(inicioImp);
            todosSuperioresACero = todosSuperioresACero || validadorParametros.validarSuperiorACero(finSim);
            todosSuperioresACero = todosSuperioresACero || validadorParametros.validarSuperiorACero(mediaLlegConsulta);
            todosSuperioresACero = todosSuperioresACero || validadorParametros.validarSuperiorACero(mediaLlegUrgencia);
            todosSuperioresACero = todosSuperioresACero || validadorParametros.validarSuperiorACero(limsfinConsulta[0]);
            todosSuperioresACero = todosSuperioresACero || validadorParametros.validarSuperiorACero(limsfinConsulta[1]);
            todosSuperioresACero = todosSuperioresACero || validadorParametros.validarSuperiorACero(limsfinUrgencia[0]);
            todosSuperioresACero = todosSuperioresACero || validadorParametros.validarSuperiorACero(limsfinUrgencia[1]);


            return todosSuperioresACero;
        }
        private void btn_generar_Click(object sender, EventArgs e)
        {

            if (faltanParams())
            {
                MessageBox.Show("Faltan parametros!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double inicioImp = Double.Parse(txt_horaDesde.Text) * 60;
            double finSim = Double.Parse(txt_tiempoSimulacion.Text);
            double mediaLlegConsulta = Double.Parse(txt_expLlegConsulta.Text);
            double mediaLlegUrgencia = Double.Parse(txt_expLlegUrgencia.Text);
            double[] limsfinConsulta = new double[] { Double.Parse(txt_A_finAtencConsulta.Text), Double.Parse(txt_B_finAtencConsulta.Text) };
            double[] limsfinUrgencia = new double[] { Double.Parse(txt_A_finAtencUrgencia.Text) * 60, Double.Parse(txt_B_finAtencUrgencia.Text)};
            
            if (!validarParamsGestor(inicioImp, finSim, mediaLlegConsulta, mediaLlegUrgencia, limsfinConsulta, limsfinUrgencia))
            {
                MessageBox.Show("Los parametros deben ser superiores a cero!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GestorSimulacion gestorSimulacion = new GestorSimulacion(inicioImp, finSim, mediaLlegConsulta, mediaLlegUrgencia, limsfinConsulta, limsfinUrgencia);
            gestorSimulacion.Simular();
            PantallaVisualizacion pantallaVisualizacion = new PantallaVisualizacion(gestorSimulacion.Datos);
            pantallaVisualizacion.ShowDialog();

        }


        private void txt_DoubleParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo digitos, caracteres de control y un solo punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',' || ((TextBox)sender).Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void txt_IntParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo digitos y caracteres de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}