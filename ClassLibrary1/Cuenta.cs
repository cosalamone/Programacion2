using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class Cuenta
    {
        private string _titular;
        private int _cantidad;


        public Cuenta(string titular, int cantidad) { 
            this._titular = titular;
            this._cantidad = cantidad;
        }

        public string GetTitular() { 
            return this._titular;
        }

        public int GetCantidad() {
            return this._cantidad;  
        }

        public string Mostrar() {
            string datos = "El titular es " + this._titular.ToString() + "  y la cantidad de dinero que tiene actualmente es " + this._cantidad ;
            return datos;
        }

        public void Ingresar(int montoAIngresar) { 
            this._cantidad += montoAIngresar;
        }

        public void Retirar(int montoARetirar) {
            this._cantidad -= montoARetirar;
        }

    }
}
