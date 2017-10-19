using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Test.Data
{
    public class Alumno: Persona
    {
        private string matricula = "";
        private string grado = "";

        public string Matricula {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Grado {
            get { return grado; }
            set { grado = value; }
        }
    }
}