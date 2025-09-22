using aignacion05_00000253313.MetodoNewtonSecuencia.Service;
using aignacion05_00000253313.TodosLosMetodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aignacion05_00000253313
{
    public partial class TodosLosMetodo : Form
    {

        // Variables para la función y su derivada
        private Func<double, double> funcionSeleccionada;
        private Func<double, double> derivadaSeleccionada;


        public TodosLosMetodo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asignacion04_00000253313.Form1 formAsignacion4 = new asignacion04_00000253313.Form1();
            formAsignacion4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MetodoNS metodoNewtonSecuencia = new MetodoNS();
            metodoNewtonSecuencia.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MetodoNS metodoNewtonSecuencia = new MetodoNS();
            metodoNewtonSecuencia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asignacion04_00000253313.Form1 formAsignacion4 = new asignacion04_00000253313.Form1();
            formAsignacion4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFunciones.SelectedIndex)
            {
                case 0:
                    funcionSeleccionada = FuncionesMenuPrincipal.F1;
                    derivadaSeleccionada = FuncionesMenuPrincipal.F1Derivada;
                    break;
                case 1:
                    funcionSeleccionada = FuncionesMenuPrincipal.F2;
                    derivadaSeleccionada = FuncionesMenuPrincipal.F2Derivada;
                    break;
                case 2:
                    funcionSeleccionada = FuncionesMenuPrincipal.F3;
                    derivadaSeleccionada = FuncionesMenuPrincipal.F3Derivada;
                    break;
                case 3:
                    funcionSeleccionada = FuncionesMenuPrincipal.F4;
                    derivadaSeleccionada = FuncionesMenuPrincipal.F4Derivada;
                    break;
                case 4:
                    funcionSeleccionada = FuncionesMenuPrincipal.F5;
                    derivadaSeleccionada = FuncionesMenuPrincipal.F5Derivada;
                    break;
            }

        }

        private void TodosLosMetodos_Load(object sender, EventArgs e)
        {
            // Limpiamos primero
            cbxFunciones.Items.Clear();

            // Agregamos los nombres visibles al usuario
            cbxFunciones.Items.Add("f1: x² - 4");
            cbxFunciones.Items.Add("f2: cos(x) - x");
            cbxFunciones.Items.Add("f3: x³ - 2x + 1");
            cbxFunciones.Items.Add("f4: e^x - 3x");
            cbxFunciones.Items.Add("f5: ln(x+1) + x - 2");

            // Selección por defecto
            cbxFunciones.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtxi.Text) ||
                   string.IsNullOrWhiteSpace(txtxf.Text) ||
                   string.IsNullOrWhiteSpace(txtErrorMaximo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double xi = double.Parse(txtxi.Text);
                double xf = double.Parse(txtxf.Text);
                double tol = double.Parse(txtErrorMaximo.Text);

                if (!double.TryParse(txtxi.Text, out xi) ||
                !double.TryParse(txtxf.Text, out xf) ||
                !double.TryParse(txtErrorMaximo.Text, out tol))
                {
                    MessageBox.Show("Por favor, ingresa solo valores numéricos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Func<double, double> f = funcionSeleccionada;      // La función seleccionada
                Func<double, double> df = derivadaSeleccionada; // Solo para Newton


                var resultados = MetodosMenuPrincipal.CalcularTodos(xi, xf, tol, f, df);

                // Mostrar los resultados en el DataGridView
                dgvResultados.DataSource = resultados;
                dgvResultados.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
