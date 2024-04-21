using System.Text;

namespace Veterinaria
{
    public class Mascota
    {
        private string _especie;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private List<string> _historialVacunas = new List<string>();


        //Constructor de masconta con parametros obligatorios
        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this._especie = especie;
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
        }

        //Constructor con todos los parametros, reutilizando el primer constructor - sobrecarga
        public Mascota(string especie, string nombre, DateTime fechaNacimiento, List<string> historialVacunas) : this(especie, nombre, fechaNacimiento)
        {
            this._historialVacunas = historialVacunas;

        }

        public string ObtenerDatosMascota()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"* Mascota: {_nombre}");
            sb.AppendLine($"* Especie: {_especie}");
            sb.AppendLine($"* Fecha de nacimiento: {_fechaNacimiento}");

            if (_historialVacunas.Count > 0)
            {
                sb.AppendLine($"* Vacunas: {_fechaNacimiento}");


                foreach (string vacuna in _historialVacunas)
                {
                    sb.AppendLine($"   - {vacuna}");

                }
            }

            return sb.ToString();

        }
    }
}
