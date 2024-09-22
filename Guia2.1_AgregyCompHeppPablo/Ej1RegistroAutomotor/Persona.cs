using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ej1RegistroAutomotor
{
    internal class Persona
    {
        public int dni;
        public string nombre;

        public Persona(int dni, string nom)
        {
            DNI = dni;
            nombre = nom;   
        }

        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }


    }
}
