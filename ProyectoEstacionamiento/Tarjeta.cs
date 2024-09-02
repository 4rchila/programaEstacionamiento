using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento
{
    public class Tarjeta
    {
        public string NumeroTarjeta { get; set; }
        public string NombreTitular { get; set; }
        public string Fecha { get; set; }
        protected int CVV { get; set; }
        public Tarjeta(string numeroTarjeta, string nombreTitular, string fecha, int CVV)
        {
            this.NumeroTarjeta = numeroTarjeta;
            this.NombreTitular = nombreTitular;
            this.Fecha = fecha;
            this.CVV = CVV;
        }

        public void pagarTarjeta(double monto, List<Tarjeta>list) 
        {
            Console.Clear();
            Console.WriteLine($"Ingresa el numero de la tarjeta");
            var numeroTarjeta = Console.ReadLine();
            Console.WriteLine($"Ingresa el nombre titular de la tarjeta");
            var nombreTitular = Console.ReadLine();
            Console.WriteLine($"Ingresa la fecha de vencimiento: MM/YY");
            var fecha = Console.ReadLine();
            Console.WriteLine($"Ingresa el CVV de la tarjeta");
            var CVV = int.Parse(Console.ReadLine());
            Console.WriteLine("La tarjeta no a se a guardada");
            

            //Esta seria una opción para guardar la tarjeta la dejo por si fuese algo que talvez si hubiese ido

            //Console.WriteLine("Deseas guardar la tarjeta, S o N");
            //var opcionGuardar =  Console.ReadLine().ToLower();
            //if (opcionGuardar == "s")
            //{
            //list.Add(new Tarjeta(numeroTarjeta,nombreTitular,fecha,CVV));

            //}
            //else if(opcionGuardar == "n")
            //{
            //Console.WriteLine("La tarjeta no a se a guardada");
            //}
        }
    }
}
