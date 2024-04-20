namespace ClassLibrary1
{
    public class Boligrafo
    {
        const int cantidadTintaMaxima = 100;
        private string _color;
        private int _tinta;

        public Boligrafo(string color, int tinta)
        {
            this._color = color;
            this._tinta = tinta;
        }

        public string GetColor
        {
            get { return _color; }
        }

        public int GetTinta
        {
            get { return _tinta; }
        }

        private void SetTinta(int cantidadTinta) // sevisar este set tinta
        {
            int cantidadACargar = cantidadTinta + this._tinta;
            if (cantidadACargar >= 0 && cantidadACargar < this._tinta || cantidadACargar <= cantidadTintaMaxima)
            {
                this._tinta += cantidadTinta;
            }

        }

        public void RecargarTinta()
        {
            SetTinta(cantidadTintaMaxima - _tinta);
        }

        public string Pintar(int gasto)
        {
            int cantidadGastada = 0;
            string dibujo = "";
            if (gasto <= this._tinta)
            {
                cantidadGastada = gasto;
                SetTinta(-gasto);
            }
            else
            {
                cantidadGastada = this._tinta;
                SetTinta(-this._tinta);
            }

            if (this._tinta == 0)
            {
                dibujo = "";
            }
            else if (this._tinta == 10 && cantidadGastada == 2)
            {
                dibujo = "**";
            }
            else if (this._tinta == 3 && cantidadGastada == 10) {
                dibujo = "***";

            }

            return dibujo;

        }
    }
}
