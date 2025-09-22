using aignacion05_00000253313.MetodoNewtonSecuencia.Modelo;
using aignacion05_00000253313.MetodoNewtonSecuencia.Service;
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
    public partial class MetodoNS : Form
    {
        public MetodoNS()
        {
            InitializeComponent();
            MostrarNewton(false);
            MostrarSecante(false);
            radNewton.Checked = false;
            radSecante.Checked = false;
            txtX1.Visible = true;
            txtX2.Visible = true;
            lblX1.Visible = true;
            lblX2.Visible = true;
            lblMetodoSecante.Visible = true;
            radSecante.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;


        }

     

        private void lblXi_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radNewton.Checked)
            {
                MostrarNewton(true);
                MostrarSecante(false);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radSecante.Checked)
            {
                MostrarSecante(true);
                MostrarNewton(false);
            }

        }

        private void MostrarNewton(bool visible)
        {
            txtXi.Visible = visible;
            lblXi.Visible = visible;
            lblMetodoNewton.Visible = visible;  
        }

        private void MostrarSecante(bool visible)
        {
            
            txtX2.Visible = visible;
            lblX2.Visible = visible;
            txtX1.Visible = visible;
            lblX1.Visible = visible;
            lblMetodoSecante.Visible = visible;


        }

        private void lblX1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Esto es para el metodo de Newton
            try
            {
                if (radNewton.Checked)
                {
                    // Capturamos valores de los TextBox
                    double xi = double.Parse(txtXi.Text);
                    double eamax = double.Parse(txtErrorMaximo.Text);

                    // Llamamos al Service
                    var resultados = Resultado.Calcular(xi, eamax);


                    dgvResultado.AutoGenerateColumns = false;
                    dgvResultado.Columns.Clear();

                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Iteración", DataPropertyName = "Iteracion" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Xi", DataPropertyName = "Xi" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "f(Xi)", DataPropertyName = "fxi" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "f'(Xi)", DataPropertyName = "Dfxi" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ea", DataPropertyName = "Ea" });



                    // Mostramos en DataGridView
                    dgvResultado.DataSource = resultados;
                }
                else if (radSecante.Checked)
                {
                    double x1 = double.Parse(txtX1.Text);
                    double x2 = double.Parse(txtX2.Text);
                    double eamax = double.Parse(txtErrorMaximo.Text);

                    var resultados = Resultado.Calcular(x1,eamax);

                    dgvResultado.DataSource = resultados;
                }
                else
                {
                    MessageBox.Show("Seleccione un método primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Esto es para el metodo de Secante
            try
            {
                if (radSecante.Checked)
                {
                    // Capturamos valores de los TextBox
                    if (!double.TryParse(txtX1.Text, out double x1))
                    {
                        MessageBox.Show("X1 no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!double.TryParse(txtX2.Text, out double x2))
                    {
                        MessageBox.Show("X2 no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!double.TryParse(txtErrorMaximo.Text, out double eamax))
                    {
                        MessageBox.Show("Error máximo no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Llamamos al Service de la Secante
                    var resultados = Resultado.Calcular2(x1, x2, eamax);

                    // Configuramos columnas del DataGridView y asignamos DataSource
                    dgvResultado.AutoGenerateColumns = false;
                    dgvResultado.Columns.Clear();

                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Iteración", DataPropertyName = "Iteracion" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "X1", DataPropertyName = "X1" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "X2", DataPropertyName = "X2" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Xr", DataPropertyName = "Xr" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "fx1", DataPropertyName = "fx1" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "fx2", DataPropertyName = "fx2" });
                    dgvResultado.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ea", DataPropertyName = "Ea" });





                    // Mostramos en DataGridView
                    dgvResultado.DataSource = resultados;
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
