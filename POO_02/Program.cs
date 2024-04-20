// ¿VOS CUANTAS PRIMAVERAS TENES?

using ClassLibrary1;

namespace POO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;



            while (contador < 3)
            {
                Console.WriteLine("Ingrese su nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su fecha de nacimiento (dd/mm/yyyy): ");
                string fechaNacimientoStr = Console.ReadLine();
                DateTime fechaNacimiento;
                if (!DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento))
                {
                    Console.WriteLine("Verifique el formato ingresado. De ser: dd/MM/yyyy.");
                }

                Console.WriteLine("Ingrese su DNI: ");
                int dni;
                if (!int.TryParse(Console.ReadLine(), out dni))
                {
                    Console.WriteLine("El DNI debe ser un número entero.");
                }

                Persona persona1 = new Persona(nombre, fechaNacimiento, dni);
                Console.WriteLine(persona1.Mostrar());
                Console.WriteLine(persona1.EsMayorDeEdad());

                contador += 1;
            }


        }
    }
}
