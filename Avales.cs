namespace SistemaRegistroCandidatosPrestamo;

public class Avales
{
    private string Nombre  { get; set; }
    private string ApellidoPaterno { get; set; }
    private string ApellidoMaterno { get; set; }
//contructur 
    public Avales ( string Nombre,   string ApellidoPaterno,string ApellidoMaterno )
    {   
        this.Nombre = Nombre;
        this.ApellidoPaterno = ApellidoPaterno;
        this.ApellidoMaterno= ApellidoMaterno;
    }
    //mostrar datos de alval
    public void MostrarAval()
    {
        Console.WriteLine($"Nombre: {this.Nombre}");
        Console.WriteLine($"Nombre: {this.ApellidoPaterno}");
        Console.WriteLine($"Nombre: {this.ApellidoMaterno}");
    }

}
