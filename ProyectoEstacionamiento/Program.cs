using ProyectoEstacionamiento;

bool Continuar = true;

Auto AutoInicio = new Auto("Porche","911gt","Negro","auto","G3rl0",DateTime.Now);
Motocicleta motocicletaInicio = new Motocicleta("", "", "", "", "", DateTime.Now);
Camion camionInicio = new Camion("", "", "", "", "", DateTime.Now);
Tarjeta tarjetaInicio = new Tarjeta("", "", "", 0);
Estacionamiento nuevoParqueo = new Estacionamiento(AutoInicio, camionInicio, motocicletaInicio,tarjetaInicio);
List<Vehiculo>Parqueo= new List<Vehiculo>();
List<Tarjeta> Tarjetas = new List<Tarjeta>();

Console.WriteLine("Escribe la cantidad de espacios que se encuentra libres en el parqueo");
int espaciosParqueo = int.Parse(Console.ReadLine());

do 
{
    try {
        Console.Clear();
        Console.WriteLine("--MENU--");
        Console.WriteLine("1. REGISTRAR UN NUEVO VEHICULO");
        Console.WriteLine("2. RETIRAR VEHICULO");
        Console.WriteLine("3. SALIR\n");
        Console.WriteLine("Escribe la opcion que deseas ejecutar");

        var menuOpcion = int.Parse(Console.ReadLine());
        switch (menuOpcion) 
        {
            case 1:
                if (Parqueo.Count == espaciosParqueo)
                {
                    Console.WriteLine("El parqueo se encuntra lleno");
                   
                }
                else 
                {
                    nuevoParqueo.OcuparEspacion(Parqueo, espaciosParqueo);
                }
                Console.ReadKey();
                break;
            case 2:
                if (Parqueo.Count == 0)
                {
                    Console.WriteLine("No se encuentran vehiculos para retirar");
                }
                else
                {
                    nuevoParqueo.RetirarVehiculo(Parqueo, Tarjetas);
                }
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("Deseas salir S o N?");
                var salirOpcion = Console.ReadLine().ToLower();
                if (salirOpcion == "s")
                {
                    Continuar = false;
                } else
                {
                    Continuar = true;
                }
                break;
        }

    }
    catch(FormatException ex) 
    {
      Console.WriteLine("Formato Incorrecto"+ex.Message);
        Console.ReadKey();
    }
}while (Continuar);
