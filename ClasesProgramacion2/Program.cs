// VALIDADOR DE RANGOS
using ClassLibrary1;

namespace Estaticos01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosEnteros = new List<int>();

            do
            {
                Console.WriteLine("Ingrese un número entre -100 y 100: ");
                string numero_ingresado_str = Console.ReadLine();
                int numero_ingresado = int.Parse(numero_ingresado_str);
                bool respuestaValidada = Validador.Validar(numero_ingresado, -100, 100);

                if (respuestaValidada == true)
                {
                    numerosEnteros.Add(numero_ingresado);
                }
                else
                {
                    Console.WriteLine("Verifique el dato ingresado. Ingrese un nuevo número entre -100 y 100: ");
                }

            } while (numerosEnteros.Count < 10);



            foreach (int numero in numerosEnteros)
            {
                Console.WriteLine(numero);
            }

            int minNumber = Validador.FindMin(numerosEnteros);
            Console.WriteLine("El menor número ingresado es: " + minNumber.ToString());

            int maxNumber = Validador.FindMax(numerosEnteros);
            Console.WriteLine("El mayor número ingresado es: " + maxNumber.ToString());

            decimal promedio = Validador.FindPromedio(numerosEnteros);
            Console.WriteLine("El promedio de los números ingresados es: " + promedio.ToString());


        }
    }
}
