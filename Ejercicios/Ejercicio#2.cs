//--> Ejercicio 2 – Herencia y sobrescritura <--

public class Empleado
{
    protected string? _Nombre;
    protected double _Salario;
    public Empleado(string? Nombre, double Salario)
    {
        _Nombre = Nombre;
        _Salario = Salario;
    }
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {_Nombre}\nSalario: {_Salario}");
    }

}

public class Gerente : Empleado
{
    private int _Bonificacion;

    public Gerente(string? Nombre, double Salario, int Bonificacion) : base(Nombre, Salario)
    {
        _Bonificacion = Bonificacion;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {_Nombre}\nSalario: {_Salario}\nBonificacion: {_Bonificacion}");
    }
}

public class Programador : Empleado
{
    private string? _Lenguaje;

    public Programador(string? Nombre, double Salario, string? Lenguaje) : base(Nombre, Salario)
    {
        _Lenguaje = Lenguaje;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {_Nombre}\nSalario: {_Salario}\nBonificacion: {_Lenguaje}");
    }
}

public class Program2
{
    static void Main(string[] args)
    {
        Empleado emp1 = new Empleado("Andres", 120000);
        Gerente ger1 = new Gerente("Jesenia", 500000, 50000);
        Programador pro1 = new Programador("Andres", 1000000, "C#");

        emp1.MostrarInformacion();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        ger1.MostrarInformacion();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        pro1.MostrarInformacion();
    }
}