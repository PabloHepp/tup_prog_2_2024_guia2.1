using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1RegistroAutomotor
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular vehiculos = new DepartamentoVehicular();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegPersona nuevo = new RegPersona();
            
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(nuevo.tbDNI.Text);
                string nombre = nuevo.tbNombre.Text;
                Persona nueva = new Persona(dni, nombre);

                RegistroVehiculo unregistro;
                unregistro = vehiculos.RegistrarVehiculo(nueva);

                listBPersonas.Items.Add(nueva.DetallePersona());
               
            }


        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {
            listBRegistros.Items.Clear();

            for(int reg = 0; reg < vehiculos.CantidadRegistros; reg++)
            {
                RegistroVehiculo ver = vehiculos.VerRegistro(reg);
                listBRegistros.Items.Add(ver.VerDetalles());
            }

        }
    }
}
