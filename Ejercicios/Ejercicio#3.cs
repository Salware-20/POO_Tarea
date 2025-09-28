//--> Ejercicio 3 – Polimorfismo por Sobrecarga <--

public class Calculadora
{
    //Realiza las funcion basica de sumar solo que esta usa la misma funcion pero con diferentes parametros
    public int Suma(int a, int b)
    {
        return a + b;
    }
    public int Suma(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Suma(double a, double b)
    {
        return a + b;
    }
}

public class Program3
{
    static void Main(string[] args)
    {
        Calculadora Calc = new Calculadora();

        Console.WriteLine(Calc.Suma(10, 11));
        Console.WriteLine(Calc.Suma(10, 11, 21));
        Console.WriteLine(Calc.Suma(10.10, 11.11));
    }
}