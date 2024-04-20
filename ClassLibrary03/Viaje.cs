namespace ClassLibrary03
{
    public class Viaje
    {
        private const int duracion = 7;
        private int _dia1;
        private int _dia2;
        private int _dia3;
        private int _dia4;
        private int _dia5;
        private int _dia6;
        private int _dia7;
        private int[] _kilometrosPorDia;

        public Viaje(int dia1, int dia2, int dia3, int dia4, int dia5, int dia6, int dia7)
        {
            this._dia1 = dia1;
            this._dia2 = dia2;
            this._dia3 = dia3;
            this._dia4 = dia4;
            this._dia5 = dia5;
            this._dia6 = dia6;
            this._dia7 = dia7;

        }

        public int CalcularTotalKmRecorridos()
        {
            int totalKms = _dia1 + _dia2 + _dia3 + _dia4 + _dia5 + _dia6 + _dia7;
            return totalKms;
        }

        public int ObtenerKilometrosDia(int dia)
        {
            if (dia >= 1 && dia <=duracion)
            {
                return _kilometrosPorDia[dia - 1];
            }
            else
            {
                return 0;
            }
        }
    }
}
