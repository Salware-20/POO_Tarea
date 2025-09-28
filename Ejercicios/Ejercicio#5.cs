//--> Ejercicio 5 – Interfaces y Polimorfismo <--

public interface IAnimal
{
    // Creamos una interfaz donde definimos una variable con el nombre y una accion (funcion)
    string Nombre { get; set; }
    void HacerSonido();
}

public class Perro : IAnimal
{
    public string Nombre { get; set;}
    // Se crea un constructor para poder colocar el nombre dentro de la clase al ser instanciada
    public Perro(string nombre)
    {
        Nombre = nombre;
    }

    public void HacerSonido()
    {
        Console.WriteLine("Gua GUA");
    }
}

public class Gato : IAnimal
{
    public string Nombre { get; set; }

    public Gato(string nombre)
    {
        Nombre = nombre;
    }
    // Ahora se modifica la funcion hacer sonido para que esta realice lo que necesitamos para cada clase en espesifico
    public void HacerSonido()
    {
        Console.WriteLine("Miau Miau");
    }
}

public class Program5
{
    static void Main(string[] args)
    {
        List<IAnimal> animales = new List<IAnimal>();

        animales.Add(new Perro("Princesa"));
        animales.Add(new Perro("Tobby"));
        animales.Add(new Perro("Caya"));
        animales.Add(new Perro("Pulgas"));

        animales.Add(new Gato("Ceniza"));
        animales.Add(new Gato("Ruperto"));
        animales.Add(new Gato("El mal encarnado"));
        animales.Add(new Gato("Snow"));

        foreach (IAnimal animal in animales)
        {
            Console.WriteLine($"Nombre: {animal.Nombre}");
            Console.Write($"Sonido: ");
            animal.HacerSonido();
        }
    }
}