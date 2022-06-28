using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmentoSalario
{
    internal class Funcionario
    {
        public string nome;
        public double salarioBruto = 0;
        public double imposto = 0;
        public int aumento = 0;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentoSalario(double aumento)
        {
            salarioBruto = salarioBruto + (salarioBruto * (aumento / 100));
        }

        public override string ToString()
        {
            return nome 
                + " , R$ "
                + SalarioLiquido(). ToString("f2", CultureInfo.InvariantCulture );
        }
    }
}
