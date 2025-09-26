//--> Ejercicio 2 – Herencia y sobrescritura <--

public class Empleado
{
    // Se crea la clase madre que es el empleado
    public string? _nombre = "Andres";
    public double _salario = 500;

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {_nombre}");
        Console.WriteLine($"Salario: {_salario}");
    }
}

public class Gerente : Empleado
{
    // Con esta forma de poner geren : emple le estamos diciendo que gerente es hija de empleado
    private int _bonificacion = 500;

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {_nombre}");
        Console.WriteLine($"Salario: {_salario}");
        Console.WriteLine($"Bonificacion: {_bonificacion}");
    }
}

public class Programador : Empleado
{
    private string _lenguaje = "C#";

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {_nombre}");
        Console.WriteLine($"Salario: {_salario}");
        Console.WriteLine($"Lenguaje: {_lenguaje}");
    }
}

public class Program
{
    static void Main()
    {
        // Imprimimos todo los datos de los usuarios
        Empleado empleado1 = new Empleado();
        empleado1.MostrarInformacion();
        Gerente gerente1 = new Gerente();
        gerente1.MostrarInformacion();
        Programador programador1 = new Programador();
        programador1.MostrarInformacion();
        Console.ReadLine();
    }
}