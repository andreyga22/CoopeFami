using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO {
   public class TOPrestamo {

        private double cantidad;
        public double Cantidad {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private DateTime fechaInicio;
        public DateTime FechaInicio {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        private DateTime fechaFin;
        public DateTime FechaFin {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private DateTime fechaCastigo;
        public DateTime FechaCastigo {
            get { return fechaCastigo; }
            set { fechaCastigo = value; }
        }

        private double cuota;
        public double Cuota {
            get { return cuota; }
            set { cuota = value; }
        }

        private double interes;
        public double Interes {
            get { return interes; }
            set { interes = value; }
        }

        private double dineroPagado;
        public double DineroPagado {
            get { return dineroPagado; }
            set { dineroPagado = value; }
        }

        private Boolean activo;
        public Boolean Activo {
            get { return activo; }
            set { activo = value; }
        }

        private int idPrestamo;
        public int IdPrestamo {
            get { return idPrestamo; }
            set { idPrestamo = value; }
        }

        public TOPrestamo(double cantidad, DateTime fechaIni, DateTime fechaFin, DateTime fechaCast, double cuota, double interes, double dineroPagado, Boolean activo, int idPrestamo) {
            Cantidad = cantidad;
            FechaInicio = fechaIni;
            FechaFin = fechaFin;
            FechaCastigo = fechaCast;
            Cuota = cuota;
            Interes = interes;
            DineroPagado = dineroPagado;
            Activo = activo;
            IdPrestamo = IdPrestamo;
        }
    }
}
