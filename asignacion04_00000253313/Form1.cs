using RaicesLogica.Model;
using RaicesLogica.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asignacion04_00000253313
{
    public partial class Form1: Form
    {
        //Creamos el servicio solo una vez y lo usamos en todo el formulario
        private readonly Resultado _servicio = new Resultado();

        public Form1()
        {
            InitializeComponent();

            // Configurar DataGridView
            dgvResultado.ColumnCount = 6;
            dgvResultado.Columns[0].Name = "Iteración";
            dgvResultado.Columns[1].Name = "Xi";
            dgvResultado.Columns[2].Name = "Xf";
            dgvResultado.Columns[3].Name = "Xr";
            dgvResultado.Columns[4].Name = "F(Xr)";
            dgvResultado.Columns[5].Name = "Error";

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvResultado.Rows.Clear();

            double xi, xf, eamax;
            try
            {
                xi = double.Parse(txtXi.Text);
                xf = double.Parse(txtXf.Text);
                eamax = double.Parse(txtErrorMaximo.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa valores numéricos válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Iteracion> iteraciones;

                if (radbtnBiseccion.Checked)
                {
                    iteraciones = _servicio.Biseccion(xi, xf, eamax);
                }
                else if (radbtnReglaFalsa.Checked)
                {
                    iteraciones = _servicio.ReglaFalsa(xi, xf, eamax);
                }
                else
                {
                    MessageBox.Show("Selecciona un método primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var item in iteraciones)
                {
                    dgvResultado.Rows.Add(
                        item.Numero,
                        item.Xi.ToString("F6"),
                        item.Xf.ToString("F6"),
                        item.Xr.ToString("F6"),
                        item.FxR.ToString("F6"),
                        item.Error.ToString("F6")
                    );
                }
            }
            catch (ArgumentException ex)
            {
                // Mensaje amigable por intervalos inválidos
                MessageBox.Show(ex.Message, "Error de intervalo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Cualquier otro error, también amigable
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
