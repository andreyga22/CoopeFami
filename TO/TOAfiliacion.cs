using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOAfiliacion
    {
        private double capital_inicial;
        public double Capital_inicial {
            get { return capital_inicial; }
            set {
                capital_inicial = value;
            }
        }
        public TOAfiliacion(double capital) {
            Capital_inicial = capital;
        }
    }
}
