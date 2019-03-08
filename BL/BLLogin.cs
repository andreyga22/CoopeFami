using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLLogin
    {
        private string id;
        public string Id {
            get { return id; }
            set { id = value; }
        }

        private string contrasena;
        public string Contrasena {
            get { return contrasena; }
            set { contrasena = value; }
        }

        private string cedula;
        public string Cedula {
            get { return cedula; }
            set { cedula = value; }
        }

        public BLLogin(string id, string contra) {
            Id = id;
            Contrasena = contra;
        }

        public BLLogin(string id, string contra, string cedula) {
            Id = id;
            Contrasena = contra;
            Cedula = cedula;
        }

        public BLLogin() {
        }
    }
}
