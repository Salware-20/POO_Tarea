
//--> Ejercicio 1 – Encapsulamiento <--

public class CuentaBancaria
{
    private double _saldo;

    public void DepositarDinero(double monto)
    {
        if (monto > 0) { _saldo += monto; Console.WriteLine("Deposito exitoso!"); }
        
    }

    public void RetirarDinero(double monto)
    {
        if (monto <= _saldo) { _saldo -= monto; Console.WriteLine("Retiro exitoso!"); }
        else { Console.WriteLine($"Lo sentimos\nSaldo actual: {_saldo}"); }
    }

    public double VerSaldo()
    {
        return _saldo;
    }
}

public class Program
{
    static void Main()
    {
        CuentaBancaria Cuenta = new CuentaBancaria();
        while (true)
        {
            try
            {
                Console.WriteLine("Que deseas hacer: \n1] Depositar\n2] Retirar\n3] Ver saldo\n4] Cerrar");
                string? input = Console.ReadLine();
                int opcion = Convert.ToInt32(input);
                if (opcion == 1)
                {
                    Console.Write("Cuanto deseas depositar: ");
                    string? input_ = Console.ReadLine();
                    double monto = Convert.ToDouble(input_);
                    Cuenta.DepositarDinero(monto);
                }
                else if (opcion == 2) 
                {
                    Console.Write("Cuanto deseas retirar: ");
                    string? input_ = Console.ReadLine();
                    double monto = Convert.ToDouble(input_);
                    Cuenta.RetirarDinero(monto);
                }
                else if (opcion == 3)
                {
                    Console.WriteLine(Cuenta.VerSaldo());
                }
                else { Console.WriteLine("Nos vemos..."); break; }
            }
            catch (Exception ex) { Console.WriteLine($"ERROR: {ex.Message}"); }
        }
    }
}
