using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Retangulo: PoligonoReto {

        private double _base;
        private double _altura;

        public Retangulo(double baseRetangulo, double altura) : base("Retangulo")
        {
            _base = baseRetangulo;
            _altura = altura;
        }

        public override double Area()
        {
            return _base * _altura;
        }

        public override double Perimetro()
        {
            return 2 * (_base + _altura);
        }
    }
}

