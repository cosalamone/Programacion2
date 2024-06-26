﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary03
{
    public class Conductor
    {
        private string _nombre;
        private Viaje _viaje;
        private int _totalKmsRecorridos;

        public Conductor(string nombre) {
            this._nombre = nombre;

        }

        public string ConductorNombre
        {
            get
            {
                return this._nombre;
               }
        }

        public Viaje RegistrarViaje(int[] viaje) {
            _viaje = new Viaje(viaje);
            return _viaje;
        }

        public int ObtenerKmsRecorridos() {
            if (_viaje != null)
            {
                return _viaje.CalcularTotalKmRecorridos();
            }
            return 0;
        }

        public int ObtenerKilometrosDia(int dia)
        {
            if (_viaje != null && dia >= 1 && dia <= 7) // Verificar que el día esté dentro del rango
            {
                return _viaje.ObtenerKilometrosDia(dia);
            }
            return 0;
        }



    }
}
