using System;
namespace SistemaRegistroCandidatosPrestamo;

public class Persona
{ //variables 
    private string Nombre { get; set; }
    private string ApellidoPaterno { get; set; }
    private string ApellidoMaterno { get; set; }
    private string Correo { get; set; }
    private string Telefono { get; set; }
    private string LugarRecidencia { get; set; }
    private int Edad { get; set; }
    private double IngresoSolicitante { get; set; }
// contructur 
    public Persona(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Correo,
    string Telefono, string LugarRecidencia, int Edad, double IngresoSolicitante)
    {

        this.Nombre = Nombre;
        this.ApellidoPaterno = ApellidoPaterno;
        this.ApellidoMaterno = ApellidoMaterno;
        this.Correo = Correo;
        this.Telefono = Telefono;
        this.LugarRecidencia = LugarRecidencia;
        this.Edad = Edad;
        this.IngresoSolicitante = IngresoSolicitante;
    }

// metodos de captura de datos 
    public void Solicitud()
    {
        Console.WriteLine($"Nombre (s): {this.Nombre}");
        Console.WriteLine($"Apellido peterno: {this.ApellidoPaterno}");
        Console.WriteLine($"Apellido Materno: {this.ApellidoMaterno}");
        Console.WriteLine($"Correo: {this.Correo}");
        Console.WriteLine($"Telefono: {this.Telefono}");
        Console.WriteLine($"Lugar de recidencia: {this.LugarRecidencia}");
        if (this.Edad >= 18 && this.Edad <= 64)
        {
            if (this.IngresoSolicitante >= 256 && this.IngresoSolicitante < 24545)
            {
                Console.WriteLine($"Edad: {this.Edad}");
                Console.WriteLine($"Ingrese su Ingreso: {this.IngresoSolicitante}");
                if (Edad >= 18 && Edad <= 64)
                    {
                        Console.WriteLine("Ingrese Nombre ");
                        string Nombre1 = Console.ReadLine();
                        NombreException.NombreE(Nombre);
                        Console.WriteLine("Ingrese Apellido Paterno ");
                        string ApellidoPa = Console.ReadLine();
                        ApellidoPaternoException.ApellidoPaterno(ApellidoPaterno);
                        Console.WriteLine("ingrese Apellido Materno");
                        string ApellidoMa = Console.ReadLine();
                        Avales avales = new Avales( Nombre1, ApellidoPa, ApellidoMa );
                    }
            }
            else
            {
                Console.WriteLine("No autorisado ");
            }

        }
        else
        {
            Console.WriteLine("Ingrese los nombres de la Alvasea");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Ingrese su Ingreso: {this.IngresoSolicitante}");
        }
    }

    public string getNombre()
    {
        return this.Nombre;
    }
    public string setNombre(string nombre)
    {
        return this.Nombre = nombre;
    }


}


