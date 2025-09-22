using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aignacion05_00000253313.TodosLosMetodos
{
    public class ResultadoGeneral
    {
        public string Metodo { get; set; }
        public int Iteracion { get; set; }
        public double Xi { get; set; }
        public double Xf { get; set; }
        public double Xr { get; set; }
        public double Fxr { get; set; }
        public double? Derivada { get; set; } // Solo Newton
        public double Error { get; set; }

    }
}
