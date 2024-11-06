using System.Globalization;

namespace SistemaRegistroCandidatosPrestamo;


public class NombreException : Exception
{
    public NombreException() : base("El nombre completo no debe contener números.") { }

    public NombreException(string message) : base(message) { }

    public NombreException(string message, Exception inner) : base(message, inner) { }

    public static void NombreE(string nombre)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(nombre, @"\d"))
            throw new NombreException();
    }
}

public class ApellidoPaternoException : Exception
{
    public ApellidoPaternoException() : base("El apellido paterno no debe contener números.") { }

    public ApellidoPaternoException(string message) : base(message) { }

    public ApellidoPaternoException(string message, Exception inner) : base(message, inner) { }

    public static void ApellidoPaterno(string Apellido)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(Apellido, @"\d"))
            throw new ApellidoPaternoException();
    }
}

public class ApellidoMaternoException : Exception
{
    public ApellidoMaternoException() : base("El apellido materno no debe contener números.") { }

    public ApellidoMaternoException(string message) : base(message) { }

    public ApellidoMaternoException(string message, Exception inner) : base(message, inner) { }

    public static void ApellidoMaterno(string Apellido)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(Apellido, @"\d"))
            throw new ApellidoMaternoException();
    }
}

public class TelefonoException : Exception
{
    public TelefonoException() : base("El correo eletronico no esta cpmpleto.") { }

    public TelefonoException(string message) : base(message) { }

    public TelefonoException(string message, Exception inner) : base(message, inner) { }

    public static void Telefono(string Telefono)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(Telefono, @"\k<telefono>"))
            throw new TelefonoException();
    }
}

public class CorreoException : Exception
{
    public CorreoException() : base("El correo eletronico no esta cpmpleto.") { }

    public CorreoException(string message) : base(message) { }

    public CorreoException(string message, Exception inner) : base(message, inner) { }

    public static void Correo(string Correo)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(Correo, @".com"))
            throw new CorreoException();
    }
}

public class LugarRecidenciaException : Exception
{
    public LugarRecidenciaException() : base("El lugar de recidencia esta mal .") { }

    public LugarRecidenciaException(string message) : base(message) { }

    public LugarRecidenciaException(string message, Exception inner) : base(message, inner) { }

    public static void LugarRecidencia(string LugarRecidencia)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(LugarRecidencia, @""))
            throw new LugarRecidenciaException();
    }
}


