using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO {
    public class TOUsuarioAfiliado {

        public TOUsuarioAfiliado(string primer, string segundo, string ape1, string ape2, string tel, string correo, string ced) {
            PrimerNombre = primer;
            SegundoNombre = segundo;
            PrimerApellido = ape1;
            SegundoApellido = ape2;
            Telefono = tel;
            Correo = correo;
            Cedula = ced;
        }

        private string primerNombre;
        public string PrimerNombre {
            get { return primerNombre; }
            set { primerNombre = value; }
        }

        private string segundoNombre;
        public string SegundoNombre {
            get { return segundoNombre; }
            set { segundoNombre = value; }
        }

        private string primerApellido;
        public string PrimerApellido {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        private string segundoApellido;
        public string SegundoApellido {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        private string telefono;
        public string Telefono {
            get { return telefono; }
            set { telefono = value; }
        }

        private string correo;
        public string Correo {
            get { return correo; }
            set { correo = value; }
        }

        private string cedula;
        public string Cedula {
            get { return cedula; }
            set { cedula = value; }
        }
    }
}
