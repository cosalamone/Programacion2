// A01 - Vienen con sistema de auto-navegación

using ClassLibrary03;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] conductores = ["Carlos", "Maria", "Susana"];

            Conductor conductor1 = new Conductor(conductores[0]);
            Conductor conductor2 = new Conductor(conductores[1]);
            Conductor conductor3 = new Conductor(conductores[2]);

            conductor1.RegistrarViaje(120, 233, 145, 325, 90, 123, 0);
            conductor2.RegistrarViaje(234, 0, 0, 356, 222, 89, 152);
            conductor3.RegistrarViaje(154, 254, 312, 78, 0, 198, 478);


            CalcularConductorConMasKm(conductor1, conductor2, conductor3);

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

        static string CalcularConductorConMasKmDia3(Conductor conductor1, Conductor conductor2, Conductor conductor3)
        {
            string conductorConMasKmDia3 = "";
            int maxKmDia3 = 0;

            Conductor[] conductores = { conductor1, conductor2, conductor3 };

            foreach (Conductor conductor in conductores)
            {
                int kmsDia3 = conductor.ObtenerKilometrosDia(3); // Método que deberás implementar en la clase Conductor
                if (kmsDia3 > maxKmDia3)
                {
                    maxKmDia3 = kmsDia3;
                    conductorConMasKmDia3 = conductor.ConductorNombre;
                }
            }

            return conductorConMasKmDia3;
        }

        static void CalcularConductorConMasKmDia5()
        {
        }
    }
}
