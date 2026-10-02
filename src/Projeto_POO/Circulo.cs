using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Circulo: Forma {


        private double _raio;

        public Circulo(double raio) : base("Círculo")
        {
            _raio = raio;
        }

        public override double Area()
        {
            return Math.PI * _raio * _raio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * _raio;
        }

    }
}
