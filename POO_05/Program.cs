// PRUEBA DE GEOMETRIA

using Geometria;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace POO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Punto vertice1 = new Punto(0, 0);
            Punto vertice3 = new Punto(3, 4);
            Rectangulo rectangulo = new Rectangulo(vertice1, vertice3);

            MostrarDatosRectangulo(rectangulo);
        }

        public static void MostrarDatosRectangulo(Rectangulo rect)
        {
            Console.WriteLine($"Vértice 1: ({rect.Vertice1.X}, {rect.Vertice1.Y})");
            Console.WriteLine($"Vértice 2: ({rect.Vertice2.X}, {rect.Vertice2.Y})");
            Console.WriteLine($"Vértice 3: ({rect.Vertice3.X}, {rect.Vertice3.Y})");
            Console.WriteLine($"Vértice 4: ({rect.Vertice4.X}, {rect.Vertice4.Y})");
            Console.WriteLine($"Área: {rect.Area}");
            Console.WriteLine($"Perímetro: {rect.Perimetro}");
        }
    }
}
