namespace ClassLibrary1
{
    public class Validador
    {

        public static bool Validar(int valor, int min, int max)
        { // metodo Estatico - si no le pogo public por defecto es privado
            if (valor >= min && valor <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int FindMax(List<int> valores)
        {
            int max = -101;
            foreach (var valor in valores)
            {
                if (valor > max)
                {
                    max = valor;
                }
            }

            return max;

        }

        public static int FindMin(List<int> valores)
        {

            int min = 101;

            foreach (var valor in valores)
            {
                if (valor < min)
                {
                    min = valor;
                }
            }

            return min;
        }

        public static decimal FindPromedio(List<int> valores)
        {

            int cantidad = valores.Count;
            int sumaTotal = 0;

            if (cantidad > 0)
            {
                foreach (var valor in valores)
                {
                    sumaTotal += valor;
                }

                decimal promedio = sumaTotal / cantidad;

                return promedio;
            }
            else
            {
                return -1000;
            }

        }

        public static bool ValidarRespuesta(string respuesta) {
            if (respuesta == "S") {
                return true;
            } else {
                return false;
            }  
        }
    }
}
