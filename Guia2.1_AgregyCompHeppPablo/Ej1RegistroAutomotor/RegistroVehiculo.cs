using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1RegistroAutomotor
{
    internal class RegistroVehiculo
    {
        public string Patente { get; private set; }
        public int Serie  { get; private set; }
        public Persona Propietario { get; private set; }

        public RegistroVehiculo(string patente, int serie, Persona prop)
        {
            Patente = patente;
            Serie = serie;
            Propietario = prop;
        }

        public string VerDetalles()
        {
            return $"Patente: {Patente}, Numero de serie: {Serie}, Propietario:{Propietario}";
        }

    }
}
