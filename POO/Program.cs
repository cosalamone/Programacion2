using ClassLibrary1;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int cantidadInicial = 0;
            int cantidad = 0;


            Console.WriteLine("Para iniciar indique el nombre del titular: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Indique el deposito inicial de la cuenta: ");
            string input = Console.ReadLine();
            cantidadInicial = int.Parse(input); // Modificar los Parse por int.TryParse
            Cuenta cuenta1 = new Cuenta(titular, cantidadInicial);

            while (continuar)
            {

                Console.WriteLine("Desea ingresar dinero o extraer dinero?(I/E): ");
                string tipoMovimiento = Console.ReadLine();

                if (tipoMovimiento == "I" || tipoMovimiento == "E")
                {
                    Console.WriteLine("Por favor, indique el monto: ");
                    string cantidadStr = Console.ReadLine();
                    cantidad = int.Parse(cantidadStr);
                }

                if (tipoMovimiento == "I")
                {
                    cuenta1.Ingresar(cantidad);
                }
                else if (tipoMovimiento == "E")
                {
                    cuenta1.Retirar(cantidad);
                }
                else
                {
                    continuar = false;
                }

                int montoFinal = cuenta1.GetCantidad();
                Console.WriteLine("Su cuenta queda con un monto de: " + montoFinal);

            }
        }
    }
}
