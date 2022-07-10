using Ex_abstracao1.Entities.Enum;
using System;

namespace Ex_abstracao1.Entities
{
    internal class Circle : Shape 
    {

        public double Radius { get; set; }



        public Circle(double radius , Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
           return Math.PI *Radius *Radius ;
        }
    }
}
