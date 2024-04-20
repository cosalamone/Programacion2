using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public  class Rectangulo
    {
        private Punto _vertice1;
        private Punto _vertice2;    
        private Punto _vertice3;
        private Punto _vertice4;

        private double baseRectangulo;
        private double alturaRectangulo;

        private double area = -1;
        private double perimetro = -1;


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this._vertice1 = vertice1;
            this._vertice3 = vertice3;

            // Calcular la base y la altura
            this.baseRectangulo = Math.Abs(vertice3.X - vertice1.X);
            this.alturaRectangulo = Math.Abs(vertice3.Y - vertice1.Y);
        }

        public Punto Vertice1 { get { return _vertice1; } }
        public Punto Vertice2 { get { return new Punto(_vertice1.X, _vertice3.Y); } }
        public Punto Vertice3 { get { return _vertice3; } }
        public Punto Vertice4 { get { return new Punto(_vertice3.X, _vertice1.Y); } }


        public double Area
        {
            get
            {
                  return  baseRectangulo * alturaRectangulo;
            }
        }

        public double Perimetro
        {
            get
            {
                return 2 * (baseRectangulo + alturaRectangulo);
             }
        }
    }


}
