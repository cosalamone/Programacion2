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
        private int _x;
        private int _y;
        public Punto(int x, int y) {
            this._x = x;
            this._y = y;
        }

        public int X {
            get 
            { 
            return _x; 
            }    
        }

        public int Y {
            get 
            { 
            return _y;  
            }
        }

    }
}
