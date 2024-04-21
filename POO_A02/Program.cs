// VETERINARIA

using ClassLibraryVeterinaria;

namespace POO_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLIENTE 1

            List<Mascota> mascotasCliente1 = new List<Mascota>();
            mascotasCliente1.Add(new Mascota("perro", "pepe", new DateTime(2023, 02, 01)));
            Cliente cliente1 = new Cliente("Fernando", "Perez", "Calle falsa 123", 123456, mascotasCliente1);

            // CLIENTE 2

            List<string> vacunasCliente2 = new List<string>();
            vacunasCliente2.Add("Triple Felina");
            List<Mascota> mascotasCliente2 = new List<Mascota>();
            mascotasCliente2.Add(new Mascota("gato", "michi", new DateTime(2019, 11, 05), vacunasCliente2)); 
            
            Cliente cliente2 = new Cliente("Rosario", "Martinez", "Calle Arbolada 95", 123456, mascotasCliente2);


            // CLIENTE 3

            List<string> vacunasCliente3mascota1 = new List<string>();
            vacunasCliente3mascota1.Add("Antirrabica");
            List<Mascota> mascotasCliente3 = new List<Mascota>();
            mascotasCliente3.Add(new Mascota("perro", "Alfredo", new DateTime(2022, 08, 01), vacunasCliente3mascota1));
            mascotasCliente3.Add(new Mascota("gato", "Nino", new DateTime(2015, 10, 05)));

            Cliente cliente3 = new Cliente("Andrea", "Pereyra", "Calle Iluminada 4", 123456, mascotasCliente3);


            // 

            Console.WriteLine(cliente1.ObtenerDatosCliente());
            Console.WriteLine(cliente2.ObtenerDatosCliente());
            Console.WriteLine(cliente3.ObtenerDatosCliente());




        }
    }
}
