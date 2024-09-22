using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1RegistroAutomotor
{
    internal class DepartamentoVehicular
    {
        private ArrayList Registros = new ArrayList();

        Random patente = new Random();
        int nroSerie;
        int nroRegistro = 0;

        public int CantidadRegistros { get { return Registros.Count; } }

        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            string patente = GenerarPatente();
            int serie = nroSerie++;

            RegistroVehiculo nuevo = new RegistroVehiculo(patente, serie, propietario);
            Registros.Add(nuevo);

            return nuevo;

        }

        private string GenerarPatente()
        {
            int nroCarac = patente.Next(100);

            char C1 = (char)patente.Next((int)'A', (int)'Z' + 1);
            char C2 = (char)patente.Next((int)'A', (int)'Z' + 1);

            string nuevapatente = $"{C1}{C2}{nroRegistro++:000}";

            return nuevapatente;
        }
        
        public RegistroVehiculo VerRegistro(int reg)
        {
            if(reg>=0 && reg <= CantidadRegistros)
            {
                return Registros[reg] as RegistroVehiculo;
            }

            return null;
        }
     


    }
}
