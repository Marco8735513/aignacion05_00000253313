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
    public partial class TodosLosMetodos: Form
    {
        public TodosLosMetodos()
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
    }
}
