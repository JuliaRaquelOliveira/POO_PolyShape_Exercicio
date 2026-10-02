using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class Quadrado : PoligonoReto{

        private double _lado;

        public Quadrado(double lado) : base("Quadrado")
        {
            _lado = lado;
        }

        public override double Area()
        {
            return _lado * _lado;
        }

        public override double Perimetro()
        {
            return 4 * _lado;
        }

    }
}
