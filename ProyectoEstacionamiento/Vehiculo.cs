using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set;}
        public string Color { get; set; }
        public string TipoVehiculo { get; set; }
        public string Matricula { get; set; }
        public DateTime HoraIngreso { get; set; }
        public Vehiculo(string marca, string modelo, string color, string tipoVehiculo, string matricula, DateTime horaIngreso)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.TipoVehiculo = tipoVehiculo;
            this.Matricula = matricula;
            this.HoraIngreso = horaIngreso;

        }

        public Vehiculo(string marca, string modelo, string color, string tipoVehiculo, string matricula)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            TipoVehiculo = tipoVehiculo;
            Matricula = matricula;
        }

        public virtual void CrearVehiculo(string tipo, List<Vehiculo>list) 
        {
            Console.WriteLine("Escribe la marca del vehiculo");
            var marcaVehiculo = Console.ReadLine();
            Console.WriteLine("Escribe el modelo del vehiculo");
            var modeloVehiculo = Console.ReadLine();
            Console.WriteLine("Escribe el color del vehiculo");
            var colorVehiculo = Console.ReadLine();
            Console.WriteLine("Escribe la matricula");
            var matriculaVehiculo = Console.ReadLine();
            DateTime horaIngreso = DateTime.Now;

            list.Add(new Vehiculo(marcaVehiculo,modeloVehiculo,colorVehiculo,tipo,matriculaVehiculo,horaIngreso)) ;

        }
    }

}
