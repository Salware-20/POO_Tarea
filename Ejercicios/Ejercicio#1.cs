
//--> Ejercicio 1 – Encapsulamiento <--

public class CuentaBancaria
{
    private double _saldo;

    public void DepositarDinero(double monto)
    {
        if (monto > 0) { _saldo += monto; Console.WriteLine("Deposito exitoso!"); }
        //Esta funcion de aca se encarga de verificar que el monto no sea 0 y si es asi entonces realiza el deposito
    }

    public void RetirarDinero(double monto)
    {
        if (monto <= _saldo) { _saldo -= monto; Console.WriteLine("Retiro exitoso!"); }
        else { Console.WriteLine($"Lo sentimos\nSaldo actual: {_saldo}"); }
        // Lo mismo que depositar pero esta vez con el retiro de verificando que el usuario no retire más de lo que tiene en su cuenta 
    }

    public double VerSaldo()
    {
        return _saldo;
        // muetras el dinero que tiene y ya
    }
}

//public class Program1
//{
//    static void Main()
//    {
//        CuentaBancaria Cuenta = new CuentaBancaria();
//        // Cree un menu donde usando while logro que el sistema no se caiga aun con errores y diferentes problemas que pueda presentar
//        while (true)
//        {
//            try
//            {
//                Console.WriteLine("Que deseas hacer: \n1] Depositar\n2] Retirar\n3] Ver saldo\n4] Cerrar");
//                string? input = Console.ReadLine();
//                int opcion = Convert.ToInt32(input);
//                if (opcion == 1)
//                {
//                    Console.Write("Cuanto deseas depositar: ");
//                    string? input_ = Console.ReadLine();
//                    double monto = Convert.ToDouble(input_);
//                    Cuenta.DepositarDinero(monto);
//                }
//                else if (opcion == 2) 
//                {
//                    Console.Write("Cuanto deseas retirar: ");
//                    string? input_ = Console.ReadLine();
//                    double monto = Convert.ToDouble(input_);
//                    Cuenta.RetirarDinero(monto);
//                }
//                else if (opcion == 3)
//                {
//                    Console.WriteLine(Cuenta.VerSaldo());
//                }
//                else { Console.WriteLine("Nos vemos..."); break; }
//            }
//            catch (Exception ex) { Console.WriteLine($"ERROR: {ex.Message}"); }
//        }
//    }
//}
