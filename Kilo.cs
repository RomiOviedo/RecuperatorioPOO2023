using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupPoo.Entidades
{
    public class Kilo
    {
        private float _equivalenciaEnLibra;
        private float _peso;

        public float GetPeso()
        {
            return _peso;
        }
        private Kilo(float peso)
        {
            _peso = peso;
        }
        public Kilo() : this(10) { }

        public static implicit operator float(Kilo kilo)
        {
            return kilo.GetPeso();
        }

    }
}
