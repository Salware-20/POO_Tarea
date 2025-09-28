//--> Ejercicio 3 – Abstracción con Clases Abstractas <--

public abstract class Figura
{
    public abstract double CalcularArea();
}

public class Cuadrado : Figura
{
    private double _lado;
    public Cuadrado(double lado)
    {
        this._lado = lado;
    }
    public override double CalcularArea()
    {
        return _lado * _lado;
    }
}

public class Triangulo : Figura
{
    private double _base;
    private double _altura;

    public Triangulo(double base1, double altura)
    {
        this._base = base1;
        this._altura = altura;
    }

    public override double CalcularArea()
    {
        return (_base * _altura) / 2;
    }
}

public class Program4
{
    static void Main(string[] args)
    {
        Cuadrado cua = new Cuadrado(5);
        Console.WriteLine(cua.CalcularArea());
        Triangulo tri = new Triangulo(5,8);
        Console.WriteLine(tri.CalcularArea());
    }
}