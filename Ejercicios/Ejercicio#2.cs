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

//public class program2
//{
//    static void main()
//    {
//        // imprimimos todo los datos de los usuarios
//        empleado empleado1 = new empleado();
//        empleado1.mostrarinformacion();
//        gerente gerente1 = new gerente();
//        gerente1.mostrarinformacion();
//        programador programador1 = new programador();
//        programador1.mostrarinformacion();
//        console.readline();
//    }
//}

