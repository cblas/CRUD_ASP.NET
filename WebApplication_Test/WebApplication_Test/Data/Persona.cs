using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Test.Data
{
    public class Persona
    {
        protected string nombre = "";
        protected string aPaterno = "";
        protected string aMaterno = "";
        protected int edad = 0;

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public string APaterno {
            get { return aPaterno; }
            set { aPaterno = value; }
        }

        public string AMaterno {
            get { return aMaterno; }
            set { aMaterno = value; }
        }

        public int Edad {
            get { return edad; }
            set { edad = value; }
        }
    }
}