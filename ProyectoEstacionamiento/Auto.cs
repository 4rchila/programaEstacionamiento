using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento
{
    internal class Auto: Vehiculo
    {
        public Auto(string marca, string modelo, string color, string tipoVehiculo, string matricula, DateTime horaIngresar) : base(marca, modelo, color, tipoVehiculo, matricula,horaIngresar)
        {

        }
        public override void CrearVehiculo(string Carro, List<Vehiculo> list)
        {
            Console.Clear();
            base.CrearVehiculo(Carro, list);
        }
    }
}
