using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL {
    public class BLAfiliacion {


        private double capital_inicial;
        public double Capital_inicial {
            get { return capital_inicial; }
            set {
                capital_inicial = value;
            }
        }
        public BLAfiliacion(double capital) {
            Capital_inicial = capital;
        }
    }
}
