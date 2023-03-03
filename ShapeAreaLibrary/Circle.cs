using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary
{
    public class Circle : Shape
    {
        public double Radius { get => _radius; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Радиус не может быть меньше единицы");
                }
                _radius = value;
            } }

        private double _radius;
        private const double PI = Math.PI;
        public Circle(double radius, string name): base(name)
        {
            Radius = radius;
        }

        public override double GetArea() => PI * _radius * _radius;
    }
}
