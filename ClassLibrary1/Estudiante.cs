using System.Text;

namespace ClassLibrary1
{
    public class Estudiante
    {
        private static Random random = new Random();

        private string _nombre;
        private string _apellido;
        private int _legajo;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        public Estudiante(string nombre, string apellido, int legajo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
        }

        public int SetNotaPrimerParcial {
            set { this._notaPrimerParcial = value; }
        }

        public int SetNotaSegundoParcial {
            set { this._notaSegundoParcial = value; }
        }

        private int CalcularPromedio(int notaPrimerParcial, int notaSegundoParcial) { 
            int promedio = (notaPrimerParcial + notaSegundoParcial) / 2;
            return promedio;
        }

        public int CalcularNotaFinal(int notaPrimerParcial, int notaSegundoParcial) {

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            else {
                return -1;

            }
        }

        public string Mostrar() { 
        
            StringBuilder sb = new StringBuilder();

            sb.AppendLine( $"{this._nombre} {this._apellido} {this._legajo}");
            sb.AppendLine($"Nota primer parcial: {_notaPrimerParcial}. Nota segundo parcial: {_notaSegundoParcial}");
            sb.AppendLine($"Promedio de cursada: {CalcularPromedio(this._notaPrimerParcial, this._notaSegundoParcial)}");

            int notaFinal = CalcularNotaFinal(this._notaPrimerParcial, this._notaSegundoParcial);
            if (notaFinal == -1) {
                sb.AppendLine("Alumno desaprobado");
            } else {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }

            return sb.ToString();

        }

    }
}
