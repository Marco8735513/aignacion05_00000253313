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
    public partial class MenuPrincipal: Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignacion4_Click(object sender, EventArgs e)
        {
            asignacion04_00000253313.Form1 formAsignacion4 = new asignacion04_00000253313.Form1();
            formAsignacion4.Show();
        }

        private void btnAsignacion5_Click(object sender, EventArgs e)
        {

            MetodoNS formAsignacion5 = new MetodoNS ();
            formAsignacion5.Show();
        }

        private void btnTodosLosMetodos_Click(object sender, EventArgs e)
        {
            TodosLosMetodos formTodosLosMetodos = new TodosLosMetodos();
            formTodosLosMetodos.Show();
        }
    }
}
