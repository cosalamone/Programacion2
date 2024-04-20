using System.Text;

namespace ClassLibrary1
{
    public class Persona
    {
        private string _nombre;
        private DateTime _fechaDeNacimiento;
        private int _dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this._nombre = nombre;
            this._fechaDeNacimiento = fechaNacimiento;
            this._dni = dni;
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return _fechaDeNacimiento; }
            set { this._fechaDeNacimiento = value; }
        }

        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;

            TimeSpan diferencia = fechaActual - fechaNacimiento;
            int edad = (int)(diferencia.Days / 365); // Usamos 365.25 para considerar los años bisiestos

            return edad;
;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this._nombre} tiene {CalcularEdad(this._fechaDeNacimiento)} años y su DNI es {this._dni}");

            string datos = sb.ToString();
            return datos;
        }

        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad(this._fechaDeNacimiento);
            return edad >= 18 ? "Es mayor de edad" : "Es menor de edad";
        }

    }

}
