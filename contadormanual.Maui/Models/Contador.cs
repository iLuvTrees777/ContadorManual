using System;
using System.Collections.Generic;
using System.Text;

namespace contadormanual.Maui.Models
{
    public class Contador
    {
        private int _conteo;

        public int conteo => _conteo;

        public Contador()
        {
            _conteo = 0;
        }

        public void Contar()
        {
            _conteo++;
        }

        public void Reiniciar()
        {
            _conteo = 0;
        }
    }
}