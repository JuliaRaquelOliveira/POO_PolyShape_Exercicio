using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class TrianguloRetangulo : PoligonoReto
    {

        private double _catetoadjacente;
        private double _catetooposto;

        public TrianguloRetangulo(double catetoadjacente, double catetooposto)
        : base("Triângulo Retângulo")
        {
            _catetoadjacente = catetoadjacente;
            _catetooposto = catetooposto;
        }

        public override double Area()
        {
            return (_catetoadjacente * _catetooposto) / 2;
        }

        public override double Perimetro()
        {
            double hipotenusa = Math.Sqrt(
                (_catetoadjacente * _catetoadjacente) + (_catetooposto * _catetooposto)
            );

            return _catetoadjacente + _catetooposto + hipotenusa;
        }
    }
}
