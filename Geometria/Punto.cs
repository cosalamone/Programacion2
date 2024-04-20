using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private double _x;
        private double _y;
        public Punto(double x, double y) {
            this._x = x;
            this._y = y;
        }

        public double X {
            get 
            { 
            return _x; 
            }    
        }

        public double Y {
            get 
            { 
            return _y;  
            }
        }

    }
}
