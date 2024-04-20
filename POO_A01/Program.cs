// A01 - Vienen con sistema de auto-navegación

using ClassLibrary03;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conductor[] conductores = new Conductor[3];

            conductores[0] = new Conductor("Carlos");
            conductores[0].RegistrarViaje(new int[] { 120, 233, 145, 325, 90, 123, 0 });

            conductores[1] = new Conductor("Maria");
            conductores[1].RegistrarViaje(new int[] { 234, 0, 0, 356, 222, 89, 152 });

            conductores[2] = new Conductor("Susana");
            conductores[2].RegistrarViaje(new int[] { 154, 254, 312, 78, 0, 198, 478 });

            Console.WriteLine("El conductor que hizo más km en esa semana.", CalcularConductorConMasKm(conductores[0], conductores[1], conductores[2]));
            Console.WriteLine("El conductor que hizo más km el día 3.", CalcularConductorConMasKmDia(conductores[0], conductores[1], conductores[2], 3));
            Console.WriteLine("El conductor que hizo más km el día 5.", CalcularConductorConMasKmDia(conductores[0], conductores[1], conductores[2], 5));

        }

        static string CalcularConductorConMasKm(Conductor conductor1, Conductor conductor2, Conductor conductor3) {

            string conductorConMasKm = "";
            int maxKm = 0;

            Conductor[] conductores = { conductor1, conductor2, conductor3 };

            foreach (Conductor conductor in conductores)
            {
                int kms = conductor.ObtenerKmsRecorridos();
                if (kms > maxKm)
                {
                    maxKm = kms;
                    conductorConMasKm = conductor.ConductorNombre;
                }
            }

            return conductorConMasKm;
        }

        static string CalcularConductorConMasKmDia(Conductor conductor1, Conductor conductor2, Conductor conductor3, int dia)
        {
            string conductorConMasKmDia = "";
            int maxKmDia3 = 0;

            Conductor[] conductores = { conductor1, conductor2, conductor3 };

            foreach (Conductor conductor in conductores)
            {
                int kmsDia3 = conductor.ObtenerKilometrosDia(dia);
                if (kmsDia3 > maxKmDia3)
                {
                    maxKmDia3 = kmsDia3;
                    conductorConMasKmDia = conductor.ConductorNombre;
                }
            }

            return conductorConMasKmDia;
        }

    }
}
