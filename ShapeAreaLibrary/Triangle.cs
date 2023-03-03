using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary
{
    public class Triangle : Shape
    {
        public double A 
        { 
            get{ return a; } 
            set 
            {
                a = IsTriangleExists(value, b, c) || a < 0 ? value :
                    throw new ArgumentException("Треугольник с такой стороной не будет существовать.");
            } 
        }
        public double B 
        {
            get {  return b; }
            set
            {
                b = IsTriangleExists(value, a, c)  || b < 0? value :
                    throw new ArgumentException("Треугольник с такой стороной не будет существовать.");
            }
        }
        public double C 
        { 
            get { return c; } 
            set
            {
                c = IsTriangleExists(value, a, b) || c < 0 ? value :
                    throw new ArgumentException("Треугольник с такой стороной не будет существовать.");
            }
        }
        private double a;
        private double b;
        private double c;
     
        public double semiperimeter { get => (A + B + C) / 2; }
        /// <summary>
        /// Constructor for triangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c, string name):base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (!IsTriangleExists(a, b, c))
            {
                throw new ArgumentException("Такого треугольника не существет");
            }
        }

        public static bool IsTriangleExists(double a, double b, double c)
        {
            return !((a + b < c) || (a + c < b) || (b + c < a));
        }

        public bool IsRightTriangle()
        {
            return (A * A == B * B + C * C) ||
                    (B * B == A * A + C * C) ||
                    (C * C == A * A + B * B);
        }
        public override double GetArea()
        {
            double sp = this.semiperimeter;
            return Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
        }

       
    }
}
