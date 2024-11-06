using System.Diagnostics.CodeAnalysis;
using SistemaRegistroCandidatosPrestamo;

public class Program
{

    public static void Main(String[] args)
    {  // variable creando una lista 
        int op = 0;
        List<Persona> personas1 = new List<Persona>();
        // menu principal 
        while (op != 3)
        {

            Console.WriteLine("Eliga una opcion ");
            Console.WriteLine("Solicitud de prestamo N: 1");
            Console.WriteLine("Mostrar las Solicitud N: 2");
            Console.WriteLine("Salir N: 3");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("Solicitud de prestamo");
                try
                {
                    Console.WriteLine("Ingrese Nombre ");
                    string Nombre = Console.ReadLine();
                    NombreException.NombreE(Nombre);
                    Console.WriteLine("Ingrese Apellido Paterno ");
                    string ApellidoPaterno = Console.ReadLine();
                    ApellidoPaternoException.ApellidoPaterno(ApellidoPaterno);
                    Console.WriteLine("ingrese Apellido Materno");
                    string ApellidoMaterno = Console.ReadLine();
                    Console.WriteLine("Ingrese su Correo");
                    string Correo = Console.ReadLine();
                    Console.WriteLine("Ingrese Telefono");
                    string Telefono = Console.ReadLine();
                    Console.WriteLine("Ingrese su lugar de recidencia");
                    string LugarRecidencia = Console.ReadLine();
                    Console.WriteLine("Ingrese su edad");
                    int Edad = int.Parse(Console.ReadLine());                    
                    Console.WriteLine("Ingresa su ingreso en salirio minimo");
                    double IngresoSolicitante = int.Parse(Console.ReadLine());                   
                    Persona personas = new Persona(Nombre, ApellidoPaterno, ApellidoMaterno, Correo, Telefono, LugarRecidencia, Edad, IngresoSolicitante);
                    personas1.Add(personas);
                }
                catch (NombreException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ApellidoPaternoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ApellidoMaternoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (System.FormatException)
                {
                    throw new Exception("A ingresado una letra en su edad ");
                }

            }
            else if (op == 2)
            {

                Console.WriteLine("Motrar Solicitudes");
                foreach (var item in personas1)
                {
                    item.Solicitud();
                }
            }
            else
            {
                try
                {
                    op = 3;
                }
                catch (System.FormatException ex)
                {
                    throw new Exception($"Saliendo del Sistema: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Saliendo del sistema com finally");
                }
            }
        }
    }
}
