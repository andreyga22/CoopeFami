﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO {
    public class TOCapital {

        private double dineroDisponible;
        public double DineroDisponible {
            get { return dineroDisponible; }
            set { dineroDisponible = value; }
        }

        private int prestamosDados;
        public int PrestamosDados {
            get { return prestamosDados; }
            set { prestamosDados = value; }
        }

        public TOCapital() {

        }
    }
}
