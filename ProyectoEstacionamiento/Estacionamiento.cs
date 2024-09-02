using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstacionamiento
{
    internal class Estacionamiento
    {
        public Auto Auto { get; set; }
        public Camion Camion { get; set; }
        public Motocicleta Motocicleta { get; set; }
        public Tarjeta Tarjeta { get; set; }

        public Estacionamiento(Auto auto, Camion camion, Motocicleta motocicleta, Tarjeta tarjeta)
        {
            this.Auto = auto;
            this.Camion = camion;
            this.Motocicleta = motocicleta;
            this.Tarjeta = tarjeta;
        }
        TimeSpan tiempoEstacionado;
        public void OcuparEspacion(List<Vehiculo> list, int Capacidad)
        {
            var continuarMenuDos = true;
            
            do
            {
                if (list.Count != Capacidad)
                {
                    Console.Clear();
                    Console.WriteLine("Que tipo de vehiculo deseas registrar\n");
                    Console.WriteLine("1. Auto");
                    Console.WriteLine("2. Camion");
                    Console.WriteLine("3. Motocicleta");
                    Console.WriteLine("4. Salir\n");
                    Console.WriteLine("selecciona una opcion");
                    var opcionTipo = int.Parse(Console.ReadLine());
                    switch (opcionTipo)
                    {
                        case 1:

                            string auto = "Auto";
                            Auto.CrearVehiculo(auto, list);
                            break;
                        case 2:
                            string camion = "Camion";
                            Auto.CrearVehiculo(camion, list);
                            break;
                        case 3:
                            string motocicleta = "Motocicleta";
                            Auto.CrearVehiculo(motocicleta, list);
                            break;
                        case 4:
                            continuarMenuDos = false;
                            break;
                    }
                }
                else 
                {
                 continuarMenuDos = false;
                }
            } while (continuarMenuDos);


        }
        public int CalcularTiempo(double tiempo) 
        {
            int costoEstacionamiento = 0;
            int valorEntero = (int)Math.Ceiling(tiempo);
            if (valorEntero < 30) costoEstacionamiento = 5;
            else if(valorEntero > 30 && valorEntero < 60) costoEstacionamiento = 10;
            else if (valorEntero > 60 && valorEntero < 90) costoEstacionamiento = 15;
            else if (valorEntero > 90 && valorEntero < 120) costoEstacionamiento = 20;
            else if (valorEntero > 150 && valorEntero < 180) costoEstacionamiento = 25;
            else if (valorEntero > 180 && valorEntero < 210) costoEstacionamiento = 30;
            else if (valorEntero > 210 && valorEntero < 240) costoEstacionamiento = 35;
            else if (valorEntero > 240) costoEstacionamiento = 40;
            return costoEstacionamiento;
        }
        public void RetirarVehiculo(List<Vehiculo> list, List<Tarjeta>listT)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero de placa del vehiculo que deseas retirar");
            var buscarPlaca = Console.ReadLine();
            foreach (var p in list) 
            {
                if (p.Matricula == buscarPlaca)
                {
                    tiempoEstacionado = DateTime.Now - p.HoraIngreso;
                    double tiempoEnMinutos = tiempoEstacionado.TotalMinutes;
                    var calcularCosto = CalcularTiempo(tiempoEnMinutos);

                    Console.WriteLine($"El costo del estacionaiento es de: Q.{calcularCosto}.00");
                    Console.WriteLine("Con que metodo deseas pagar");
                    Console.WriteLine("1. Pago en Efectivo");
                    Console.WriteLine("2. Pago con Tarjeta");
                    var pagoCon = int.Parse(Console.ReadLine());

                    if (pagoCon == 1)
                    {
                        PagarConEfectivo(calcularCosto);
                        list.Remove(p);
                        Console.WriteLine("Vehiculo retirado");
                        Console.ReadKey();
                        break;
                    } else if (pagoCon == 2)
                    {
                        Tarjeta.pagarTarjeta(calcularCosto,listT);
                        list.Remove(p);
                        Console.WriteLine("Vehiculo retirado");
                        Console.ReadKey();
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Metodo aceptado");
                        break;
                    }
                   

                }
                else 
                 {
                    Console.WriteLine("No se encontro el vehiculo");
                    break;
                 }
            }
            
        }
        public void PagarConEfectivo(double tiempo) 
        {
  
            int montoTotal = CalcularTiempo(tiempo);

            Console.Write("Ingrese el monto de pago: ");
            int montoRecibido = int.Parse(Console.ReadLine());

            int cambio = montoRecibido - montoTotal;

            if (cambio < 0)
            {
                Console.WriteLine("Monto recibido es insuficiente.");
                return;
            }

            Console.WriteLine($"Cambio a devolver: {cambio:C}");


            int[] denominaciones = { 200, 100, 50, 20, 10, 5, 1 };
            int[] cantidadBilletes = new int[denominaciones.Length];


            for (int i = 0; i < denominaciones.Length; i++)
            {
                cantidadBilletes[i] = (int)(cambio / denominaciones[i]);
                cambio %= denominaciones[i];
            }


            for (int i = 0; i < denominaciones.Length; i++)
            {
                if (cantidadBilletes[i] > 0)
                {
                    Console.WriteLine($"{cantidadBilletes[i]} billete(s) de ${denominaciones[i]}");
                }
            }
        }
    }
}
