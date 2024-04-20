namespace ClassLibrary03
{
    public class Viaje
    {
        private const int duracion = 7;

        private int[] _kilometrosPorDia;

        public Viaje(int[] viaje)
        {
            this._kilometrosPorDia = viaje;
        }

        public int CalcularTotalKmRecorridos()
        {
            int sumaKms = 0;
            foreach (int dia in _kilometrosPorDia) {
                sumaKms += dia;
            }
            return sumaKms;
        }

        public int ObtenerKilometrosDia(int dia)
        {
            if (dia >= 1 && dia <=duracion)
            {
                return _kilometrosPorDia[dia - 1];
            }
            else
            {
                return -1;
            }
        }
    }
}
