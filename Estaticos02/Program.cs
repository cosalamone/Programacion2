// ¿DESEA CONTINUAR? + ej 1 de estaticos01
using ClassLibrary1;
using System.Drawing;

namespace Estaticos02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool continuar = true;
           int acumulador = 0;
           while (continuar) { // do while 
                Console.WriteLine("Por favor, ingrese un número entero: ");
                string numero_ingresado_str = Console.ReadLine();
                int numero_ingresado = int.Parse(numero_ingresado_str); //int.tryParse -> bool numberOk = int.TryParse(input, out number); devuelve un bool 

                acumulador += numero_ingresado;

                Console.WriteLine("¿Desea continuar? (S/N): ");
                string respuestaContinuar = Console.ReadLine();
                bool respuestaBoolean = Validador.ValidarRespuesta(respuestaContinuar);

                if (!respuestaBoolean) {
                    continuar = false;
                    Console.WriteLine("Usted ingresó un total de: " + acumulador);
                }
            }
        }
    }
}
