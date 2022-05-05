using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Calculadora
    {
        public double largura = 0;
        public double altura = 0;

       public double Area()
        {
        return largura * altura;
   
        }
        
        public double Perimetro()
        {
        return 2 * Area();
        }

        public double Diagonal()
        {
         return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));

        }

    }
}
