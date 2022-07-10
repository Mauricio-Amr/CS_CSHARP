using Ex_abstracao1.Entities.Enum;

namespace Ex_abstracao1.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();



    }
}
