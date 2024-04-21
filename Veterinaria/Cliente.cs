using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private int _telefono;
        private List<Mascota> _mascotas;

        // 1 cliente puede tener 1 o + mascostas

        public Cliente(string nombre, string apellido, string domicilio, int telefono, List<Mascota> mascotas)
        {
            this._nombre = nombre;  
            this._apellido = apellido;
            this._domicilio = domicilio;
            this._telefono = telefono;
            this._mascotas = mascotas; 
        }



        public string ObtenerDatosCliente() { 
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cliente: {_nombre} {_apellido}");
            sb.AppendLine($"Direccion: {_domicilio}");
            sb.AppendLine($"Telefono: {_telefono}");

            if (_mascotas.Count > 0) {
               

                foreach (Mascota mascota in _mascotas) {
                    sb.AppendLine($"{mascota.ObtenerDatosMascota()}");

                }
            }

            return sb.ToString();

        }
    }




    
}
