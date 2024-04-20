// EJEMPLO UNIVERSAL

using ClassLibrary1;


namespace POO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Ana", "Fernandez", 123);
            Estudiante estudiante2 = new Estudiante("Mario", "Perez", 456);
            Estudiante estudiante3 = new Estudiante("Claudia", "Laprida",789);

            estudiante1.SetNotaPrimerParcial = 3;
            estudiante1.SetNotaSegundoParcial = 8;

            estudiante2.SetNotaPrimerParcial = 5;
            estudiante2.SetNotaSegundoParcial = 7;

            estudiante3.SetNotaPrimerParcial = 7;
            estudiante3.SetNotaSegundoParcial = 9;
             
            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());

        }
    }
}
