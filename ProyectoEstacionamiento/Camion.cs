using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento
{
    internal class Camion : Vehiculo 
    {
        public Camion(string marca, string modelo, string color, string tipoVehiculo, string matricula, DateTime horaIngreso) : base(marca, modelo, color, tipoVehiculo, matricula, horaIngreso)
        {

        }
        public override void CrearVehiculo(string Camion, List<Vehiculo> list)
        {   
            Console.Clear();
            base.CrearVehiculo(Camion, list);
        }
    }
}
